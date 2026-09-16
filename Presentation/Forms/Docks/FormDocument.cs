using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
namespace Presentation.Forms.Docks
{
    public partial class FormDocument : DockContent
    {
        public FormDocument()
        {
            InitializeComponent();
            DockAreas = DockAreas.Document;
        }

        private void lstVColumns_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void SetupStyle()
        {
            BackColor = AppTheme.Background;

            tpToolStrip.BackColor = AppTheme.Background;
            tpToolStrip.ForeColor = AppTheme.Text;

        }
    }
}
