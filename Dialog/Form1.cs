using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel1.Text = colorDialog1.Color.ToString(); // default color is black the the colorDialog. 

            colorDialog1.AnyColor = false;
            //colorDialog1.CustomColors = new int[] { 1, 3, 5 };
            colorDialog1.AllowFullOpen = true; // if  false  then the only colors and the custom colors are disabled  and cancel and the ok button
            colorDialog1.ShowHelp = true; // if true then the help button is showed
            colorDialog1.FullOpen = true; // directly open full , if false then the custom colors are pressed then showed
            DialogResult dialogResult =  colorDialog1.ShowDialog(); // waits for the cancel or the ok button from the user then returns the result to the user
                                                                    //guna2HtmlLabel1.Text = dialogResult.ToString(); // dialogResult.ToString(); returns the ok and the cancel
            //guna2HtmlLabel1.Text = colorDialog1.Color.ToString(); // returns the color object then can be converted to toString . 
            guna2HtmlLabel1.ForeColor = colorDialog1.Color;
                



        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           // guna2HtmlLabel2.Text = fontDialog1.Font.ToString(); // the default font for the window is [Font: Name=Microsoft Sans Serif, Size=8.25, Units=3, GdiCharSet=0, GdiVerticalFont=False]
            fontDialog1.ShowColor = true; // by dafult false , if true then shows the color in the font dialog
            fontDialog1.ShowEffects = true; // by default the strike through etc are enabled. if fasle then those are bot visible, but the color is also the part of it , and it should be separately true
            fontDialog1.AllowScriptChange = true;
            DialogResult  dialogResult= fontDialog1.ShowDialog(); // opens the font dialog box 
            if(dialogResult == DialogResult.OK)
            {
                guna2HtmlLabel2.Font = fontDialog1.Font; // the default font for the window is [Font: Name=Microsoft Sans Serif, Size=8.25, Units=3, GdiCharSet=0, GdiVerticalFont=False]
                guna2HtmlLabel2.ForeColor = fontDialog1.Color;
                 
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel3.Text = openFileDialog1.FileName; // by default the filename is "" , openFileDialog1
            openFileDialog1.Filter = "(*.txt) | *.txt | All files (*.*) | *.*  | HTML Files  (*.html) | *.html";
            openFileDialog1.InitialDirectory = "C:";
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "this is the title"; 

            
            DialogResult dialogResult  =  openFileDialog1.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                if(openFileDialog1.Multiselect==false)
                guna2HtmlLabel3.Text = openFileDialog1.FileName;
                foreach(String name in openFileDialog1.FileNames)
                {
                    guna2HtmlLabel3.Text += name + " "; 
                }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "save as";
            saveFileDialog1.Filter = "(*.txt) | *.txt | All files (*.*) | *.*  | HTML Files  (*.html) | *.html";
            saveFileDialog1.ShowDialog();
        }
    }
}
