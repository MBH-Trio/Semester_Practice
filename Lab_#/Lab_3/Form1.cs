using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string text = guna2TextBox1.Text;
            switch(text)
            {
                case "Jan" :
                case "Feb" :
                case "Dec":
                    guna2HtmlLabel2.Text = "Winter";
                        break;

                case "Mar":
                case "Apr":
                    guna2HtmlLabel2.Text = "Spring";
                    break;

                case "May":
                case "Jun":
                case "Jul":
                case "Aug":
                    guna2HtmlLabel2.Text = "Summer";
                    break;
                case "Sep":
                case "Oct":
                case "Nov":
                    guna2HtmlLabel2.Text = "Autumn";
                    break;

                default:
                    guna2HtmlLabel2.Text = "Invalid Text";
                    break;

            }

        }
    }
}
