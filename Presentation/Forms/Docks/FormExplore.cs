using Business.Metadata;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
namespace Presentation.Forms.Docks;

public partial class FormExplore : frmDockWindowBase
{
    public FormExplore()
    {
        InitializeComponent();
        //Text = "Database Explorer";
        BackColor = AppTheme.Background;
        trTableInfo.BackColor = txtSearch.BackColor = AppTheme.Surface;
        trTableInfo.ForeColor = txtSearch.ForeColor = AppTheme.Text;
        DockAreas = DockAreas.DockLeft | DockAreas.DockRight;
    }
    public FormExplore LoadTables()
    {


        foreach (var info in MetadataService.Metadata.treeTableInfo
            .Where(table => table.Key.Contains(txtSearch.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
        {
            TreeNode node = new TreeNode(info.Key);
            node.Tag = info;
            node.ImageIndex = 0;

            List<TreeNode> childNodes = info.Value
                .Select(table => new TreeNode(table.Name) { Tag = table, ImageIndex = 1 })
                .ToList();

            node.Nodes.AddRange(childNodes.ToArray());
            node.Expand();

            trTableInfo.Nodes.Add(node);
        }

        if (trTableInfo.Nodes.Count > 0)
        {
            trTableInfo.SelectedNode = null;
            trTableInfo.TopNode = trTableInfo.Nodes[0];
        }
        return this;
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        //this.LoadTables();
    }

    private void trTableInfo_AfterSelect(object sender, TreeViewEventArgs e)
    {
        if (trTableInfo.SelectedNode is not TreeNode)
            return;

        if (trTableInfo.SelectedNode.Tag is TableInfo tableInfo)
        {
            EventCenterAction._selectedTableInfo = tableInfo;
            EventCenterAction.NotifyRefresh();
            txtSearch.Text = EventCenterAction._selectedTableInfo.Name;
        }

    }
    public void ConfigureControls()
    {

    }

    private void FormObjects_FormClosing(object sender, FormClosingEventArgs e)
    {
        e.Cancel = true;
        Hide();
    }
}
