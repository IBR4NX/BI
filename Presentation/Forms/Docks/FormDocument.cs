namespace Presentation.Forms.Docks
{
    public partial class FormDocument : frmDockWindowBase
    {
        //FormText frmText = new FormText();
        public FormDocument()
        {
            InitializeComponent();
            //DockAreas = DockAreas.Document| DockAreas.Float;
            this.Tag = "";
            ShowFormDock();
            SetupStyle();


        }
        private void ShowFormDock()
        {
            //frmText = new FormText();
            //frmText.Dock = DockStyle.Fill;
            //frmText.Show(dockPanel);
        }


        public void SetupStyle()
        {
            BackColor = AppTheme.Background;

            tpToolStrip.BackColor = AppTheme.Background;
            tpToolStrip.ForeColor = AppTheme.Text;
            ssbtm.BackColor = AppTheme.Background;
            ssbtm.ForeColor = AppTheme.Text;

            rtbox.BackColor = AppTheme.Surface;
            rtbox.ForeColor = AppTheme.Text;

        }
    }
}
