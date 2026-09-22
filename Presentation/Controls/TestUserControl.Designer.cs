using Presentation.Controls.Base;

namespace Presentation.Controls
{
    partial class TestUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmb = new ComboBox();
            cmb11 = new cmb1();
            SuspendLayout();
            // 
            // cmb
            // 
            cmb.FormattingEnabled = true;
            cmb.Location = new Point(70, 78);
            cmb.Margin = new Padding(0);
            cmb.Name = "cmb";
            cmb.Size = new Size(151, 28);
            cmb.TabIndex = 0;
            // 
            // cmb11
            // 
            cmb11.BackColor = Color.FromArgb(16, 20, 26);
            cmb11.DrawMode = DrawMode.OwnerDrawFixed;
            cmb11.FlatStyle = FlatStyle.Flat;
            cmb11.ForeColor = Color.FromArgb(240, 246, 252);
            cmb11.FormattingEnabled = true;
            cmb11.Location = new Point(23, 67);
            cmb11.Name = "cmb11";
            cmb11.Size = new Size(151, 28);
            cmb11.TabIndex = 1;
            // 
            // TestUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(cmb11);
            Controls.Add(cmb);
            Name = "TestUserControl";
            Size = new Size(234, 179);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmb;
        private cmb1 cmb11;
    }
}
