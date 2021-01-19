using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Tasks
{
    public partial class Form1 : Form
    {
        int[] array = new int[50];
        public Form1()
        {
            InitializeComponent();

            textBox1.SelectionLength = 6;
        }


        int index= 0;
        private void button1_Click(object sender, EventArgs e)
        {

            Selected.Text = textBox1.SelectedText;
            button1.BackColor = Color.Wheat;
            
            int number = Convert.ToInt32(textBox1.Text);
            for(int i=number; i<=(number+100); i++)
            {
                if((check_prime(i)))
                {
                    array[index++] = i;
                }
            }
            no_of_prime.Text = index.ToString();

            // copy here the absolute path
            var path = @"C:\Users\PeaceSeeker\source\repos\Prime Tasks\file.txt";
            

            string text = "";
            for(int i=0; i<index; i++)
            {
                listView1.Items.Add(array[i].ToString());
                text += array[i].ToString() + " ";
            }

            File.WriteAllText(path, text);
            
            
        }
        public bool check_prime(int n)
        {
            for(int i=2; i<n; i++)
            {
                if(n%i==0)
                    return false;
            }
            return true;
        }

        private void item_selected(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Selected_Click(object sender, EventArgs e)
        {
            Selected.Text = "ok"; 
        }
    }
}
