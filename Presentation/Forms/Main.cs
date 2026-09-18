using Business.Metadata;
using Business.Services;
using DataAccess.Factory;
using DataAccess.QueryBuilder;
using DataAccess.SqlServer;
using Domain.Definition;
using Domain.Entities;
using System.Data;

//using QuestPDF.Fluent;
//using QuestPDF.Helpers;
//using QuestPDF.Infrastructure;
using System.Diagnostics;
using System.Text.Json;

using System.Windows.Forms;

namespace Presentation
{
    public partial class Main : Form
    {
        //private readonly MetadataService MetadataService;
        private readonly QueryService _queryService;
        private readonly List<FilterDefinition> _filters = new();
        private int _targetSplitterDistance = 500;
        private int dgvOpenDistance;
        private readonly List<JoinDefinition> _joins = new();
        private TableInfo? _selectedTableInfo;
        private List<ColumnInfo>? _selectedColumnInfos = new List<ColumnInfo>();
        //private readonly IQueryBuilder queryBuilder ;
        private readonly IDbProviderFactory _providerFactory;
        public Main()
        {
            InitializeComponent();
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=AdventureWorks2025;Trusted_Connection=True;TrustServerCertificate=True;";
            IDbProviderFactory providerFactory = new SqlServerDatabaseProviderFactory(connectionString);
              MetadataService.MetadataProvider(providerFactory.MetadataProvider);
            _queryService = new QueryService(providerFactory);
            _providerFactory = providerFactory;
            Debug.WriteLine("Main");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MetadataService.GetMetadata();
            MetadataService.StorTables();
            dgvOpenDistance = splitContainer1.SplitterDistance;
            ConfigureControls();
            LoadTables();
        }
        private void LoadTables()
        {

            foreach (var info in MetadataService.Metadata.treeTableInfo
                .Where(table => table.Key.Contains(textBox1.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                TreeNode node = new TreeNode(info.Key);
                node.Tag = info;
                node.ImageIndex = 0;

                List<TreeNode> childNodes = info.Value
                    .Select(table => new TreeNode(table.Name) { Tag = table, ImageIndex = 1 })
                    .ToList();

                node.Nodes.AddRange(childNodes.ToArray());
                node.Expand();

                trTableInfo.Nodes.Add(node);
            }

            if (trTableInfo.Nodes.Count > 0)
            {
                trTableInfo.SelectedNode = null;
                trTableInfo.TopNode = trTableInfo.Nodes[0];
            }
        }

        private void LoadColumns(TableInfo tableInfo)
        {
            ClearFiltersList();
            CbColumnsFilter.Items.Clear();
            lstVColumns.Items.Clear();
            List<ColumnInfo> columns = MetadataService.GetColumns(tableInfo);
            if (columns.Count == 0)
            {
                Helper.Show($"No columns found for table {tableInfo.Name} {tableInfo.Schema}.");
                return;
            }
            foreach (var column in columns)
            {


                CbColumnsFilter.Items.Add(column);

                string key = column.IsPrimaryKey && column.IsForeignKey ? "PK, FK"
                    : column.IsPrimaryKey
                    ? "PK"
                    : column.IsForeignKey
                    ? "FK" : "";

                ListViewItem item = new ListViewItem(column.Name);
                item.SubItems.Add(column.DataType);
                item.SubItems.Add(column.MaxLength.ToString());
                item.SubItems.Add(column.IsNullable ? "Yes" : "No");
                item.SubItems.Add(key);
                item.Tag = column;
                lstVColumns.Items.Add(item);
                txtFilterValue.AutoCompleteCustomSource.Add(column.Name);
            }
            CbColumnsFilter.SelectedIndex = 0;

            LoadJoinForeignKeys();

            UpdateSelectedColumnsStatus();
        }

        private void trTableInfo_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (trTableInfo.SelectedNode is not TreeNode)
                return;
            if (trTableInfo.SelectedNode.Tag is TableInfo tableInfo)
            {

                LoadColumns(tableInfo!);
                lblColumns.Text = tableInfo.Name;
                _selectedTableInfo = tableInfo;
            }
            //LoadJoinTables(tableName);

            BtnStart.Focus();

        }

        private void ClbColumns_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke(UpdateSelectedColumnsStatus);
        }


