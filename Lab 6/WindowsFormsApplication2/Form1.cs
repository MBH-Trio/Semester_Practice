using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class form_Splash_Screen : Form
    {
        public form_Splash_Screen()
        {
            InitializeComponent();
            guna2ProgressBar1.Minimum = 1;
            guna2ProgressBar1.Maximum = 100;
            guna2ProgressBar1.Value = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2ProgressBar1.Value++;
            if (guna2ProgressBar1.Value == 100)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
                //this.Dispose();
                timer1.Stop();
                
            }
        }
    }
}
