using Business.Metadata;
using Business.Services;
using DataAccess.Factory;
using DataAccess.QueryBuilder;
using Domain.Definition;
using Presentation.Forms.Docks;
using System.Data;
using System.Diagnostics;
using WeifenLuo.WinFormsUI.Docking;

namespace Presentation
{
    public partial class MainForm : Form
    {
        public static QueryService _queryService;
        private readonly List<FilterDefinition> _filters = new();
        private int dgvOpenDistance;
        private readonly List<JoinDefinition> _joins = new();
        public static IDbProviderFactory providerFactory;

        public FormExplore frmExplore = new FormExplore();
        public FormColumns frmColumns = new FormColumns();
        //public FormFilters frmFilters = new FormFilters();
        public FormDocument frmDocument = new FormDocument();
        public FormDataGrid frmDataGrid = new FormDataGrid();
        public DockPane documentPane;
        public DockPane documentPane2;

        //public string ConnectionString = "";
        //public string server = "";




        #region MainForm fun
        public MainForm()
        {
            InitializeComponent();
            //string connectionString = @"Server=.;Database=AdventureWorks2025;Trusted_Connection=True;TrustServerCertificate=True;";

        }

        [STAThread]
        private void MainForm_Load(object sender, EventArgs e)
        {
            var login = new Login();
            ShowFormDock();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {

                providerFactory = login.providerFactory;
                MetadataService.MetadataProvider(login.providerFactory.MetadataProvider);
                clsEventActions.DatabaseChanged += notifi;
            }
            else
            {
                errProvider.SetError(login, " no");
                Application.Exit();
            }
            frmExplore.loaddatabases();

            ConfigureControls();
            SetupStyle();
        }
        
        #endregion


        public void notifi(string database)
        {
                Debug.WriteLine("notif.before: ");
            try
            {

                Debug.WriteLine("notif.0: ");
                MetadataService.CorrectDataBase(database);
                Debug.WriteLine("notif.1: ");
               providerFactory.ConnectionStringBuilder.ConnectionSettings.Database = database;
                Debug.WriteLine("notif.2: ");
                providerFactory.ReBuild(providerFactory.ConnectionStringBuilder.Build());
                MetadataService.MetadataProvider(providerFactory.MetadataProvider);
                Debug.WriteLine("notif.3: ");
                MetadataService.StorTables();
                Debug.WriteLine("notif.4: ");
                _queryService = new QueryService(providerFactory);
                frmExplore.LoadTables();
                MetadataService.GetMetadata();
                frmDocument.SetupAutocomplete();
                QueryBuilderService._ProviderFactory = providerFactory;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private async void ShowFormDock()
        {

            frmExplore.Show(dockPanel, DockState.DockLeft);
            dockPanel.DockLeftPortion = 350;


            // form center
            frmDocument.Show(dockPanel, DockState.Document);
            documentPane = frmDocument.Pane;

            // form center bottom
            frmDataGrid.Show(documentPane, DockAlignment.Bottom, 0.5);
            frmDataGrid.DockStateChanged += tsltest1_MouseHover;
            frmDataGrid.HideOnClose = true;
            //frmDataGrid.DockAreas = DockAreas.Document;
            frmDataGrid.Hide();

            frmColumns.Show(documentPane, DockAlignment.Bottom, 0.3);
            //frmColumns.AllowEndUserDocking = false;
            //documentPane2 = frmColumns.Pane;
            //frmFilters.Show(documentPane2, DockAlignment.Right, 0.5);
        }


        #region Btn Start , Fetch data
        private void BtnStart_Click(object sender, EventArgs e)
        {
            
            try
            {
                var table = frmExplore.GetTableInfo();
                frmDataGrid.tableInfo = table;
                var result = new DataTable();
                Debug.WriteLine(table.Name);
                if (frmDocument.IsActivated || table.Name =="")
                {
                    result = _queryService.Execute(frmDocument.Editor.Text.Trim());
                    frmDataGrid.SetDataSource(result);
                    frmDataGrid.Show();
                    return;
                }

                IQueryBuilder queryBuilder = new QueryBuilder(providerFactory.ParameterFactory);
                queryBuilder.Select(frmColumns.GetColumns())
                    .From(table).Where(frmColumns.GetFilters());
                var query = queryBuilder.Build();
                //MessageBox.Show("00000" + query );
                var p = queryBuilder.GetParameters().ToArray();
                if (p.Length > 0)
                {
                    //foreach (var param in p)
                    //{
                    //    MessageBox.Show($"Parameter: {param.ParameterName}, Value: {param.Value}");
                    //}
                    result = _queryService.Execute(query, p);
                }
                else
                {
                    result = _queryService.Execute(query);
                }

                showFormDock(frmDataGrid, new FormDataGrid(), documentPane);
                frmDataGrid.SetDataSource(result);



            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + ex);
                showMessage(ex.Message + ex);
                errProvider.SetError(this, "Error: " + ex.Message);

            }
        }
        #endregion


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
            btmStatusStrip.BackColor = Theme.Background;
            btmStatusStrip.ForeColor = Theme.Text;


        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {


               
        }

        private void tsLabel_Click(object sender, EventArgs e)
        {
            tsLabel.Text = "DockState:" + frmDataGrid.DockState + ";    IsDisposed:" + frmDataGrid.IsDisposed + "-   IsActivated:" + frmDataGrid.IsActivated;
        }


        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            //showDataBox();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataGrid.Hide();
        }

