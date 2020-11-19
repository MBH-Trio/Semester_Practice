using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Task_1 : Form
    {
        public Task_1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

           // for (int i = 1; i <= 100; i++)
           // {
                guna2ProgressBar1.Value++;
                if (guna2ProgressBar1.Value == 100)
                    timer1.Stop();
           // }

        }

        private void Task_1_Load(object sender, EventArgs e)
        {
            guna2ProgressBar1.Minimum = 1;
            guna2ProgressBar1.Maximum = 100;
            guna2ProgressBar1.Value = 1;
            timer1.Stop();
        }
    }
}
