using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Presentation.Forms.Docks
{
    public partial class FormDataGrid : frmDockWindowBase
    {
        public FormDataGrid()
        {
            InitializeComponent();
        }
        public void SetDataSource(DataTable dataTable)
        {
            Text = EventCenterAction._selectedTableInfo.Name;
            DgvData.DataSource = dataTable;
        }

        private void FormDataGrid_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel=true;
        }
    }
}
