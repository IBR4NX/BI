namespace Presentation.Controls
{
    partial class ucFilter
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
            cbFilterValue = new ComboBox();
            lstFilters = new ListView();
            cHeader1 = new ColumnHeader();
            cHeader2 = new ColumnHeader();
            cHeader3 = new ColumnHeader();
            label2 = new Label();
            CmbLogical = new ComboBox();
            lblFilter = new Label();
            BtnClearFilters = new Button();
            lblOperator = new Label();
            BtnAddFilter = new Button();
            lblValue = new Label();
            cmbFilterOperator = new ComboBox();
            CbColumnsFilter = new ComboBox();
            SuspendLayout();
            // 
            // cbFilterValue
            // 
            cbFilterValue.FormattingEnabled = true;
            cbFilterValue.Location = new Point(307, 43);
            cbFilterValue.Name = "cbFilterValue";
            cbFilterValue.Size = new Size(111, 28);
            cbFilterValue.TabIndex = 30;
            // 
            // lstFilters
            // 
            lstFilters.BackColor = Color.FromArgb(36, 38, 44);
            lstFilters.BorderStyle = BorderStyle.FixedSingle;
            lstFilters.Columns.AddRange(new ColumnHeader[] { cHeader1, cHeader2, cHeader3 });
            lstFilters.ForeColor = SystemColors.Window;
            lstFilters.FullRowSelect = true;
            lstFilters.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lstFilters.HoverSelection = true;
            lstFilters.LabelEdit = true;
            lstFilters.LabelWrap = false;
            lstFilters.Location = new Point(15, 81);
            lstFilters.Name = "lstFilters";
            lstFilters.Size = new Size(418, 143);
            lstFilters.TabIndex = 29;
            lstFilters.UseCompatibleStateImageBehavior = false;
            lstFilters.View = View.Details;
            lstFilters.SelectedIndexChanged += lstFilters_SelectedIndexChanged;
            lstFilters.DoubleClick += lstFilters_DoubleClick;
            // 
            // cHeader1
            // 
            cHeader1.Text = "Name";
            cHeader1.Width = 150;
            // 
            // cHeader2
            // 
            cHeader2.Text = "Operator";
            cHeader2.TextAlign = HorizontalAlignment.Center;
            cHeader2.Width = 100;
            // 
            // cHeader3
            // 
            cHeader3.Text = "values";
            cHeader3.TextAlign = HorizontalAlignment.Center;
            cHeader3.Width = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.FromArgb(160, 163, 175);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(502, 20);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 28;
            label2.Text = "Logic";
            // 
            // CmbLogical
            // 
            CmbLogical.BackColor = Color.FromArgb(36, 38, 44);
            CmbLogical.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbLogical.FlatStyle = FlatStyle.Flat;
            CmbLogical.Font = new Font("Segoe UI", 9F);
            CmbLogical.ForeColor = Color.FromArgb(235, 235, 240);
            CmbLogical.Location = new Point(472, 43);
            CmbLogical.Name = "CmbLogical";
            CmbLogical.Size = new Size(75, 28);
            CmbLogical.TabIndex = 27;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Font = new Font("Segoe UI", 9F);
            lblFilter.ForeColor = Color.FromArgb(160, 163, 175);
            lblFilter.ImeMode = ImeMode.NoControl;
            lblFilter.Location = new Point(15, 17);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(60, 20);
            lblFilter.TabIndex = 20;
            lblFilter.Text = "Column";
            // 
            // BtnClearFilters
            // 
            BtnClearFilters.BackColor = Color.FromArgb(36, 38, 44);
            BtnClearFilters.FlatAppearance.BorderColor = Color.FromArgb(55, 58, 66);
            BtnClearFilters.FlatStyle = FlatStyle.Flat;
            BtnClearFilters.Font = new Font("Segoe UI", 9F);
            BtnClearFilters.ForeColor = Color.FromArgb(160, 163, 175);
            BtnClearFilters.ImeMode = ImeMode.NoControl;
            BtnClearFilters.Location = new Point(452, 149);
            BtnClearFilters.Name = "BtnClearFilters";
            BtnClearFilters.Size = new Size(120, 30);
            BtnClearFilters.TabIndex = 26;
            BtnClearFilters.Text = "Clear Filters";
            BtnClearFilters.UseVisualStyleBackColor = false;
            BtnClearFilters.Click += BtnClearFilters_Click;
            // 
            // lblOperator
            // 
            lblOperator.AutoSize = true;
            lblOperator.Font = new Font("Segoe UI", 9F);
            lblOperator.ForeColor = Color.FromArgb(160, 163, 175);
            lblOperator.ImeMode = ImeMode.NoControl;
            lblOperator.Location = new Point(176, 17);
            lblOperator.Name = "lblOperator";
            lblOperator.Size = new Size(69, 20);
            lblOperator.TabIndex = 21;
            lblOperator.Text = "Operator";
            // 
            // BtnAddFilter
            // 
            BtnAddFilter.BackColor = Color.FromArgb(99, 102, 241);
            BtnAddFilter.FlatAppearance.BorderSize = 0;
            BtnAddFilter.FlatStyle = FlatStyle.Flat;
            BtnAddFilter.Font = new Font("Segoe UI Semibold", 9F);
            BtnAddFilter.ForeColor = Color.White;
            BtnAddFilter.ImeMode = ImeMode.NoControl;
            BtnAddFilter.Location = new Point(452, 97);
            BtnAddFilter.Name = "BtnAddFilter";
            BtnAddFilter.Size = new Size(120, 29);
            BtnAddFilter.TabIndex = 25;
            BtnAddFilter.Text = "Add Filter";
            BtnAddFilter.UseVisualStyleBackColor = false;
            BtnAddFilter.Click += BtnAddFilter_Click;
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Font = new Font("Segoe UI", 9F);
            lblValue.ForeColor = Color.FromArgb(160, 163, 175);
            lblValue.ImeMode = ImeMode.NoControl;
            lblValue.Location = new Point(337, 17);
            lblValue.Margin = new Padding(3);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(55, 20);
            lblValue.TabIndex = 22;
            lblValue.Text = "Values ";
            // 
            // cmbFilterOperator
            // 
            cmbFilterOperator.BackColor = Color.FromArgb(36, 38, 44);
            cmbFilterOperator.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterOperator.FlatStyle = FlatStyle.Flat;
            cmbFilterOperator.Font = new Font("Segoe UI", 9F);
            cmbFilterOperator.ForeColor = Color.FromArgb(235, 235, 240);
            cmbFilterOperator.Location = new Point(154, 42);
            cmbFilterOperator.Name = "cmbFilterOperator";
            cmbFilterOperator.Size = new Size(120, 28);
            cmbFilterOperator.TabIndex = 24;
            // 
            // CbColumnsFilter
            // 
            CbColumnsFilter.BackColor = Color.FromArgb(36, 38, 44);
            CbColumnsFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            CbColumnsFilter.FlatStyle = FlatStyle.Flat;
            CbColumnsFilter.Font = new Font("Segoe UI", 9F);
            CbColumnsFilter.ForeColor = Color.FromArgb(235, 235, 240);
            CbColumnsFilter.Location = new Point(15, 40);
            CbColumnsFilter.Name = "CbColumnsFilter";
            CbColumnsFilter.Size = new Size(120, 28);
            CbColumnsFilter.TabIndex = 23;
            // 
            // ucFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(cbFilterValue);
            Controls.Add(lstFilters);
            Controls.Add(label2);
            Controls.Add(CmbLogical);
            Controls.Add(lblFilter);
            Controls.Add(BtnClearFilters);
            Controls.Add(lblOperator);
            Controls.Add(BtnAddFilter);
            Controls.Add(lblValue);
            Controls.Add(cmbFilterOperator);
            Controls.Add(CbColumnsFilter);
            Name = "ucFilter";
            Size = new Size(575, 227);
            Load += ucFilter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbFilterValue;
        private ListView lstFilters;
        private ColumnHeader cHeader1;
        private ColumnHeader cHeader2;
        private ColumnHeader cHeader3;
        private Label label2;
        private ComboBox CmbLogical;
        private Label lblFilter;
        private Button BtnClearFilters;
        private Label lblOperator;
        private Button BtnAddFilter;
        private Label lblValue;
        private ComboBox cmbFilterOperator;
        private ComboBox CbColumnsFilter;
    }
}
