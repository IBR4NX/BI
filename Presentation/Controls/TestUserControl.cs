using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentation.Controls
{
    public partial class TestUserControl : UserControl
    {
        public TestUserControl()
        {
            InitializeComponent();
            BackColor = Theme.Background;
           cmb.BackColor = Theme.InputBackground;
           cmb.ForeColor = Theme.Text;
           cmb.FlatStyle = FlatStyle.Flat;

        }
    }
    
}
