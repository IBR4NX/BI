using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.Forms.Base
{
    public partial class BaseForm : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            BackColor = Theme.Background;
            ForeColor = Theme.Text;
        }
    }
}
