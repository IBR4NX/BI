namespace Presentation.Forms.Docks
{
    partial class FormDataGrid
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DgvData = new DataGridView();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            txtFilter = new TextBox();
            cmbFilterOperator = new ComboBox();
            groupBox1 = new GroupBox();
            cmbFilters = new ComboBox();
            txtlabel = new Label();
            errProvider = new ErrorProvider(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)DgvData).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // DgvData
            // 
            DgvData.AllowUserToDeleteRows = false;
            DgvData.AllowUserToResizeRows = false;
            DgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DgvData.BackgroundColor = Color.FromArgb(36, 38, 44);
            DgvData.BorderStyle = BorderStyle.None;
            DgvData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(38, 40, 47);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(235, 235, 240);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvData.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(36, 38, 44);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(240, 246, 252);
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(55, 58, 70);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvData.DefaultCellStyle = dataGridViewCellStyle2;
            DgvData.Dock = DockStyle.Fill;
            DgvData.EnableHeadersVisualStyles = false;
            DgvData.GridColor = Color.FromArgb(55, 58, 66);
            DgvData.Location = new Point(0, 45);
            DgvData.Name = "DgvData";
            DgvData.ReadOnly = true;
            DgvData.RowHeadersVisible = false;
            DgvData.RowHeadersWidth = 51;
            DgvData.RowTemplate.Height = 32;
            DgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvData.Size = new Size(800, 405);
            DgvData.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(txtFilter);
            panel1.Controls.Add(cmbFilterOperator);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(cmbFilters);
            panel1.Controls.Add(txtlabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4);
            panel1.Size = new Size(800, 45);
            panel1.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Dock = DockStyle.Left;
            dateTimePicker1.Location = new Point(437, 4);
            dateTimePicker1.Margin = new Padding(6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(218, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // txtFilter
            // 
            txtFilter.Dock = DockStyle.Left;
            txtFilter.Location = new Point(312, 4);
            txtFilter.Margin = new Padding(6);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(125, 27);
            txtFilter.TabIndex = 0;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // cmbFilterOperator
            // 
            cmbFilterOperator.Dock = DockStyle.Left;
            cmbFilterOperator.FormattingEnabled = true;
            cmbFilterOperator.Location = new Point(161, 4);
            cmbFilterOperator.Margin = new Padding(6);
            cmbFilterOperator.Name = "cmbFilterOperator";
            cmbFilterOperator.Size = new Size(151, 28);
            cmbFilterOperator.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(155, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(6, 37);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // cmbFilters
            // 
            cmbFilters.Dock = DockStyle.Left;
            cmbFilters.FormattingEnabled = true;
            cmbFilters.Location = new Point(4, 4);
            cmbFilters.Margin = new Padding(6);
            cmbFilters.Name = "cmbFilters";
            cmbFilters.Size = new Size(151, 28);
            cmbFilters.TabIndex = 1;
            // 
            // txtlabel
            // 
            txtlabel.AutoSize = true;
            txtlabel.Location = new Point(675, 11);
            txtlabel.Name = "txtlabel";
            txtlabel.Size = new Size(50, 20);
            txtlabel.TabIndex = 2;
            txtlabel.Text = "label1";
            // 
            // errProvider
            // 
            errProvider.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 32);
            // 
            // FormDataGrid
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DgvData);
            Controls.Add(panel1);
            HideOnClose = true;
            Name = "FormDataGrid";
            ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.Hidden;
            ShowInTaskbar = false;
            FormClosing += FormDataGrid_FormClosing;
            Load += FormDataGrid_Load;
            ((System.ComponentModel.ISupportInitialize)DgvData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvData;
        private Panel panel1;
        private Label txtlabel;
        private ComboBox cmbFilters;
        private TextBox txtFilter;
        private DateTimePicker dateTimePicker1;
        private ErrorProvider errProvider;
        private GroupBox groupBox1;
        private ComboBox cmbFilterOperator;
        private ContextMenuStrip contextMenuStrip1;
    }
}