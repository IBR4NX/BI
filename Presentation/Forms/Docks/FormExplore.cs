using Business.Metadata;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        BackColor = Theme.Background;
        trTableInfo.BackColor = txtSearch.BackColor = Theme.Surface;
        trTableInfo.ForeColor = txtSearch.ForeColor = Theme.Text;
        DockAreas = DockAreas.DockLeft | DockAreas.DockRight;
    }
    public FormExplore LoadTables()
    {
        trTableInfo.Nodes.Clear();

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
    public void loaddatabases()
    {
        MetadataService.GetDatabases();

            comboBox1.DataSource = MetadataService.Metadata.Databases;
        //Debug.WriteLine("###############for:");

        comboBox1.SelectedIndex= 0;
        Debug.WriteLine("###############"+comboBox1.SelectedItem);
        if (comboBox1.Items.Count > 0)
            MetadataService.CorrectDataBase(comboBox1.SelectedItem.ToString());
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

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        MetadataService.CorrectDataBase(comboBox1.SelectedItem.ToString());


    }

    private void FormExplore_Load(object sender, EventArgs e)
    {

    }
}
