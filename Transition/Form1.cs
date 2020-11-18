using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Transition
{
    public partial class Form1 : Form
    {
        int tries = 0;
        int index_of_pic;
        string path;
        int[] array = new int[16];
        public Form1()
        {
            InitializeComponent();
            Setup_Components();
        }
        private void Setup_Components()
        {
            index_of_pic = (new Random()).Next(1, 17);
            path = @"D:\Semester 5\2019-fall-vp-group-x\labs\5-LAB\puzzle-pictures\candy" + index_of_pic + ".jpg";
            guna2PictureBox1.Image = Image.FromFile(path);
            int set = 0;
            Random random = new Random();
            while (set <= 15)
            {
                int number = random.Next(1, 17);
                if (!array.Contains(number))
                {
                    array[set++] = number;
                }
            }
            int stored = 0;
            int[] repeated = new int[3];
            while (stored < 2)
            {
                int number_random = random.Next(16);

                if (!repeated.Contains(number_random))
                {
                    repeated[stored] = number_random;
                    array[number_random] = index_of_pic;
                    stored++;
                }
            }
            path_1 = @"D:\Semester 5\2019-fall-vp-group-x\labs\5-LAB\puzzle-pictures\candy" + array[0] + ".jpg";
            path_2 = @"D:\Semester 5\2019-fall-vp-group-x\labs\5-LAB\puzzle-pictures\candy" + array[1] + ".jpg";
            path_3 = @"D:\Semester 5\2019-fall-vp-group-x\labs\5-LAB\puzzle-pictures\candy" + array[2] + ".jpg";
            path_4 = @"D:\Semester 5\2019-fall-vp-group-x\labs\5-LAB\puzzle-pictures\candy" + array[3] + ".jpg";
            path_5 = @"D:\Semester 5\2019-fall-vp-group-x\labs\5-LAB\puzzle-pictures\candy" + array[4] + ".jpg";
            path_6 = @"D:\Semester 5\2019-fall-vp-group-x\labs\5-LAB\puzzle-pictures\candy" + array[5] + ".jpg";
            path_7 = @"D:\Semester 5\2019-fall-vp-group-x\labs\5-LAB\puzzle-pictures\candy" + array[6] + ".jpg";
            path_8 = @"D:\Semester 5\2019-fall-vp-group-x\labs\5-LAB\puzzle-pictures\candy" + array[7] + ".jpg";
            path_9 = @"D:\Semester 5\2019-fall-vp-group-x\labs\5-LAB\puzzle-pictures\candy" + array[8] + ".jpg";
            path_10 = @"D:\Semester 5\2019-fall-vp-group-x\labs\5-LAB\puzzle-pictures\candy" + array[9] + ".jpg";
            path_11 = @"D:\Semester 5\2019-fall-vp-group-x\labs\5-LAB\puzzle-pictures\candy" + array[10] + ".jpg";
            path_12 = @"D:\Semester 5\2019-fall-vp-group-x\labs\5-LAB\puzzle-pictures\candy" + array[11] + ".jpg";
            path_13 = @"D:\Semester 5\2019-fall-vp-group-x\labs\5-LAB\puzzle-pictures\candy" + array[12] + ".jpg";
            path_14 = @"D:\Semester 5\2019-fall-vp-group-x\labs\5-LAB\puzzle-pictures\candy" + array[13] + ".jpg";
            path_15 = @"D:\Semester 5\2019-fall-vp-group-x\labs\5-LAB\puzzle-pictures\candy" + array[14] + ".jpg";
            path_16 = @"D:\Semester 5\2019-fall-vp-group-x\labs\5-LAB\puzzle-pictures\candy" + array[15] + ".jpg";
        }
        string path_1;
        string path_2;
        string path_3;
        string path_4;
        string path_5;
        string path_6;
        string path_7;
        string path_8;
        string path_9;
        string path_10;
        string path_11;
        string path_12;
        string path_13;
        string path_14;
        string path_15;
        string path_16;
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e){}
        private void pic_1_Click(object sender, EventArgs e)
        {
            pic_1.Image = Image.FromFile(path_1);
            check_status(path_1);
            ((Guna2PictureBox)sender).Enabled = false;

        }
        private void pic_2_Click(object sender, EventArgs e)
        {
            pic_2.Image = Image.FromFile(path_2);
            check_status(path_2);
            ((Guna2PictureBox)sender).Enabled = false;

        }
        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            pic_3.Image = Image.FromFile(path_3);
            check_status(path_3);
            ((Guna2PictureBox)sender).Enabled = false;

        }

        private void check_status(string passed_path)
        {
            if (path.Equals(passed_path))
            {
                guna2HtmlLabel1.Text = "You Won";
                disable_all_buttons();
            }
            else if (tries < 2)
            {
                tries++;
                guna2HtmlLabel1.Text = "You are left with " + (3 - tries) + "!";
            }
            else
            {
                guna2HtmlLabel1.Text = "You Loss";
                disable_all_buttons();
                
            }
        }

        private void disable_all_buttons()
        {
            pic_1.Enabled = false;
            pic_2.Enabled = false;
            pic_3.Enabled = false;
            pic_4.Enabled = false;
            pic_5.Enabled = false;
            pic_6.Enabled = false;
            pic_7.Enabled = false;
            pic_8.Enabled = false;
            pic_9.Enabled = false;
            pic_10.Enabled = false;
            pic_11.Enabled = false;
            pic_12.Enabled = false;
            pic_13.Enabled = false;
            pic_14.Enabled = false;
            pic_15.Enabled = false;
            pic_16.Enabled = false;
        }

        private void pic_9_Click(object sender, EventArgs e)
        {
            pic_9.Image = Image.FromFile(path_9);
            check_status(path_9);
            ((Guna2PictureBox)sender).Enabled = false;

        }

        private void pic_4_Click(object sender, EventArgs e)
        {
            pic_4.Image = Image.FromFile(path_4);
            check_status(path_4);
            ((Guna2PictureBox)sender).Enabled = false;

        }

        private void pic_5_Click(object sender, EventArgs e)
        {
            pic_5.Image = Image.FromFile(path_5);
            check_status(path_5);
            ((Guna2PictureBox)sender).Enabled = false;

        }

        private void pic_6_Click(object sender, EventArgs e)
        {
            pic_6.Image = Image.FromFile(path_6);
            check_status(path_6);
            ((Guna2PictureBox)sender).Enabled = false;

        }

        private void pic_7_Click(object sender, EventArgs e)
        {
            pic_7.Image = Image.FromFile(path_7);
            check_status(path_7);
            ((Guna2PictureBox)sender).Enabled = false;

        }

        private void pic_8_Click(object sender, EventArgs e)
        {
            pic_8.Image = Image.FromFile(path_8);
            check_status(path_8);
            ((Guna2PictureBox)sender).Enabled = false;

        }

        private void pic_10_Click(object sender, EventArgs e)
        {
            pic_10.Image = Image.FromFile(path_10);
            check_status(path_10);
            ((Guna2PictureBox)sender).Enabled = false;

        }

        private void pic_11_Click(object sender, EventArgs e)
        {
            pic_11.Image = Image.FromFile(path_11);
            check_status(path_11);
            ((Guna2PictureBox)sender).Enabled = false;

        }

        private void pic_12_Click(object sender, EventArgs e)
        {
            pic_12.Image = Image.FromFile(path_12);
            check_status(path_12);
            ((Guna2PictureBox)sender).Enabled = false;

        }

        private void pic_13_Click(object sender, EventArgs e)
        {
            pic_13.Image = Image.FromFile(path_13);
            check_status(path_13);
            ((Guna2PictureBox)sender).Enabled = false;

        }

        private void pic_14_Click(object sender, EventArgs e)
        {
            pic_14.Image = Image.FromFile(path_14);
            check_status(path_14);
            ((Guna2PictureBox)sender).Enabled = false;

        }

        private void pic_15_Click(object sender, EventArgs e)
        {
            pic_15.Image = Image.FromFile(path_5);
            check_status(path_15);
            ((Guna2PictureBox)sender).Enabled = false;

        }

        private void pic_16_Click(object sender, EventArgs e)
        {
            
            pic_16.Image = Image.FromFile(path_16);
            check_status(path_16);
            ((Guna2PictureBox)sender).Enabled = false;
        }

        private void Play_Again_Click(object sender, EventArgs e)
        {
            enable_components();
            Clear_Components();
            Setup_Components();
        }

        private void enable_components()
        {
            pic_1.Enabled = true;
            pic_2.Enabled = true;
            pic_3.Enabled = true;
            pic_4.Enabled = true;
            pic_5.Enabled = true;
            pic_6.Enabled = true;
            pic_7.Enabled = true;
            pic_8.Enabled = true;
            pic_9.Enabled = true;
            pic_10.Enabled = true;
            pic_11.Enabled = true;
            pic_12.Enabled = true;
            pic_13.Enabled = true;
            pic_14.Enabled = true;
            pic_15.Enabled = true;
            pic_16.Enabled = true;
        }

        private void Clear_Components()
        {
            array = new int[16];
            tries = 0;
            pic_1.Image = null;
            pic_2.Image = null;
            pic_3.Image = null;
            pic_4.Image = null;
            pic_5.Image = null;
            pic_6.Image = null;
            pic_7.Image = null;
            pic_8.Image = null;
            pic_9.Image = null;
            pic_10.Image = null;
            pic_11.Image = null;
            pic_12.Image = null;
            pic_13.Image = null;
            pic_14.Image = null;
            pic_15.Image = null;
            pic_16.Image = null;
            guna2HtmlLabel1.Text = "Please Guess the Picture";
        }
    }
}
