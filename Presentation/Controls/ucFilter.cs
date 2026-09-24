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

namespace Presentation.Controls
{
    public partial class ucFilter : UserControl
    {
        public ucFilter()
        {
            InitializeComponent();
            ConfigureControls();
            SetupStyle();
            clsEventActions.ColumnsChanged += LoadFilter;
        }
        public void LoadFilter(List<ColumnInfo> columns)
        {
            lstFilters.Items.Clear();
            CbColumnsFilter.Items.Clear();

            foreach (var column in columns)
            {
                CbColumnsFilter.Items.Add(column);
                cbFilterValue.Items.Add(column.Name);
            }
            cbFilterValue.SelectedIndex = 0;
        }
        #region Start ConfigureControls and SetupStyle
        private void ConfigureControls()
        {
            CmbLogical.DataSource = Enum.GetValues<LogicalOperator>();
            CmbLogical.SelectedItem = 0;
            cmbFilterOperator.DataSource = Enum.GetValues<ComparisonOperator>();
            cmbFilterOperator.SelectedItem = nameof(ComparisonOperator.Equal);
        }

        private void SetupStyle()
        {
            BtnAddFilter.BackColor = Theme.Primary;
            BtnAddFilter.ForeColor = Theme.Text;
        }
        #endregion


        private void BtnAddFilter_Click(object sender, EventArgs e)
        {
            try
            {
                var f = BuildFilter();
                ListViewItem item = new ListViewItem(f.Column.Name);
                item.Tag = f;
                item.SubItems.Add(f.Operator.ToString());
                item.SubItems.Add(f.GetValuesString());

                lstFilters.Items.Add(item);

            }
            catch (Exception exception)
            {
                //errorProvider1.SetError(lstFilters, exception.Message);
            }


        }
        public List<FilterDefinition> GetFilters()
        {
            List<FilterDefinition> filters = lstFilters.Items
                .Cast<ListViewItem>()
                .Select(item => (FilterDefinition)item.Tag!)
                .ToList()!;
            return filters;
        }
        private FilterDefinition BuildFilter()
        {
            if (CbColumnsFilter.SelectedItem is null || cmbFilterOperator.SelectedItem is null || CmbLogical.SelectedItem is null)
            {
                throw new InvalidOperationException("Please select a column, operator, value type, and logical operator.");
            }
            var filter = new FilterDefinition
            {
                Column = MetadataService.GetColumn(CbColumnsFilter.Text),
                Operator = (ComparisonOperator)cmbFilterOperator.SelectedItem!,
                LogicalOperator = (LogicalOperator)CmbLogical.SelectedItem!
            };
            string valueText = cbFilterValue.Text.Trim();
            if (filter.Operator is ComparisonOperator.Between or ComparisonOperator.In)
            {
                filter.Values = valueText.Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)
                    .Cast<object>()
                    .ToList();
            }
            else
            {
                filter.Values.Add(filter.Operator == ComparisonOperator.Like ? $"'%'{valueText}'%'" : valueText);
            }

            return filter;
        }

        private void lstFilters_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void BtnClearFilters_Click(object sender, EventArgs e)
        {
            lstFilters.Items.Clear();
        }

        private void lstFilters_DoubleClick(object sender, EventArgs e)
        {
            lstFilters.SelectedItems.Clear();

        }

        private void ucFilter_Load(object sender, EventArgs e)
        {

        }
    }
}
