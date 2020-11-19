using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        bool in_air;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (i != 0 || game_off)
                return;
            Status.Text = e.KeyData.ToString();
            if(e.KeyCode == Keys.Space)
            {
                go_up.Start();

            }
            else if (e.KeyCode == Keys.Left)
            {
                if(dragon.Left>10)
                    dragon.Left-=7;
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (dragon.Left<800 )
                    dragon.Left+=7;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(i<30)
            {
                dragon.Top -= 4;
                i++;
            }
            else
            {
                go_up.Stop();
                i = 0;
                do_down.Start();
            }

        }

        private void do_down_Tick(object sender, EventArgs e)
        {
            if (i < 30)
            {
                dragon.Top += 4;
                i++;
            }
            else
            {
                i = 0;
                do_down.Stop();
            }

        }
        int score_int = 0;
        String[] path = { @"C:\Users\PeaceSeeker\Documents\C_Sharp\WindowsFormsApplication1\Lab_Game\Resources\obstacle-2.gif", @"C:\Users\PeaceSeeker\Documents\C_Sharp\WindowsFormsApplication1\Lab_Game\Resources\obstacle-1.gif" };
        Random random  = new Random();
        private void obstacle_Tick(object sender, EventArgs e)
        {

            if(obstacle_pic.Left<5)
            {
                obstacle_pic.ImageLocation = path[random.Next(2)];
                obstacle_pic.Left = 900;
                score_int++;
                Score.Text = score_int.ToString();
            }
            else
            {
                obstacle_pic.Left-=2;
            }
            if(dragon.Bounds.IntersectsWith(obstacle_pic.Bounds))
            {
                Status.Text = "Game Over";
                obstacle.Stop();
                go_up.Stop();
                do_down.Stop();
                game_off = true;
            }
        }
        bool game_off = false;
    }
}
