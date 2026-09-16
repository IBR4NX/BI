namespace Presentation.Forms.Docks
{
    partial class frmColumnsInfo
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
            lstVColumns = new ListView();
            cHeader1 = new ColumnHeader();
            cHeader2 = new ColumnHeader();
            cHeader3 = new ColumnHeader();
            cHeader4 = new ColumnHeader();
            cHeader5 = new ColumnHeader();
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
            lstVColumns.LabelEdit = true;
            lstVColumns.LabelWrap = false;
            lstVColumns.Location = new Point(0, 0);
            lstVColumns.Name = "lstVColumns";
            lstVColumns.Size = new Size(575, 450);
            lstVColumns.TabIndex = 9;
            lstVColumns.UseCompatibleStateImageBehavior = false;
            lstVColumns.View = View.Details;
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
            // frmColumnsInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 450);
            Controls.Add(lstVColumns);
            Name = "frmColumnsInfo";
            Text = "frmColumnsInfo";
            ResumeLayout(false);
        }

        #endregion

        private ListView lstVColumns;
        private ColumnHeader cHeader1;
        private ColumnHeader cHeader2;
        private ColumnHeader cHeader3;
        private ColumnHeader cHeader4;
        private ColumnHeader cHeader5;
    }
}