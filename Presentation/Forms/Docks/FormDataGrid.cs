using Domain.Definition;
using System.Data;
using Presentation.Forms.Base;
using Domain.Entities;
using DataAccess.QueryBuilder;
using Business.Services;
using System.Diagnostics;

namespace Presentation.Forms.Docks
{
    public partial class FormDataGrid : frmDockWindowBase
    {
        public TableInfo tableInfo=new ();

        private DataTable? table;
        public FormDataGrid()
        {
            InitializeComponent();
            cmbFilters.BackColor = Theme.InputBackground;
            cmbFilters.ForeColor = Theme.Text;
            txtFilter.BackColor = Theme.InputBackground;
            txtFilter.ForeColor = Theme.Text;
            ConfigureControls();
        }
        public void SetDataSource(DataTable dataTable)
        {
            table = dataTable;
            Text = dataTable.TableName;
            DgvData.DataSource = table;
            foreach (DataColumn column in table.Columns)
            {
                cmbFilters.Items.Add(column.ColumnName);
            }
            cmbFilters.SelectedIndex = 0;
        }

        private void ConfigureControls()
        {

            cmbFilterOperator.DataSource = Enum.GetValues<ComparisonOperator>();
            cmbFilterOperator.SelectedItem = nameof(ComparisonOperator.Equal);
        }




        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string name = cmbFilters.Text.Trim();
            if (table == null)
                return;
            if (name is "choose filter" || txtFilter.Text.Trim() == "")
            {
                table.DefaultView.RowFilter = "";
                return;
            }

            try
            {
                DataColumn? column = table.Columns[name];

                if (column == null)
                {
                    return;
                }

                string columnType = column.DataType.ToString();

                //string columnType = table.Columns[name].DataType.ToString();
                columnType = columnType.Remove(0, 7);
                if (columnType.StartsWith("", StringComparison.OrdinalIgnoreCase))
                {

                    table.DefaultView.RowFilter = string.Format("[{0}] = {1}", name, txtFilter.Text.Trim());
                    txtlabel.Text = ":int: ";
                }

                if (columnType.StartsWith("str", StringComparison.OrdinalIgnoreCase))
                {

                    txtlabel.Text = ":str: ";
                    table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "", txtFilter.Text.Trim());
                }
                txtlabel.Text = txtlabel.Text + name + columnType;
            }
            catch (Exception ex)
            {
                errProvider.SetError(txtFilter, ex.Message);


            }





        }

        private void FormDataGrid_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void FormDataGrid_Load(object sender, EventArgs e)
        {

        }

        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteTheItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = DgvData.SelectedRows[0];

            var filter = new FilterDefinition
            {
                Column = new ColumnInfo { Name = tableInfo.PrimaryKeyColumn.Trim() },
                Operator = ComparisonOperator.Equal,
            };
            filter.Values.Add(row.Cells[filter.Column.Name].Value?.ToString()!);
            Debug.WriteLine("val:" + filter.Column.Name + " "+filter.Values[0]);

            if(QueryBuilderService.DeleteColumns(tableInfo, filter))
                table?.Rows.RemoveAt(row.Index);


        }
    }
}
