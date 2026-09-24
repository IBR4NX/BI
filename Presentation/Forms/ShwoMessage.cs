using Presentation.Forms.Base;

namespace Presentation
{
    public partial class ShwoMessage : BaseForm
    {
        public ShwoMessage(string text)
        {
            InitializeComponent();
            message.Text = text;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(message.Text??"empty clipboard");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
