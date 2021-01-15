using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
        private void showForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2.MdiParent = this;
            form2.Show();
        }

        private void hideForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2.Hide();
        }

        private void showForm3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            form3.MdiParent = this;
            form3.Show();
        }

        private void hideForm3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form3.Hide();
        }
    }
}
