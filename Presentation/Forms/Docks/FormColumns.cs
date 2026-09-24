using Business.Metadata;
using Domain.Definition;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Presentation.Forms.Base;
namespace Presentation.Forms.Docks
{
    public partial class FormColumns : frmDockWindowBase
    {
        public FormColumns()
        {
            InitializeComponent();
            lstVColumns.BackColor = Theme.Surface;
            //ConfigureControls();
            // clsEventActions
            clsEventActions.ColumnsChanged += LoadColumns;
        }
        public List<FilterDefinition> GetFilters()
        {
            return ucFilter1.GetFilters();
        }

        public void LoadColumns(List<ColumnInfo> columns)
        {
            this.Text = "Yap";
            lstVColumns.Items.Clear();
            if (columns.Count == 0)
            {
                Helper.Show($"No columns found for table  33 formcolumns.");
                return;
            }
            foreach (var column in columns)
            {
                string key = column.IsPrimaryKey && column.IsForeignKey ? "PK, FK"
                    : column.IsPrimaryKey
                    ? "PK"
                    : column.IsForeignKey
                    ? "FK" : "";

                ListViewItem item = new ListViewItem(column.Name);
                item.SubItems.Add(column.DataType);
                item.SubItems.Add(column.MaxLength.ToString());
                item.SubItems.Add(column.IsNullable ? "Yes" : "No");
                item.SubItems.Add(key);
                item.Tag = column;
                lstVColumns.Items.Add(item);
            }
        }
        public List<ColumnInfo> GetColumns()
        {
            List<ColumnInfo> columns = new();
            columns = lstVColumns.CheckedItems
 .Cast<ListViewItem>()
 .Select(item => (ColumnInfo)item.Tag!)
 .ToList()!;
            return columns;
        }


        public void ConfigureControls()
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstVColumns_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    }
}
