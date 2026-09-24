namespace Presentation.Forms.Docks
{
    partial class FormColumns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormColumns));
            lstVColumns = new ListView();
            cHeader1 = new ColumnHeader();
            cHeader2 = new ColumnHeader();
            cHeader3 = new ColumnHeader();
            cHeader4 = new ColumnHeader();
            cHeader5 = new ColumnHeader();
            splitContainer1 = new SplitContainer();
            imageList1 = new ImageList(components);
            ucFilter1 = new Presentation.Controls.ucFilter();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // lstVColumns
            // 
            lstVColumns.BackColor = Color.FromArgb(36, 38, 44);
            lstVColumns.BorderStyle = BorderStyle.FixedSingle;
            lstVColumns.CheckBoxes = true;
            lstVColumns.Columns.AddRange(new ColumnHeader[] { cHeader1, cHeader2, cHeader3, cHeader4, cHeader5 });
            lstVColumns.Dock = DockStyle.Fill;
            lstVColumns.ForeColor = SystemColors.Window;
            lstVColumns.FullRowSelect = true;
            lstVColumns.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lstVColumns.HoverSelection = true;
            lstVColumns.LabelWrap = false;
            lstVColumns.LargeImageList = imageList1;
            lstVColumns.Location = new Point(0, 0);
            lstVColumns.Name = "lstVColumns";
            lstVColumns.Size = new Size(539, 450);
            lstVColumns.SmallImageList = imageList1;
            lstVColumns.TabIndex = 9;
            lstVColumns.UseCompatibleStateImageBehavior = false;
            lstVColumns.View = View.Details;
            lstVColumns.SelectedIndexChanged += lstVColumns_SelectedIndexChanged;
            // 
            // cHeader1
            // 
            cHeader1.Text = "Column Name";
            cHeader1.Width = 200;
            // 
            // cHeader2
            // 
            cHeader2.Text = "type";
            cHeader2.Width = 100;
            // 
            // cHeader3
            // 
            cHeader3.Text = "Length";
            // 
            // cHeader4
            // 
            cHeader4.Text = "Nullable";
            cHeader4.TextAlign = HorizontalAlignment.Center;
            cHeader4.Width = 70;
            // 
            // cHeader5
            // 
            cHeader5.Text = "Key";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lstVColumns);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(ucFilter1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1162, 450);
            splitContainer1.SplitterDistance = 539;
            splitContainer1.SplitterWidth = 10;
            splitContainer1.TabIndex = 10;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8_key.ico");
            imageList1.Images.SetKeyName(1, "icons8_cut_32.png");
            imageList1.Images.SetKeyName(2, "add-icon(3).png");
            // 
            // ucFilter1
            // 
            ucFilter1.AutoSize = true;
            ucFilter1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ucFilter1.Dock = DockStyle.Top;
            ucFilter1.Location = new Point(0, 0);
            ucFilter1.Name = "ucFilter1";
            ucFilter1.Size = new Size(613, 227);
            ucFilter1.TabIndex = 0;
            // 
            // FormColumns
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 450);
            Controls.Add(splitContainer1);
            HideOnClose = true;
            Name = "FormColumns";
            Text = "frmColumnsInfo";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView lstVColumns;
        private ColumnHeader cHeader1;
        private ColumnHeader cHeader2;
        private ColumnHeader cHeader3;
        private ColumnHeader cHeader4;
        private ColumnHeader cHeader5;
        private SplitContainer splitContainer1;
        private Controls.ucFilter ucFilter1;
        private ImageList imageList1;
    }
}