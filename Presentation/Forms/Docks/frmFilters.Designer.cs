namespace Presentation.Forms.Docks
{
    partial class frmFilters
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
            lstFilters = new ListView();
            label2 = new Label();
            CmbLogical = new ComboBox();
            lblFilter = new Label();
            BtnAddFilter = new Button();
            BtnClearFilters = new Button();
            lblOperator = new Label();
            lblValue = new Label();
            CbColumnsFilter = new ComboBox();
            cmbFilterOperator = new ComboBox();
            txtFilterValue = new TextBox();
            SuspendLayout();
            // 
            // lstFilters
            // 
            lstFilters.BackColor = Color.FromArgb(36, 38, 44);
            lstFilters.BorderStyle = BorderStyle.None;
            lstFilters.ForeColor = Color.White;
            lstFilters.Location = new Point(10, 90);
            lstFilters.Name = "lstFilters";
            lstFilters.Size = new Size(378, 80);
            lstFilters.TabIndex = 15;
            lstFilters.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.FromArgb(160, 163, 175);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(512, 7);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 13;
            label2.Text = "Logic";
            // 
            // CmbLogical
            // 
            CmbLogical.BackColor = Color.FromArgb(36, 38, 44);
            CmbLogical.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbLogical.FlatStyle = FlatStyle.Flat;
            CmbLogical.Font = new Font("Segoe UI", 9F);
            CmbLogical.ForeColor = Color.FromArgb(235, 235, 240);
            CmbLogical.Location = new Point(462, 30);
            CmbLogical.Name = "CmbLogical";
            CmbLogical.Size = new Size(75, 28);
            CmbLogical.TabIndex = 12;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Font = new Font("Segoe UI", 9F);
            lblFilter.ForeColor = Color.FromArgb(160, 163, 175);
            lblFilter.ImeMode = ImeMode.NoControl;
            lblFilter.Location = new Point(25, 4);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(60, 20);
            lblFilter.TabIndex = 0;
            lblFilter.Text = "Column";
            // 
            // BtnAddFilter
            // 
            BtnAddFilter.BackColor = Color.FromArgb(99, 102, 241);
            BtnAddFilter.FlatAppearance.BorderSize = 0;
            BtnAddFilter.FlatStyle = FlatStyle.Flat;
            BtnAddFilter.Font = new Font("Segoe UI Semibold", 9F);
            BtnAddFilter.ForeColor = Color.White;
            BtnAddFilter.ImeMode = ImeMode.NoControl;
            BtnAddFilter.Location = new Point(417, 90);
            BtnAddFilter.Name = "BtnAddFilter";
            BtnAddFilter.Size = new Size(120, 29);
            BtnAddFilter.TabIndex = 6;
            BtnAddFilter.Text = "Add Filter";
            BtnAddFilter.UseVisualStyleBackColor = false;
            // 
            // BtnClearFilters
            // 
            BtnClearFilters.BackColor = Color.FromArgb(36, 38, 44);
            BtnClearFilters.FlatAppearance.BorderColor = Color.FromArgb(55, 58, 66);
            BtnClearFilters.FlatStyle = FlatStyle.Flat;
            BtnClearFilters.Font = new Font("Segoe UI", 9F);
            BtnClearFilters.ForeColor = Color.FromArgb(160, 163, 175);
            BtnClearFilters.ImeMode = ImeMode.NoControl;
            BtnClearFilters.Location = new Point(417, 140);
            BtnClearFilters.Name = "BtnClearFilters";
            BtnClearFilters.Size = new Size(120, 30);
            BtnClearFilters.TabIndex = 8;
            BtnClearFilters.Text = "Clear Filters";
            BtnClearFilters.UseVisualStyleBackColor = false;
            // 
            // lblOperator
            // 
            lblOperator.AutoSize = true;
            lblOperator.Font = new Font("Segoe UI", 9F);
            lblOperator.ForeColor = Color.FromArgb(160, 163, 175);
            lblOperator.ImeMode = ImeMode.NoControl;
            lblOperator.Location = new Point(186, 4);
            lblOperator.Name = "lblOperator";
            lblOperator.Size = new Size(69, 20);
            lblOperator.TabIndex = 1;
            lblOperator.Text = "Operator";
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Font = new Font("Segoe UI", 9F);
            lblValue.ForeColor = Color.FromArgb(160, 163, 175);
            lblValue.ImeMode = ImeMode.NoControl;
            lblValue.Location = new Point(347, 4);
            lblValue.Margin = new Padding(3);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(55, 20);
            lblValue.TabIndex = 2;
            lblValue.Text = "Values ";
            // 
            // CbColumnsFilter
            // 
            CbColumnsFilter.BackColor = Color.FromArgb(36, 38, 44);
            CbColumnsFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            CbColumnsFilter.FlatStyle = FlatStyle.Flat;
            CbColumnsFilter.Font = new Font("Segoe UI", 9F);
            CbColumnsFilter.ForeColor = Color.FromArgb(235, 235, 240);
            CbColumnsFilter.Location = new Point(25, 27);
            CbColumnsFilter.Name = "CbColumnsFilter";
            CbColumnsFilter.Size = new Size(120, 28);
            CbColumnsFilter.TabIndex = 3;
            // 
            // cmbFilterOperator
            // 
            cmbFilterOperator.BackColor = Color.FromArgb(36, 38, 44);
            cmbFilterOperator.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterOperator.FlatStyle = FlatStyle.Flat;
            cmbFilterOperator.Font = new Font("Segoe UI", 9F);
            cmbFilterOperator.ForeColor = Color.FromArgb(235, 235, 240);
            cmbFilterOperator.Location = new Point(164, 29);
            cmbFilterOperator.Name = "cmbFilterOperator";
            cmbFilterOperator.Size = new Size(120, 28);
            cmbFilterOperator.TabIndex = 4;
            // 
            // txtFilterValue
            // 
            txtFilterValue.AcceptsReturn = true;
            txtFilterValue.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtFilterValue.BackColor = Color.FromArgb(36, 38, 44);
            txtFilterValue.BorderStyle = BorderStyle.FixedSingle;
            txtFilterValue.Font = new Font("Segoe UI", 9F);
            txtFilterValue.ForeColor = Color.FromArgb(235, 235, 240);
            txtFilterValue.Location = new Point(313, 30);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.PlaceholderText = "Enter value...";
            txtFilterValue.Size = new Size(120, 27);
            txtFilterValue.TabIndex = 5;
            // 
            // frmFilters
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(563, 223);
            Controls.Add(label2);
            Controls.Add(lstFilters);
            Controls.Add(CmbLogical);
            Controls.Add(lblFilter);
            Controls.Add(BtnClearFilters);
            Controls.Add(lblOperator);
            Controls.Add(BtnAddFilter);
            Controls.Add(txtFilterValue);
            Controls.Add(lblValue);
            Controls.Add(cmbFilterOperator);
            Controls.Add(CbColumnsFilter);
            ForeColor = SystemColors.Control;
            Name = "frmFilters";
            Text = "frmFilters";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstFilters;
        private Label label2;
        private ComboBox CmbLogical;
        private Label lblFilter;
        private Button BtnAddFilter;
        private Button BtnClearFilters;
        private Label lblOperator;
        private Label lblValue;
        private ComboBox CbColumnsFilter;
        private ComboBox cmbFilterOperator;
        private TextBox txtFilterValue;
    }
}