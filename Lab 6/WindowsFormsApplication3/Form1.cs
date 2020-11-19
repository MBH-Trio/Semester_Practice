using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        String size_str = "";
        String top_str = "";
        String crust_str = "";
        String delivery_str = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Size_of_pizza();

            toppings_method();

            crust_type();

            delivery();


            Form2 form2 = new Form2();
            form2.set_data(size_str + top_str + crust_str + delivery_str);

            form2.ShowDialog();
            this.Hide();

        }

        private void delivery()
        {
            if (EastIn.Checked)
            {
                delivery_str += "EastIn \n";
            }
            else
            {
                delivery_str += "Take Out  \n";

            }
        }

        private void crust_type()
        {
            crust_str += "Crust :";
            if (ThinCrust.Checked)
            {
                crust_str += "Thin Crust  \n";
            }
            else
            {
                crust_str += "Thick Crust  \n";

            }
        }

        private void toppings_method()
        {
            top_str += "Toppings :";
            if (ExtraCheese.Checked)
            {
                top_str += "Extra Cheese \n";
            }
            else if (Mushroom.Checked)
            {
                top_str += "Mushroom \n";
            }
            else if (Onions.Checked)
            {
                top_str += "Onions \n";
            }
            else if (Tomatoes.Checked)
            {
                top_str += "Tomatoes \n";
            }
        }

        private void Size_of_pizza()
        {
            size_str += "Size  :";
            if (small.Checked)
            {
                size_str += "Small \n";
            }
            else if (medium.Checked)
            {
                size_str += "Medium \n";
            }
            else
            {
                size_str += "Large \n";
            } 
        }
    }
}