        private void BtnStart_Click(object sender, EventArgs e)
        {

            try
            {
                _selectedColumnInfos!.Clear();
                foreach (ListViewItem item in lstVColumns.CheckedItems)
                {
                    if (item.Tag is ColumnInfo columnInfo)
                    {
                        _selectedColumnInfos!.Add(columnInfo);
                    }
                }
                IQueryBuilder queryBuilder = new QueryBuilder(_providerFactory.ParameterFactory);
                queryBuilder.Select(_selectedColumnInfos)
                    .From(_selectedTableInfo!).Where(_filters);
                var query = queryBuilder.Build();
                //MessageBox.Show("00000" + query );
                var result = new DataTable();
                var p = queryBuilder.GetParameters().ToArray();
                if (p.Length > 0)
                {
                    foreach (var param in p)
                    {
                        MessageBox.Show($"Parameter: {param.ParameterName}, Value: {param.Value}");
                    }
                    result = _queryService.Execute(query, p);
                }
                else
                {
                    result = _queryService.Execute(query);
                }


                DgvData.DataSource = result;
                Opensplit();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + ex);
                showMessage(ex.Message + ex);

            }
        }
        public void showMessage(string message)
        {
            Form f = new ShwoMessage(message);
            f.ShowDialog();

        }
        private void lstVColumns_Click(object sender, EventArgs e)
        {
            if (lstVColumns.SelectedItems.Count > 0)
            {
                var selectedItem = lstVColumns.SelectedItems[0];
                selectedItem.Checked = !selectedItem.Checked;
                string columnName = selectedItem.SubItems[0].Text;
                var columnInfo = MetadataService.GetColumns(_selectedTableInfo!).FirstOrDefault(c => c.Name == columnName);
                if (columnInfo != null)
                {
                    _selectedColumnInfos!.Add(columnInfo);
                }
            }

        }


        private FilterDefinition BuildFilter()
        {
            if (CbColumnsFilter.SelectedItem is null || cmbFilterOperator.SelectedItem is null
                || cmbValueType.SelectedItem is null || CmbLogical.SelectedItem is null)
            {
                throw new InvalidOperationException("Please select a column, operator, value type, and logical operator.");
            }
            var filter = new FilterDefinition
            {
                Column = MetadataService.GetColumn(CbColumnsFilter.Text),
                Operator = (ComparisonOperator)cmbFilterOperator.SelectedItem!,
                ValueType = (FilterValueType)cmbValueType.SelectedItem!,
                LogicalOperator = (LogicalOperator)CmbLogical.SelectedItem!
            };
            string valueText = txtFilterValue.Text.Trim();
            if (filter.Operator is ComparisonOperator.Between or ComparisonOperator.In)
            {
                filter.Values = valueText.Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)
                    .Cast<object>()
                    .ToList();
            }
            else
            {
                filter.Values.Add(filter.Operator == ComparisonOperator.Like ? $"'%'{valueText}'%'" : valueText);
            }

