using WeifenLuo.WinFormsUI.Docking;
namespace Presentation
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dockPanel = new DockPanel();
            vS2015DarkTheme1 = new VS2015DarkTheme();
            vS2015BlueTheme1 = new VS2015BlueTheme();
            btmStatusStrip = new StatusStrip();
            toolStripStatusLabelTables = new ToolStripStatusLabel();
            StatusLabelCountTables = new ToolStripStatusLabel();
            toolStripStatusLabelColumns = new ToolStripStatusLabel();
            StatusLabelCountColumnsSelected = new ToolStripStatusLabel();
            toolStripSplitBtnHidden = new ToolStripSplitButton();
            toolStripStatusLabelConnection = new ToolStripStatusLabel();
            StatusLabelConnection = new ToolStripStatusLabel();
            toolStripSplitButton1 = new ToolStripSplitButton();
            tsLabel = new ToolStripStatusLabel();
            tsltest1 = new ToolStripStatusLabel();
            tsltest2 = new ToolStripStatusLabel();
            tsslabel = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            openMenu = new ToolStripMenuItem();
            closeMenu1 = new ToolStripMenuItem();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            printToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            printPreviewToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            customizeToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            contentsToolStripMenuItem = new ToolStripMenuItem();
            indexToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            runQueryToolStripMenuItem = new ToolStripMenuItem();
            testToolStripMenuItem = new ToolStripMenuItem();
            showToolStripMenuItem1 = new ToolStripMenuItem();
            hideToolStripMenuItem = new ToolStripMenuItem();
            fliterToolStripMenuItem = new ToolStripMenuItem();
            newFilterToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            listColumnsToolStripMenuItem = new ToolStripMenuItem();
            listFilterToolStripMenuItem = new ToolStripMenuItem();
            listDataBoxToolStripMenuItem = new ToolStripMenuItem();
            listExploreToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showToolStripMenuItem = new ToolStripMenuItem();
            errProvider = new ErrorProvider(components);
            btmStatusStrip.SuspendLayout();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // dockPanel
            // 
            dockPanel.Dock = DockStyle.Fill;
            dockPanel.DockBackColor = Color.FromArgb(45, 45, 48);
            dockPanel.Location = new Point(0, 35);
            dockPanel.Margin = new Padding(0);
            dockPanel.Name = "dockPanel";
            dockPanel.Padding = new Padding(6);
            dockPanel.ShowAutoHideContentOnHover = false;
            dockPanel.Size = new Size(1382, 692);
            dockPanel.TabIndex = 0;
            dockPanel.TabStop = true;
            dockPanel.Theme = vS2015DarkTheme1;
            dockPanel.ActiveContentChanged += dockPanel_ActiveContentChanged;
            // 
            // btmStatusStrip
            // 
            btmStatusStrip.BackColor = Color.FromArgb(22, 27, 34);
            btmStatusStrip.ForeColor = Color.FromArgb(230, 237, 243);
            btmStatusStrip.GripStyle = ToolStripGripStyle.Visible;
            btmStatusStrip.ImageScalingSize = new Size(20, 20);
            btmStatusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelTables, StatusLabelCountTables, toolStripStatusLabelColumns, StatusLabelCountColumnsSelected, toolStripSplitBtnHidden, toolStripStatusLabelConnection, StatusLabelConnection, toolStripSplitButton1, tsLabel, tsltest1, tsltest2, tsslabel });
            btmStatusStrip.Location = new Point(0, 727);
            btmStatusStrip.Name = "btmStatusStrip";
            btmStatusStrip.RenderMode = ToolStripRenderMode.Professional;
            btmStatusStrip.Size = new Size(1382, 26);
            btmStatusStrip.TabIndex = 7;
            // 
            // toolStripStatusLabelTables
            // 
            toolStripStatusLabelTables.Name = "toolStripStatusLabelTables";
            toolStripStatusLabelTables.Size = new Size(53, 20);
            toolStripStatusLabelTables.Text = "Tables:";
            // 
            // StatusLabelCountTables
            // 
            StatusLabelCountTables.Name = "StatusLabelCountTables";
            StatusLabelCountTables.Size = new Size(17, 20);
            StatusLabelCountTables.Text = "0";
            // 
            // toolStripStatusLabelColumns
            // 
            toolStripStatusLabelColumns.Name = "toolStripStatusLabelColumns";
            toolStripStatusLabelColumns.Size = new Size(69, 20);
            toolStripStatusLabelColumns.Text = "Columns:";
            // 
            // StatusLabelCountColumnsSelected
            // 
            StatusLabelCountColumnsSelected.Name = "StatusLabelCountColumnsSelected";
            StatusLabelCountColumnsSelected.Size = new Size(17, 20);
            StatusLabelCountColumnsSelected.Text = "0";
            // 
            // toolStripSplitBtnHidden
            // 
            toolStripSplitBtnHidden.BackColor = Color.Silver;
            toolStripSplitBtnHidden.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitBtnHidden.DoubleClickEnabled = true;
            toolStripSplitBtnHidden.ImageAlign = ContentAlignment.TopCenter;
            toolStripSplitBtnHidden.ImageTransparentColor = Color.Magenta;
            toolStripSplitBtnHidden.Name = "toolStripSplitBtnHidden";
            toolStripSplitBtnHidden.Size = new Size(60, 24);
            toolStripSplitBtnHidden.Text = "Data";
            // 
            // toolStripStatusLabelConnection
            // 
            toolStripStatusLabelConnection.Name = "toolStripStatusLabelConnection";
            toolStripStatusLabelConnection.Size = new Size(87, 20);
            toolStripStatusLabelConnection.Text = "Connection:";
            // 
            // StatusLabelConnection
            // 
            StatusLabelConnection.Image = Properties.Resources.icons8_connection_status_on_32;
            StatusLabelConnection.Name = "StatusLabelConnection";
            StatusLabelConnection.Size = new Size(119, 20);
            StatusLabelConnection.Text = "Disconnected";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.Image = Properties.Resources.icons8_table_321;
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(84, 24);
            toolStripSplitButton1.Text = "Show";
            toolStripSplitButton1.ButtonClick += toolStripSplitButton1_ButtonClick;
            // 
            // tsLabel
            // 
            tsLabel.Name = "tsLabel";
            tsLabel.Size = new Size(27, 20);
            tsLabel.Text = "---";
            tsLabel.Click += tsLabel_Click;
            // 
            // tsltest1
            // 
            tsltest1.ForeColor = Color.Red;
            tsltest1.Name = "tsltest1";
            tsltest1.Size = new Size(129, 20);
            tsltest1.Text = "********************";
            tsltest1.Click += tsltest1_Click;
            tsltest1.MouseHover += tsltest1_MouseHover;
            // 
            // tsltest2
            // 
            tsltest2.BackColor = Color.Red;
            tsltest2.ForeColor = Color.FromArgb(0, 0, 192);
            tsltest2.Name = "tsltest2";
            tsltest2.Size = new Size(56, 20);
            tsltest2.Text = "tsltest2";
            // 
            // tsslabel
            // 
            tsslabel.BackColor = Color.Red;
            tsslabel.BorderStyle = Border3DStyle.SunkenInner;
            tsslabel.DoubleClickEnabled = true;
            tsslabel.ForeColor = Color.Yellow;
            tsslabel.Name = "tsslabel";
            tsslabel.Size = new Size(47, 20);
            tsslabel.Text = "status";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(22, 27, 34);
            menuStrip1.Font = new Font("Segoe UI", 10.2F);
            menuStrip1.ForeColor = Color.FromArgb(230, 237, 243);
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { openMenu, closeMenu1, fileToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem, runQueryToolStripMenuItem, testToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 4, 0, 4);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.RightToLeft = RightToLeft.No;
            menuStrip1.Size = new Size(1382, 35);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // openMenu
            // 
            openMenu.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openMenu.Image = Properties.Resources.icons8_close_pane_32;
            openMenu.Name = "openMenu";
            openMenu.Size = new Size(34, 27);
            openMenu.Text = "open";
            openMenu.Visible = false;
            // 
            // closeMenu1
            // 
            closeMenu1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            closeMenu1.Image = (Image)resources.GetObject("closeMenu1.Image");
            closeMenu1.Name = "closeMenu1";
            closeMenu1.Size = new Size(34, 27);
            closeMenu1.Text = "open";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, toolStripSeparator1, printToolStripMenuItem, saveAsToolStripMenuItem, printPreviewToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(49, 27);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(198, 28);
            newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(198, 28);
            openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(195, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(198, 28);
            saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(195, 6);
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Image = (Image)resources.GetObject("printToolStripMenuItem.Image");
            printToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printToolStripMenuItem.Size = new Size(198, 28);
            printToolStripMenuItem.Text = "&Print";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(198, 28);
            saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // printPreviewToolStripMenuItem
            // 
            printPreviewToolStripMenuItem.Image = (Image)resources.GetObject("printPreviewToolStripMenuItem.Image");
            printPreviewToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            printPreviewToolStripMenuItem.Size = new Size(198, 28);
            printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(195, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(198, 28);
            exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(53, 27);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(195, 28);
            undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(195, 28);
            redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(192, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = (Image)resources.GetObject("cutToolStripMenuItem.Image");
            cutToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(195, 28);
            cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = (Image)resources.GetObject("copyToolStripMenuItem.Image");
            copyToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(195, 28);
            copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = (Image)resources.GetObject("pasteToolStripMenuItem.Image");
            pasteToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(195, 28);
            pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(192, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(195, 28);
            selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customizeToolStripMenuItem, optionsToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(62, 27);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            customizeToolStripMenuItem.Size = new Size(174, 28);
            customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(174, 28);
            optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contentsToolStripMenuItem, indexToolStripMenuItem, searchToolStripMenuItem, toolStripSeparator5, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(59, 27);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            contentsToolStripMenuItem.Size = new Size(163, 28);
            contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            indexToolStripMenuItem.Size = new Size(163, 28);
            indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(163, 28);
            searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(160, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(163, 28);
            aboutToolStripMenuItem.Text = "&About...";
            // 
            // runQueryToolStripMenuItem
            // 
            runQueryToolStripMenuItem.Name = "runQueryToolStripMenuItem";
            runQueryToolStripMenuItem.ShortcutKeys = Keys.F5;
            runQueryToolStripMenuItem.Size = new Size(105, 27);
            runQueryToolStripMenuItem.Text = "Run Query";
            runQueryToolStripMenuItem.Click += BtnStart_Click;
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showToolStripMenuItem1, hideToolStripMenuItem, fliterToolStripMenuItem, newFilterToolStripMenuItem });
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.ShortcutKeys = Keys.F11;
            testToolStripMenuItem.Size = new Size(52, 27);
            testToolStripMenuItem.Text = "test";
            // 
            // showToolStripMenuItem1
            // 
            showToolStripMenuItem1.Name = "showToolStripMenuItem1";
            showToolStripMenuItem1.Size = new Size(164, 28);
            showToolStripMenuItem1.Text = "show";
            showToolStripMenuItem1.Click += showToolStripMenuItem1_Click;
            // 
            // hideToolStripMenuItem
            // 
            hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            hideToolStripMenuItem.Size = new Size(164, 28);
            hideToolStripMenuItem.Text = "hide";
            hideToolStripMenuItem.Click += hideToolStripMenuItem_Click;
            // 
            // fliterToolStripMenuItem
            // 
            fliterToolStripMenuItem.Name = "fliterToolStripMenuItem";
            fliterToolStripMenuItem.Size = new Size(164, 28);
            fliterToolStripMenuItem.Text = "fliter";
            fliterToolStripMenuItem.Click += fliterToolStripMenuItem_Click;
            // 
            // newFilterToolStripMenuItem
            // 
            newFilterToolStripMenuItem.Name = "newFilterToolStripMenuItem";
            newFilterToolStripMenuItem.Size = new Size(164, 28);
            newFilterToolStripMenuItem.Text = "new filter";
            newFilterToolStripMenuItem.Click += newFilterToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.BackColor = Color.FromArgb(22, 27, 34);
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listColumnsToolStripMenuItem, listFilterToolStripMenuItem, listDataBoxToolStripMenuItem, listExploreToolStripMenuItem });
            viewToolStripMenuItem.ForeColor = Color.FromArgb(230, 237, 243);
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(60, 27);
            viewToolStripMenuItem.Text = "View";
            // 
            // listColumnsToolStripMenuItem
            // 
            listColumnsToolStripMenuItem.Name = "listColumnsToolStripMenuItem";
            listColumnsToolStripMenuItem.Size = new Size(224, 28);
            listColumnsToolStripMenuItem.Text = "list columns";
            listColumnsToolStripMenuItem.Click += listColumnsToolStripMenuItem_Click;
            // 
            // listFilterToolStripMenuItem
            // 
            listFilterToolStripMenuItem.Name = "listFilterToolStripMenuItem";
            listFilterToolStripMenuItem.Size = new Size(224, 28);
            listFilterToolStripMenuItem.Text = "list filter";
            listFilterToolStripMenuItem.Click += listFilterToolStripMenuItem_Click;
            // 
            // listDataBoxToolStripMenuItem
            // 
            listDataBoxToolStripMenuItem.Name = "listDataBoxToolStripMenuItem";
            listDataBoxToolStripMenuItem.Size = new Size(224, 28);
            listDataBoxToolStripMenuItem.Text = "list data box";
            listDataBoxToolStripMenuItem.Click += listDataBoxToolStripMenuItem_Click;
            // 
            // listExploreToolStripMenuItem
            // 
            listExploreToolStripMenuItem.Name = "listExploreToolStripMenuItem";
            listExploreToolStripMenuItem.Size = new Size(224, 28);
            listExploreToolStripMenuItem.Text = "List Explore ";
            listExploreToolStripMenuItem.Click += listExploreToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(113, 28);
            // 
            // showToolStripMenuItem
            // 
            showToolStripMenuItem.Name = "showToolStripMenuItem";
            showToolStripMenuItem.Size = new Size(112, 24);
            showToolStripMenuItem.Text = "show";
            // 
            // errProvider
            // 
            errProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 753);
            Controls.Add(dockPanel);
            Controls.Add(menuStrip1);
            Controls.Add(btmStatusStrip);
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            btmStatusStrip.ResumeLayout(false);
            btmStatusStrip.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme vS2015DarkTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2015BlueTheme vS2015BlueTheme1;
        private StatusStrip btmStatusStrip;
        private ToolStripStatusLabel toolStripStatusLabelTables;
        private ToolStripStatusLabel StatusLabelCountTables;
        private ToolStripStatusLabel toolStripStatusLabelColumns;
        private ToolStripStatusLabel StatusLabelCountColumnsSelected;
        private ToolStripSplitButton toolStripSplitBtnHidden;
        private ToolStripStatusLabel toolStripStatusLabelConnection;
        private ToolStripStatusLabel StatusLabelConnection;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem openMenu;
        private ToolStripMenuItem closeMenu1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem printPreviewToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem contentsToolStripMenuItem;
        private ToolStripMenuItem indexToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem runQueryToolStripMenuItem;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripStatusLabel tsLabel;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem showToolStripMenuItem1;
        private ToolStripMenuItem showToolStripMenuItem;
        private ToolStripMenuItem hideToolStripMenuItem;
        private ToolStripMenuItem fliterToolStripMenuItem;
        private ToolStripMenuItem newFilterToolStripMenuItem;
        private ToolStripStatusLabel tsltest1;
        private ToolStripStatusLabel tsltest2;
        private ToolStripStatusLabel tsslabel;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem listColumnsToolStripMenuItem;
        private ToolStripMenuItem listFilterToolStripMenuItem;
        private ToolStripMenuItem listDataBoxToolStripMenuItem;
        private ToolStripMenuItem listExploreToolStripMenuItem;
        private ErrorProvider errProvider;
    }
}