        private void fliterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataGrid.Show();
        }

        private void newFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataGrid = new FormDataGrid();
        }

        private void tsltest1_Click(object sender, EventArgs e)
        {
            dockPanel.DockLeftPortion = 350;
            frmDataGrid.Show();
        }

        private void tsltest1_MouseHover(object sender, EventArgs e)
        {
            setChanged();

        }
        public void setChanged()
        {
            frmDataGrid.ShowInTaskbar = false;
            tsltest1.Text = frmDataGrid.IsDisposed + " : " + frmDataGrid.IsActivated + " : " + frmDataGrid.DockState;
            tsltest2.Text = ": "+((short)frmDocument.DockState)  + "" + " : dis=" + frmExplore.IsDisposed + " : ictv=" + frmDocument.IsActivated + " :hid " + frmDocument.IsHidden;
        }



        #region Show Form Dock
        public void showFormDock(DockContent dockContent, DockContent DockNew, DockPane dockPane, DockAlignment alignment = DockAlignment.Bottom, Double size = 0.5)
        {
            if (dockContent.IsDisposed)
            {
                tsslabel.Text = "IsDisposed New:" + dockContent.IsDisposed;
                dockContent = DockNew;
                dockContent.Show(dockPane, alignment, size);
            }
            checkState(dockContent);

            if (!dockContent.IsActivated)
            {
                tsslabel.Text = "IsActivated" + dockContent.IsActivated;
                //DockNew.Close();
                dockContent.Activate();
                dockContent.Show();

            }
        }

        public void showFormDock(DockContent dockContent, DockContent DockNew, DockPanel dockPanel, DockState dockState = DockState.Document)
        {
            if (dockContent.IsDisposed)
            {
                tsslabel.Text = "IsDisposed New:" + dockContent.IsDisposed;
                dockContent = DockNew;
                dockContent.Show(dockPanel, dockState);
            }
            checkState(dockContent);

            if (!dockContent.IsActivated)
            {
                tsslabel.Text = "IsActivated" + dockContent.IsActivated;
                //DockNew.Close();
                dockContent.Activate();
                dockContent.Show();

            }

        }
        public void checkState(DockContent dockContent)
        {
            if (dockContent.DockState.Equals(DockState.DockLeftAutoHide))
                dockContent.DockState = DockState.DockLeft;
            else if (dockContent.DockState.Equals(DockState.DockRightAutoHide))
                dockContent.DockState = DockState.DockRight;
            else if (dockContent.DockState.Equals(DockState.DockTopAutoHide))
                dockContent.DockState = DockState.DockTop;
            else if (dockContent.DockState.Equals(DockState.DockBottomAutoHide))
                dockContent.DockState = DockState.DockBottom;
        }

        #endregion

        private void listDataBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataGrid.Show();
        }

        private void listColumnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColumns.Show();
        }

        private void listFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmFilters.Show();
        }

        private void listExploreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExplore.Show();


        }

        private void dockPanel_ActiveContentChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (providerFactory.ConnectionFactory.ConnectionOpened())
            //{
            //    StatusLabelConnection.Text = "Connected";
            //}
            //else 
            //{
            //    StatusLabelConnection.Text = "Disconnected";
                
            //}
        }
    }

}
