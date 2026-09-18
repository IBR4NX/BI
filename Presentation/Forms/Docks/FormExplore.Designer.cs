namespace Presentation.Forms.Docks
{
    partial class FormExplore
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExplore));
            trTableInfo = new TreeView();
            iconlist = new ImageList(components);
            txtSearch = new TextBox();
            SuspendLayout();
            // 
            // trTableInfo
            // 
            trTableInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trTableInfo.ForeColor = SystemColors.InfoText;
            trTableInfo.ImageIndex = 0;
            trTableInfo.ImageList = iconlist;
            trTableInfo.Location = new Point(0, 60);
            trTableInfo.Name = "trTableInfo";
            trTableInfo.SelectedImageIndex = 0;
            trTableInfo.Size = new Size(230, 390);
            trTableInfo.TabIndex = 0;
            trTableInfo.AfterSelect += trTableInfo_AfterSelect;
            // 
            // iconlist
            // 
            iconlist.ColorDepth = ColorDepth.Depth32Bit;
            iconlist.ImageStream = (ImageListStreamer)resources.GetObject("iconlist.ImageStream");
            iconlist.TransparentColor = Color.Transparent;
            iconlist.Images.SetKeyName(0, "schema");
            iconlist.Images.SetKeyName(1, "table");
            iconlist.Images.SetKeyName(2, "key");
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(206, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // FormObjects
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 450);
            Controls.Add(txtSearch);
            Controls.Add(trTableInfo);
            Name = "FormObjects";
            Text = "Dock Content";
            FormClosing += FormObjects_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TreeView trTableInfo;
        private TextBox txtSearch;
        private ImageList iconlist;
    }
}