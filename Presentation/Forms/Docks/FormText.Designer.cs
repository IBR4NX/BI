namespace Presentation.Forms.Docks
{
    partial class FormText
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // rTextBox
            // 
            rTextBox.BackColor = Color.Gray;
            rTextBox.Dock = DockStyle.Fill;
            rTextBox.Location = new Point(0, 0);
            rTextBox.Name = "rTextBox";
            rTextBox.Size = new Size(800, 450);
            rTextBox.TabIndex = 0;
            rTextBox.Text = "";
            // 
            // FormText
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(rTextBox);
            HideOnClose = true;
            Name = "FormText";
            Text = "FormText";
            Load += FormText_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rTextBox;
    }
}