using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentation.Forms.Docks
{
    public partial class BaseForm : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            BackColor = AppTheme.Background;
            ForeColor = AppTheme.Text;
        }
        public  Color ColorBackground = Color.FromArgb(22, 27, 34);
        public  Color ColorSurface = Color.FromArgb(13, 17, 23);
        public Color ColorBorder = Color.FromArgb(48, 54, 61);
        public  Color ColorText = Color.FromArgb(230, 237, 243);
        public  Color ColorMutedText = Color.FromArgb(139, 148, 158);
        public  Color ColorPrimary = Color.FromArgb(124, 58, 237);
        public void SetupStyle(Control control)
        {
            control.BackColor = AppTheme.Background;
            control.ForeColor = AppTheme.Text;
        }
    }
}
