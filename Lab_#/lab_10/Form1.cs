using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button button_paint = new Button();
            button_paint.Text = "Paint";
            Button button_notepad = new Button();
            button_notepad.Text = "notepad";
            Button button_ppt = new Button();
            button_ppt.Text = "PPT";

            button_notepad.Click += new EventHandler(open_notepad);
            
            this.Controls.Add(button_notepad);
            this.Controls.Add(button_paint);


        }

        private void open_notepad(object sender, EventArgs e)
        {
        }
    }
}
