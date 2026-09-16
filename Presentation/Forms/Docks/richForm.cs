using WeifenLuo.WinFormsUI.Docking;

namespace Presentation.Forms.Windows
{
    public partial class richForm : DockContent
    {
        public richForm()
        {
            InitializeComponent();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Directory.CreateDirectory(folderBrowserDialog1.SelectedPath + "\\" + textBox1.Text);
                MessageBox.Show("folder created");
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Directory.Delete(folderBrowserDialog1.SelectedPath, true);
                MessageBox.Show("folder deleted");
            }
        }


        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:\\Users\\Dell\\desktop";
            saveFileDialog1.Filter = "Text File name hahaha| *.txt";
            //saveFileDialog1.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                FileStream f = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                StreamWriter s = new StreamWriter(f);
                s.Write(richTextBox1.Text);
                s.Close();
                richTextBox1.Clear();

            }


        }
    }
}
