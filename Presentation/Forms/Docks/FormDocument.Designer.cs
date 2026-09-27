using FastColoredTextBoxNS;
using Presentation;
namespace Presentation.Forms.Docks
{
    partial class FormDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDocument));
            ssbtm = new StatusStrip();
            Editor = new FastColoredTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tsRun = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)Editor).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ssbtm
            // 
            ssbtm.ImageScalingSize = new Size(20, 20);
            ssbtm.Location = new Point(0, 770);
            ssbtm.Name = "ssbtm";
            ssbtm.Size = new Size(1114, 22);
            ssbtm.TabIndex = 9;
            ssbtm.Text = "statusStrip1";
            // 
            // Editor
            // 
            Editor.AutoCompleteBracketsList = new char[]
    {
    '(',
    ')',
    '{',
    '}',
    '[',
    ']',
    '"',
    '"',
    '\'',
    '\''
    };
            Editor.AutoIndentCharsPatterns = "";
            Editor.AutoScrollMinSize = new Size(45, 25);
            Editor.BackBrush = null;
            Editor.BackColor = Color.Transparent;
            Editor.BackgroundImage = Properties.Resources.logoLow;
            Editor.BackgroundImageLayout = ImageLayout.Center;
            Editor.CharHeight = 21;
            Editor.CharWidth = 10;
            Editor.CommentPrefix = "--";
            Editor.DefaultMarkerSize = 8;
            Editor.DelayedEventsInterval = 10;
            Editor.DelayedTextChangedInterval = 10;
            Editor.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            Editor.Dock = DockStyle.Fill;
            Editor.Font = new Font("Consolas", 10.8F);
            Editor.ForeColor = Color.White;
            Editor.Hotkeys = resources.GetString("Editor.Hotkeys");
            Editor.ImeMode = ImeMode.On;
            Editor.IndentBackColor = Color.Transparent;
            Editor.IsReplaceMode = false;
            Editor.Language = Language.SQL;
            Editor.LeftBracket = '(';
            Editor.LineNumberColor = Color.Fuchsia;
            Editor.Location = new Point(0, 10);
            Editor.Name = "Editor";
            Editor.Paddings = new Padding(10, 0, 4, 4);
            Editor.RightBracket = ')';
            Editor.SelectionColor = Color.FromArgb(60, 255, 215, 0);
            Editor.ServiceColors = (ServiceColors)resources.GetObject("Editor.ServiceColors");
            Editor.Size = new Size(1114, 760);
            Editor.SourceTextBox = Editor;
            Editor.TabIndex = 11;
            Editor.TextAreaBorderColor = Color.Brown;
            Editor.WordWrapMode = WordWrapMode.WordWrapPreferredWidth;
            Editor.Zoom = 100;
            Editor.Load += sqlEditor_Load;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { tsRun });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(236, 56);
            // 
            // tsRun
            // 
            tsRun.Name = "tsRun";
            tsRun.ShortcutKeys = Keys.F6;
            tsRun.Size = new Size(235, 24);
            tsRun.Text = "toolStripMenuItem1";
            tsRun.Click += tsRun_Click;
            // 
            // FormDocument
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 27, 35);
            ClientSize = new Size(1114, 792);
            Controls.Add(Editor);
            Controls.Add(ssbtm);
            HideOnClose = true;
            Name = "FormDocument";
            Padding = new Padding(0, 10, 0, 0);
            Text = "Form Document";
            Load += FormDocument_Load_1;
            ((System.ComponentModel.ISupportInitialize)Editor).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip ssbtm;
        public FastColoredTextBoxNS.FastColoredTextBox Editor;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tsRun;
    }
}