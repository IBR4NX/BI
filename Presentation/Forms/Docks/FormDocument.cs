using Business.Metadata;
using FastColoredTextBoxNS;
using Presentation.Forms.Base;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Presentation.Forms.Docks
{

    public partial class FormDocument : frmDockWindowBase
    {
        public AutocompleteMenu popupMenu;
        //FormText frmText = new FormText();
        public FormDocument()
        {
            InitializeComponent();
            //SetupAutocomplete();
            //DockAreas = DockAreas.Document| DockAreas.Float;
            this.Tag = "";
            ShowFormDock();
            SetupStyle();


        }
        private void SetupSqlEditor()
        {
            Editor.Language = Language.SQL;
            Editor.Font = new Font("Consolas", 11f);
            Editor.ShowLineNumbers = true;
        }

        public void SetupAutocomplete()
        {
            popupMenu = new AutocompleteMenu(Editor);

            popupMenu.AllowTabKey = false;
            popupMenu.AlwaysShowTooltip = false;
            popupMenu.AppearInterval = 500;
            popupMenu.AutoClose = false;
            popupMenu.AutoSize = false;
            popupMenu.BackColor = Theme.Background;
            popupMenu.ImageScalingSize = new Size(20, 20);
            popupMenu.LayoutStyle = ToolStripLayoutStyle.Flow;
            popupMenu.MaxTooltipSize = new Size(0, 0);
            popupMenu.MinFragmentLength = 2;
            popupMenu.Name = "popupMenu";
            popupMenu.Padding = new Padding(0);
            popupMenu.SearchPattern = "[\\w\\.]";
            popupMenu.Size = new Size(154, 154);
            popupMenu.ForeColor = Theme.Text;
            popupMenu.SelectedColor = Theme.Selection;
            // 2. ضبط حجم نافذة المقترحات
            popupMenu.Items.MaximumSize = new Size(200, 300);
            popupMenu.Items.Width = 200;

            // 3. قائمة الكلمات المفتاحية لـ SQL
            //string[] sqlKeywords = new string[]
            //{
            //    "SELECT", "FROM", "WHERE", "INSERT INTO", "UPDATE", "DELETE",
            //    "JOIN", "LEFT JOIN", "RIGHT JOIN", "INNER JOIN", "GROUP BY",
            //    "ORDER BY", "HAVING", "CREATE TABLE", "DROP TABLE",
            //    "ALTER TABLE", "VALUES", "SET", "AND", "OR", "NOT", "IN", "LIKE"
            //};
            //foreach (var item in sqlKeywords)

            //    items.Add(new AutocompleteItem(item));

            // 4. أضف أسماء الجداول أو الأعمدة الخاصة ببرنامجك هنا


            // 5. دمج الكلمات وتحويلها إلى عناصر قابلة للاقتراح (AutocompleteItem)
            List<AutocompleteItem> items = new List<AutocompleteItem>();


            foreach (var a in MetadataService.Metadata.treeTableInfo)
            {
                var k = new AutocompleteItem(a.Key);
                items.Add(k);
                Debug.WriteLine(k.MenuText + k.GetHashCode() + "");
                foreach (var t in a.Value)
                {
                    var v = new AutocompleteItem(text: a.Key + "." + t.Name);
                    v.MenuText= t.Name.ToString();
                    items.Add(v);
                }
            }

            foreach (var item in MetadataService.Metadata.Columns)
                items.Add(new AutocompleteItem( item.Name));

            items.AddRange(new AutocompleteItem("SELECT"),
                new AutocompleteItem("FROM"),
                new AutocompleteItem("WHERE"),
                new AutocompleteItem("INSERT"),
                new AutocompleteItem("INTO"),
                new AutocompleteItem("VALUES"),
                new AutocompleteItem("UPDATE"),
                new AutocompleteItem("SET"),
                new AutocompleteItem("DELETE"),
                new AutocompleteItem("JOIN"),
                new AutocompleteItem("INNER JOIN"),
                new AutocompleteItem("LEFT JOIN"),
                new AutocompleteItem("RIGHT JOIN"),
                new AutocompleteItem("ORDER BY"),
                new AutocompleteItem("GROUP BY"),
                new AutocompleteItem("HAVING"),
                new AutocompleteItem("DISTINCT"),
                new AutocompleteItem("AS"),
                new AutocompleteItem("AND"),
                new AutocompleteItem("OR"),
                new AutocompleteItem("LIMIT"),
                new AutocompleteItem("LIKE"),
                new AutocompleteItem("IN"),
                new AutocompleteItem("NOT"),
                new AutocompleteItem("NULL"),
                new AutocompleteItem("CREATE TABLE"),
                new AutocompleteItem("DROP TABLE"),
                new AutocompleteItem("ALTER TABLE"));
            // 6. تعيين القائمة لمحرر الكود
            popupMenu.Items.SetAutocompleteItems(MetadataService.Metadata.Tables.Select(t => t.Name).ToArray());
            popupMenu.Items.SetAutocompleteItems(items);
            //popupMenu.Items.SetAutocompleteItems();
        }

        private void ShowFormDock()
        {
            //frmText = new FormText();
            //frmText.Dock = DockStyle.Fill;
            //frmText.Show(dockPanel);
        }


        public void SetupStyle()
        {
            BackColor = Theme.Background;

            //tpToolStrip.BackColor = Theme.Background;
            //tpToolStrip.ForeColor = Theme.Text;
            ssbtm.BackColor = Theme.Background;
            ssbtm.ForeColor = Theme.Text;

            //Editor.BackColor = Theme.Surface;
            //Editor.ForeColor = Theme.Text;

        }

        private void tpToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "Downloads";
            saveFileDialog.Filter = "Text File name hahaha| *.txt";
            saveFileDialog.FileName = "QouryBI.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream f = new FileStream(saveFileDialog.FileName, FileMode.Create);
                StreamWriter s = new StreamWriter(f);
                s.Write(Editor.Text);
                s.Close();
            }
        }

        private void sqlEditor_Load(object sender, EventArgs e)
        {

        }

        private void FormDocument_Load(object sender, EventArgs e)
        {

        }

        private void FormDocument_Load_1(object sender, EventArgs e)
        {

        }

        private void tsRun_Click(object sender, EventArgs e)
        {
            //MainForm.
        }
    }
}
