using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Text_task
{
    public partial class Form1 : Form
    {
        bool flag = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(@"C:\Users\Umair Ahmed\Desktop\text.txt");
             
            using(StreamReader Re=fi.OpenText())
             {
                 while(!Re.EndOfStream)
                 {
                     string s = Re.ReadLine();
                     string[] s1 = s?.Split(' ');
                     if(s1[0].Equals(textBox1.Text)&&s1.Length!=0)
                     {
                         flag = false;
                         break;
                     }
                 }
             }
            if (flag == true)
            {
                if (textBox1.Text.Length >= 8 && textBox1.Text.Length >= 8)
                {
                    using (StreamWriter Wr = fi.AppendText())
                    {
                        Wr.WriteLine(textBox1.Text + " " + textBox2.Text);
                    }
                }
                else
                {
                    label3.Text = "Either UserName or Password is less than 8 characters,\n Try Again ";
                }
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
