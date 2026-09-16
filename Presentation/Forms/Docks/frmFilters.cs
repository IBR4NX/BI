using Business.Metadata;
using DataAccess.QueryBuilder;
using Domain.Definition;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;

namespace Presentation.Forms.Docks
{
    public partial class frmFilters : DockContent
    {
        public frmFilters()
        {
            InitializeComponent();
            ConfigureControls();
            SetupStyle();
        }


        public void LoadFilter()
        {
            CbColumnsFilter.Items.Clear();
            //ClearFiltersList();
            //lstVColumns.Items.Clear();
            //List<ColumnInfo> columns = MetadataService.GetColumns(tableInfo);
            List<ColumnInfo> columns = MetadataService.GetColumns(EventCenterAction._selectedTableInfo);

            foreach (var column in columns)
            {
                CbColumnsFilter.Items.Add(column);
            }
        }

        private void ConfigureControls()
        {
            EventCenterAction.RefreshNavigator += LoadFilter;
            CmbLogical.DataSource = Enum.GetValues<LogicalOperator>();
            CmbLogical.SelectedItem = 0;
            cmbFilterOperator.DataSource = Enum.GetValues<ComparisonOperator>();
            cmbFilterOperator.SelectedItem = nameof(ComparisonOperator.Equal);

            //cmbJoinType.DataSource = Enum.GetValues<JoinType>();
        }

        public void SetupStyle()
        {
            BtnAddFilter.BackColor = AppTheme.Primary;
            BtnAddFilter.ForeColor = AppTheme.Text;
        }
    }
}
