using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;


namespace NotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void text_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult dialog =  openFileDialog1.ShowDialog();
            
            if(dialog == DialogResult.OK)
            {
                string dot_data = "";
                String file_name = openFileDialog1.FileName;
                StreamReader str_reader = new StreamReader(file_name);
                string line = "";
                while((line=str_reader.ReadLine())!= null)
                {
                    dot_data+=line;
                }
                richTextBox1.Text = dot_data;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "text files | *.txt ";
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                FileInfo file = new FileInfo(saveFile.FileName);
                if (!file.Exists)                    
                    file.Create();
                
                StreamWriter streamWriter = new StreamWriter(saveFile.FileName);
                streamWriter.WriteLine(richTextBox1.Text);

                streamWriter.Close();
                MessageBox.Show("the data is saved");
            }
            else
            {
                MessageBox.Show("not saved");
            }
        }

        private void choseFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //String selected_data = richTextBox1.SelectedText;
            fontDialog1.ShowColor = true;
            fontDialog1.AllowScriptChange= true;
            fontDialog1.ShowEffects= true;
            DialogResult result =   fontDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
                richTextBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void selectColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.ShowHelp = true;
            colorDialog1.AnyColor = true;
            colorDialog1.FullOpen = true;
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrinterSettings.PrinterName = richTextBox1.Text;
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            pd.Print();
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            //Create a font Arial with size 16  
            Font font = new Font("Arial", 16);

            //Create a solid brush with black color  
            SolidBrush brush = new SolidBrush(Color.Black);

            //Draw "Hello Printer!";  
            g.DrawString("Hello Printer!",
            font, brush,
            new Rectangle(20, 20, 200, 100));
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        String copy = "";
        String cut = "";
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copy=richTextBox1.SelectedText;
        }


        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll(); 
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();

        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {


            DialogResult dialog = openFileDialog1.ShowDialog();

            if (dialog == DialogResult.OK)
            {
                String file_name = openFileDialog1.FileName;
                richTextBox1.LoadFile(file_name,RichTextBoxStreamType.PlainText);
            }
        }
    }  
}
