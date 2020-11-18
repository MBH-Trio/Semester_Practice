using EasyTabs;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser_1
{
    public partial class check_browser : Form
    {
        public check_browser()
        {
            InitializeComponent();
            var app_name = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";
            //using (var key = Registry.CurrentUser.OpenSubKey(@"")) ;
            //webBrowser1.Navigate("https://www.google.com/");
            //webBrowser1.Navigate("www.google.com");

        }

        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }
        private void check_browser_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void search(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(guna2TextBox1.Text);
            }

        }
    }
}
