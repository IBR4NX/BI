namespace Presentation
{
    partial class ShwoMessage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCopy = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            message = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCopy
            // 
            btnCopy.AccessibleRole = AccessibleRole.Dialog;
            btnCopy.BackColor = Color.FromArgb(99, 102, 241);
            btnCopy.BackgroundImageLayout = ImageLayout.Zoom;
            btnCopy.CausesValidation = false;
            btnCopy.DialogResult = DialogResult.OK;
            btnCopy.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnCopy.FlatAppearance.BorderSize = 0;
            btnCopy.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnCopy.FlatAppearance.MouseOverBackColor = Color.Black;
            btnCopy.FlatStyle = FlatStyle.Flat;
            btnCopy.ForeColor = SystemColors.ButtonHighlight;
            btnCopy.Location = new Point(289, 9);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(94, 29);
            btnCopy.TabIndex = 1;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = false;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(36, 38, 44);
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(180, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnCopy);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(16, 384);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 50);
            panel1.TabIndex = 2;
            // 
            // message
            // 
            message.AutoCompleteCustomSource.AddRange(new string[] { "se ", "de", "be" });
            message.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            message.AutoCompleteSource = AutoCompleteSource.CustomSource;
            message.BackColor = Color.FromArgb(36, 38, 44);
            message.BorderStyle = BorderStyle.None;
            message.Cursor = Cursors.IBeam;
            message.Dock = DockStyle.Fill;
            message.ForeColor = SystemColors.Window;
            message.Location = new Point(16, 16);
            message.Margin = new Padding(16);
            message.Multiline = true;
            message.Name = "message";
            message.ScrollBars = ScrollBars.Vertical;
            message.Size = new Size(399, 368);
            message.TabIndex = 3;
            message.Text = "Ibrahim";
            // 
            // ShwoMessage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 38, 44);
            ClientSize = new Size(431, 450);
            Controls.Add(message);
            Controls.Add(panel1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ShwoMessage";
            Padding = new Padding(16);
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Warning";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCopy;
        private Button btnClose;
        private Panel panel1;
        private TextBox message;
    }
}
