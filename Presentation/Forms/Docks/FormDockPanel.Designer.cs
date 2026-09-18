namespace Presentation.Forms.Docks
{
    partial class FormDockPanel
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
            dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            vS2015DarkTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme();
            SuspendLayout();
            // 
            // dockPanel1
            // 
            dockPanel.Dock = DockStyle.Fill;
            dockPanel.DockBackColor = Color.FromArgb(45, 45, 48);
            dockPanel.Location = new Point(0, 0);
            dockPanel.Name = "dockPanel1";
            dockPanel.Padding = new Padding(6);
            dockPanel.ShowAutoHideContentOnHover = false;
            dockPanel.Size = new Size(800, 450);
            dockPanel.TabIndex = 0;
            dockPanel.Theme = vS2015DarkTheme1;
            // 
            // FormDockPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dockPanel);
            Name = "FormDockPanel";
            Text = "FormDockPanel";
            ResumeLayout(false);
        }

        #endregion

        public WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme vS2015DarkTheme1;
    }
}