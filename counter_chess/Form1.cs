using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace counter_chess
{
    public partial class Form1 : Form
    {
        int sec_1 = 60;
        int sec_2 = 60;
        int min_1 = 10;
        int min_2 = 10;
        bool status = true;

        public Form1()
        {
            InitializeComponent();
            player_2.Text = "10: 00";
            player_1.Text = "10: 00";

            player_2.FillColor = Color.Gray;
            player_1.FillColor = Color.Aqua;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(status&&min_1>=0)
            {
                sec_1--;
                player_1.Text = +min_1-1 + " : " + sec_1;
                sec_1--;
                if (sec_1 == 0)
                {
                    min_1--;
                    sec_1 = 60;
                }
            }
            else if(!status && min_2 >= 0)
            {
                sec_2--;
                player_2.Text = min_2-1 + " : " + sec_2;
                
                if (sec_1 == 0)
                {
                    min_2--;
                    sec_2 = 60;
                }
                
            }
        }

        private void player_1_Click(object sender, EventArgs e)
        {
            if (status)
            {
                status = false;
                player_1.FillColor = Color.Gray;
                player_2.FillColor = Color.Aqua;
            }
        }
        private void player_2_Click(object sender, EventArgs e)
        {
            if (!status)
            {
                status = true;
                player_2.FillColor = Color.Gray;
                player_1.FillColor = Color.Aqua;
            }
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            player_2.Text = "10: 00";
            player_1.Text = "10: 00";
            sec_1 = 60;
            sec_2 = 60;
            min_1 = 9;
            min_2 = 9;

            player_2.FillColor = Color.Gray;
            player_1.FillColor = Color.Aqua;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
    }
}
