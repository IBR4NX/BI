using Presentation.Forms.Docks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Presentation.Forms.Docks
{
    public partial class frmDockWindowBase : DockContent
    {
        public frmDockWindowBase()
        {
            InitializeComponent();

            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = AppTheme.Background;
            ForeColor = AppTheme.Text;
        }

        private void tsmiClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void tsmiCloseAll_Click(object sender, System.EventArgs e)
        {
            this.CloseForms(false);
        }

        private void tsmiCloseOthers_Click(object sender, System.EventArgs e)
        {
            this.CloseForms(true);
        }

        private void CloseForms(bool isCloseOthers)
        {
            var documents = this.DockPanel.DocumentsToArray();
            var currentDocument = this.DockPanel.ActiveDocument;

            foreach (IDockContent document in documents)
            {
                if (isCloseOthers && document == currentDocument)
                {
                    continue;
                }

                FormDocument conentForm = document as FormDocument;

                conentForm.Close();
            }
        }

        private void frmDockWindowBase_Load(object sender, System.EventArgs e)
        {
            if(this.Tag != null)
            {
                this.TabPageContextMenuStrip = this.contextMenuStrip1;
            }
            else
            {
                this.HideOnClose = true;
            }
        }
    }
}
