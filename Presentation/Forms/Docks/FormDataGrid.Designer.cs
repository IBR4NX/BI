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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DgvData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvData).BeginInit();
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
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(235, 235, 240);
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(55, 58, 70);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvData.DefaultCellStyle = dataGridViewCellStyle2;
            DgvData.Dock = DockStyle.Fill;
            DgvData.EnableHeadersVisualStyles = false;
            DgvData.GridColor = Color.FromArgb(55, 58, 66);
            DgvData.Location = new Point(0, 0);
            DgvData.Name = "DgvData";
            DgvData.ReadOnly = true;
            DgvData.RowHeadersVisible = false;
            DgvData.RowHeadersWidth = 51;
            DgvData.RowTemplate.Height = 32;
            DgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvData.Size = new Size(800, 450);
            DgvData.TabIndex = 4;
            // 
            // FormDataGrid
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DgvData);
            Name = "FormDataGrid";
            ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.Hidden;
            ShowInTaskbar = false;
            FormClosing += FormDataGrid_FormClosing;
            ((System.ComponentModel.ISupportInitialize)DgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvData;
    }
}