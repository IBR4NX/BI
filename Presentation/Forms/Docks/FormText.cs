using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Presentation.Forms.Base;

namespace Presentation.Forms.Docks
{
    public partial class FormText : frmDockWindowBase
    {
        public FormText()
        {
            InitializeComponent();

        }

        private void FormText_Load(object sender, EventArgs e)
        {
            rTextBox.BackColor = Theme.Surface;
            rTextBox.ForeColor = Theme.Text;

        }
    }
}
