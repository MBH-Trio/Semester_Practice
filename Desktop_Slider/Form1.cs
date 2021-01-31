using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.IO;
using System.Drawing.Imaging;


namespace Desktop_Slider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SystemParametersInfo(uint uiAction, uint uiParam, String pvParam, uint fWinIni);

        private const uint SPI_SETDESKWALLPAPER = 0x14;
        private const uint SPIF_UPDATEINIFILE = 0x1;
        private const uint SPIF_SENDWININICHANGE = 0x2;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "(png,jpg,jpeg)|*.png;*.jpg;*.jpeg | All Files | *.*";
            fileDialog.Multiselect = true;
            DialogResult result =  fileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                foreach(String obj in fileDialog.FileNames)
                {
                    paths.Add(obj);
                }

                listBox1.Items.AddRange(fileDialog.FileNames);
                timer1.Enabled = true;
            }
        }
        List<String> paths = new List<string>();

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            pictureBox1.ImageLocation = (String)listBox1.SelectedItem;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //chkUpdateRegistry.Checked = update_registry;
            set_back();
        }

        private void set_back()
        {
            try
            {
                // If we should update the registry,
                // set the appropriate flags.
                uint flags = 0;

                //if (update_registry)
                //  flags = SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE;

                // Set the desktop background to this file.
                if (!SystemParametersInfo(SPI_SETDESKWALLPAPER,
                    0, (String)listBox1.SelectedItem, flags))
                {
                    MessageBox.Show("SystemParametersInfo failed.",
                        "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying picture " +
                    (String)listBox1.SelectedItem + ".\n" + ex.Message,
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(paths.Count>0)
            {
                count = count + 1 % paths.Count;
                //MessageBox.Show(paths.ElementAt(count-1));
                set_back(paths.ElementAt(count-1));

            }
            
        }

        private void set_back(String path)
        {
            try
            {
                // If we should update the registry,
                // set the appropriate flags.
                uint flags = 0;

                //if (update_registry)
                //  flags = SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE;

                // Set the desktop background to this file.
                if (!SystemParametersInfo(SPI_SETDESKWALLPAPER,
                    0, path, flags))
                {
                    MessageBox.Show("SystemParametersInfo failed.",
                        "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying picture " +
                    path + ".\n" + ex.Message,
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
