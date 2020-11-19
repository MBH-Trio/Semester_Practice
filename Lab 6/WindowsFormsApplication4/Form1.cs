using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = e.KeyData.ToString();
        }

        
        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            label2.Text += "a"; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
