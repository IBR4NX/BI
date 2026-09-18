namespace Presentation.Forms.Docks
{
    partial class frmDockWindowBase
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            tsmiClose = new ToolStripMenuItem();
            tsmiCloseAll = new ToolStripMenuItem();
            tsmiCloseOthers = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { tsmiClose, tsmiCloseAll, tsmiCloseOthers });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(162, 76);
            // 
            // tsmiClose
            // 
            tsmiClose.Name = "tsmiClose";
            tsmiClose.Size = new Size(161, 24);
            tsmiClose.Text = "Close";
            tsmiClose.Click += tsmiClose_Click;
            // 
            // tsmiCloseAll
            // 
            tsmiCloseAll.Name = "tsmiCloseAll";
            tsmiCloseAll.Size = new Size(161, 24);
            tsmiCloseAll.Text = "Close All";
            tsmiCloseAll.Click += tsmiCloseAll_Click;
            // 
            // tsmiCloseOthers
            // 
            tsmiCloseOthers.Name = "tsmiCloseOthers";
            tsmiCloseOthers.Size = new Size(161, 24);
            tsmiCloseOthers.Text = "Close Others";
            tsmiCloseOthers.Click += tsmiCloseOthers_Click;
            // 
            // frmDockWindowBase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(914, 529);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDockWindowBase";
            Load += frmDockWindowBase_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.ToolStripMenuItem tsmiCloseAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiCloseOthers;
    }
}