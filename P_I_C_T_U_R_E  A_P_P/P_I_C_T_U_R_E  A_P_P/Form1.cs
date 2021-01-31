using System;
using System.Windows.Forms;
using System.IO;
namespace P_I_C_T_U_R_E__A_P_P
{
    
    public partial class Form1 : Form
    {

        DriveInfo[] Drive;
        DirectoryInfo[] Directories;
        String[] Path1;
        DirectoryInfo Dir;
        int count = 0;
        int count1 = 0;
        bool flag = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Drive = DriveInfo.GetDrives();
            foreach(DriveInfo Dri in Drive)
            {
                if(Dri.IsReady)
                {
                    guna2ComboBox1.Items.Add(Dri);
                }
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DirectoryInfo Dir = new DirectoryInfo(guna2ComboBox1.SelectedItem.ToString());
            Directories = Dir.GetDirectories();
            foreach(DirectoryInfo D in Directories)
            {
                listBox1.Items.Add(D);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            count = 0;
            String[] Path = Directory.GetFiles(guna2ComboBox1.SelectedItem.ToString()+listBox1.SelectedItem.ToString());
            String[] Ext;
            foreach (String P in Path)
            {
                Ext=Path[count].Split('.');
                if (Ext[1].Equals("PNG") || Ext[1].Equals("JPG") || Ext[1].Equals("GIF") || Ext[1].Equals("png") || Ext[1].Equals("jpg") || Ext[1].Equals("gif"))
                {
                    count1++;
                }
                count++;
            }
            
            Path1 = new String[count1];
            count = 0;
            int i = 0;
            foreach(String P in Path)
            {
                Ext = Path[count].Split('.');
                if (Ext[1].Equals("PNG") || Ext[1].Equals("JPG") || Ext[1].Equals("GIF") || Ext[1].Equals("png") || Ext[1].Equals("jpg") || Ext[1].Equals("gif"))
                {
                    Path1[i] = Path[count];
                    i++;
                }
                count++;
            }
            i = 0;
            count = 1;
            if (count1 != 0)
            {
                guna2PictureBox1.ImageLocation = Path1[i];
                label1.Text = "";
            }
            else
                label1.Text = "There is no Image in this folder";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            if(count==count1-1&&count1!=0)
            {
                
                guna2PictureBox1.ImageLocation = Path1[count];
                count = 0;
                label1.Text = "";
                count++;
            }
            else if(count<count1&&count1!=0)
            {
                guna2PictureBox1.ImageLocation = Path1[count];
                label1.Text = "";
                count++;
            }
            if(count1==0)
                label1.Text = "There is no Image in this folder";
            flag = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (count == 0&&count1!=0)
            {
                guna2PictureBox1.ImageLocation = Path1[count];
                count--;
                label1.Text = "";
                count = count1-1;
                
            }
            else if (count <= count1&&count1!=0)
            {
                guna2PictureBox1.ImageLocation = Path1[count];
                count--;
                label1.Text = "";
            }
            if (count1 == 0)
                label1.Text = "There is no Image in this folder";
            flag = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(flag==true)
            {
                guna2Button1_Click(sender, e);
            }
            else
            {
                guna2Button2_Click(sender, e);
            }
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            guna2PictureBox1.ImageLocation = Path1[0];
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            guna2PictureBox1.ImageLocation = Path1[count1-1];
        }
    }
}
