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
            BackColor = Theme.Background;

            tpToolStrip.BackColor = Theme.Background;
            tpToolStrip.ForeColor = Theme.Text;
            ssbtm.BackColor = Theme.Background;
            ssbtm.ForeColor = Theme.Text;

            rtbox.BackColor = Theme.Surface;
            rtbox.ForeColor = Theme.Text;

        }
    }
}