            return filter;
        }


        private void ConfigureControls()
        {
            textBox1.TextChanged += (_, _) => LoadTables();
            CmbLogical.DataSource = Enum.GetValues<LogicalOperator>();
            cmbValueType.DataSource = Enum.GetValues<FilterValueType>();
            CmbLogical.SelectedItem = 0;
            cmbFilterOperator.DataSource = Enum.GetValues<ComparisonOperator>();
            cmbFilterOperator.SelectedItem = nameof(ComparisonOperator.Equal);

            cmbJoinType.DataSource = Enum.GetValues<JoinType>();
        }

        private void BtnAddFilter_Click(object? sender, EventArgs e)
        {
            FilterDefinition filter = BuildFilter();
            _filters.Add(filter);
            lstFilters.Items.Add($"{filter.Column.Name} {filter.Operator} - {filter.Values}".Trim());
        }

        private void ClearFiltersList()
        {
            lstFilters.Items.Clear();
            _filters.Clear();
        }

        private void BtnClearFilters_Click(object sender, EventArgs e)
        {
            ClearFiltersList();
        }



        private void ClbColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnStart.Focus();
        }


        private void UpdateSelectedColumnsStatus()
        {

            StatusLabelCountColumnsSelected.Text = _selectedColumnInfos?.Count.ToString();
        }

        private void toolStripSplitBtnHidden_ButtonClick(object sender, EventArgs e)
        {
            if (splitContainer1.SplitterDistance < dgvOpenDistance - 20)
            {
                Opensplit();
            }
            else
            {
                Closesplit();
            }
        }
        public void Opensplit()
        {
            splitContainer1.SplitterDistance = _targetSplitterDistance;
        }
        public void Closesplit()
        {
            splitContainer1.SplitterDistance = dgvOpenDistance;
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            Helper.Show("The editor will be available soon. ");

        }

        private void BtnPrint_Click(object? sender, EventArgs e)
        {
            if (DgvData.Rows.Count == 0)
            {
                MessageBox.Show("There is no data to print.");
                return;
            }

            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(DgvData.GetClipboardContent()?.GetText() ?? "empty clipboard");
        }

        private void cpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(DgvData.SelectedCells.ToString()!);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnAddJoin_Click(object sender, EventArgs e)
        {
            ColumnInfo fk = (ColumnInfo)cmbForeignKey.SelectedItem!;
            JoinType joinType = (JoinType)cmbJoinType.SelectedItem!;

            _joins.Add(new JoinDefinition
            {
                JoinType = joinType,
                ForeignKeyColumn = fk
            });

            ListViewItem item = new ListViewItem(joinType.ToString());
            item.SubItems.Add(fk.TableName);
            item.SubItems.Add(fk.Name);
            item.SubItems.Add(fk.ReferencedTable);
            item.SubItems.Add(fk.ReferencedColumn);

            item.Tag = _joins[0];

            lvJoins.Items.Add(item);
        }
        private void cmbForeignKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbForeignKey.SelectedItem is not ColumnInfo foreignKey)
                return;

            LoadReferencedColumns(foreignKey);
        }
        private void LoadJoinForeignKeys()
        {
            cmbForeignKey.Items.Clear();

            if (_selectedTableInfo == null)
                return;

            List<ColumnInfo> foreignKeys = MetadataService.Metadata.Columns
                .Where(c =>
                    c.SchemaName == _selectedTableInfo.Schema &&
                    c.TableName == _selectedTableInfo.Name &&
                    c.IsForeignKey)
                .ToList();

            foreach (ColumnInfo column in foreignKeys)
            {
                cmbForeignKey.Items.Add(column);
            }

            cmbForeignKey.DisplayMember = "Name";
        }

        private void LoadReferencedColumns(ColumnInfo foreignKey)
        {
            clbJoinColumns.Items.Clear();

            List<ColumnInfo> columns = MetadataService.Metadata.Columns
                .Where(c =>
                    c.SchemaName == foreignKey.ReferencedSchema &&
                    c.TableName == foreignKey.ReferencedTable)
                .ToList();

            foreach (ColumnInfo column in columns)
            {
                clbJoinColumns.Items.Add(column, false);
            }

            clbJoinColumns.DisplayMember = "Name";
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstVColumns_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            splitContainer2.SplitterDistance = 300;
            openMenu.Visible = false;
            closeMenu1.Visible = true;
        }

        private void closeMenu1_Click(object sender, EventArgs e)
        {
            splitContainer2.SplitterDistance = 0;
            openMenu.Visible = true;
            closeMenu1.Visible = false;

        }

        private void toolStripContainer1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
