using Business.Metadata;
using Business.Services;
using DataAccess.Factory;
using DataAccess.QueryBuilder;
using DataAccess.SqlServer;
using Domain.Definition;
using Domain.Entities;
using Presentation.Forms.Docks;
using System.Data;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Presentation
{
    public partial class MainForm : Form
    {
        private readonly QueryService _queryService;
        private readonly List<FilterDefinition> _filters = new();
        private int _targetSplitterDistance = 500;
        private int dgvOpenDistance;
        private readonly List<JoinDefinition> _joins = new();
        private List<ColumnInfo>? _selectedColumnInfos = new List<ColumnInfo>();
        //private readonly IQueryBuilder queryBuilder ;
        private readonly IDbProviderFactory _providerFactory;

        public frmColumnsInfo frmColumns;
        public FormObjects formDockContent;
        public MainForm()
        {
            InitializeComponent();
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=AdventureWorks2025;Trusted_Connection=True;TrustServerCertificate=True;";
            IDbProviderFactory providerFactory = new SqlServerDatabaseProviderFactory(connectionString);
            MetadataService.MetadataProvider(providerFactory.MetadataProvider);
            MetadataService.GetMetadata();
            MetadataService.StorTables();
            //_queryService = new QueryService(providerFactory);
            //_providerFactory = providerFactory;
            frmColumns = new frmColumnsInfo();
            frmColumns.Show(dockPanel);
            ConfigureControls();
            SetupStyle();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowFormDock();
            //statusStrip1.them
            //this.SuspendLayout();
        }
        private void ShowFormDock()
        {

            formDockContent = new FormObjects();
            formDockContent.Show(dockPanel, DockState.DockLeft);
            formDockContent.Width = 200;
            formDockContent.LoadTables();
            FormDocument formDocument = new FormDocument();
            formDocument.Show(dockPanel);
            frmFilters filters = new frmFilters();
            filters.Show(dockPanel);
        }


        public void RefreshColumnsInfo()
        {
            frmColumns.Activate();
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {

            try
            {
            //    _selectedColumnInfos!.Clear();
            //    foreach (ListViewItem item in lstVColumns.CheckedItems)
            //    {
            //        if (item.Tag is ColumnInfo columnInfo)
            //        {
            //            _selectedColumnInfos!.Add(columnInfo);
            //        }
            //    }
            //    IQueryBuilder queryBuilder = new QueryBuilder(_providerFactory.ParameterFactory);
            //    queryBuilder.Select(_selectedColumnInfos)
            //        .From(_selectedTableInfo!).Where(_filters);
            //    var query = queryBuilder.Build();
            //    //MessageBox.Show("00000" + query );
            //    var result = new DataTable();
            //    var p = queryBuilder.GetParameters().ToArray();
            //    if (p.Length > 0)
            //    {
            //        foreach (var param in p)
            //        {
            //            MessageBox.Show($"Parameter: {param.ParameterName}, Value: {param.Value}");
            //        }
            //        result = _queryService.Execute(query, p);
            //    }
            //    else
            //    {
            //        result = _queryService.Execute(query);
            //    }


            //    DgvData.DataSource = result;
            //    Opensplit();

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
        public void ConfigureControls()
        {
            //EventCenterAction.RefreshNavigator += RefreshColumnsInfo;


        }
        public void SetupStyle()
        {
            btmStatusStrip.BackColor = AppTheme.Background;
            btmStatusStrip.ForeColor = AppTheme.Text;


        }
    }

}
