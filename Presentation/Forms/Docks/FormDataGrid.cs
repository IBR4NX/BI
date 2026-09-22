using Domain.Definition;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Presentation.Forms.Docks
{
    public partial class FormDataGrid : frmDockWindowBase
    {
        private DataTable? table;
        public FormDataGrid()
        {
            InitializeComponent();
            cmbFilters.BackColor = Theme.InputBackground;
            cmbFilters.ForeColor = Theme.Text;
            txtFilter.BackColor = Theme.InputBackground;
            txtFilter.ForeColor = Theme.Text;
            ConfigureControls();
        }
        public void SetDataSource(DataTable dataTable)
        {
            table = dataTable;
            Text = EventCenterAction._selectedTableInfo.Name;
            DgvData.DataSource = table;
            foreach (DataColumn column in table.Columns)
            {
                cmbFilters.Items.Add(column.ColumnName);
            }

        }

        private void ConfigureControls()
        {

            cmbFilterOperator.DataSource = Enum.GetValues<ComparisonOperator>();
            cmbFilterOperator.SelectedItem = nameof(ComparisonOperator.Equal);
        }




        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string name = cmbFilters.Text.Trim();

            if (name is "choose filter" || txtFilter.Text.Trim() == "")
            {
                table.DefaultView.RowFilter = "";
                return;
            }

            try
            {
                DataColumn? column = table.Columns[name];

                if (column == null)
                {
                    return;
                }

                string columnType = column.DataType.ToString();

                //string columnType = table.Columns[name].DataType.ToString();
                columnType = columnType.Remove(0, 7);
                if (columnType.StartsWith("", StringComparison.OrdinalIgnoreCase))
                {

                    table.DefaultView.RowFilter = string.Format("[{0}] = {1}", name, txtFilter.Text.Trim());
                    txtlabel.Text = ":int: ";
                }

                if (columnType.StartsWith("str", StringComparison.OrdinalIgnoreCase))
                {

                    txtlabel.Text = ":str: ";
                    table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "", txtFilter.Text.Trim());
                }
                txtlabel.Text = txtlabel.Text + name + columnType;
            }
            catch (Exception ex)
            {
                errProvider.SetError(txtFilter, ex.Message);


            }





        }

        private void FormDataGrid_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void FormDataGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
