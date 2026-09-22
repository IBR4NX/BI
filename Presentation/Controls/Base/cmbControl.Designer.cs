namespace Presentation.Controls.Base
{
    partial class cmbControl
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
            SuspendLayout();
            // 
            // cmb
            // 
            cmb.FormattingEnabled = true;
            cmb.Location = new Point(0, 0);
            cmb.Margin = new Padding(0);
            cmb.Name = "cmb";
            cmb.Size = new Size(151, 28);
            cmb.TabIndex = 0;
            // 
            // cmbControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(cmb);
            Name = "cmbControl";
            Size = new Size(151, 28);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmb;
    }
}
