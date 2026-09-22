namespace Presentation.Controls.Base
{
    partial class ColumnsControl
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
            uClabel1 = new UClabel();
            SuspendLayout();
            // 
            // uClabel1
            // 
            uClabel1.AutoSize = true;
            uClabel1.ForeColor = Color.FromArgb(240, 246, 252);
            uClabel1.Location = new Point(25, 15);
            uClabel1.Name = "uClabel1";
            uClabel1.Size = new Size(67, 20);
            uClabel1.TabIndex = 0;
            uClabel1.Text = "uClabel1";
            // 
            // ColumnsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(uClabel1);
            Name = "ColumnsControl";
            Size = new Size(264, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UClabel uClabel1;
    }
}
