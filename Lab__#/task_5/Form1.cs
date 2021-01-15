using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Person[] person = new Person[5];
            person[0] = new Person { First_Name = "Dot_first", Last_Name = "Dot_last", City = "Dot city" };
            person[1] = new Person { First_Name = "Dot_first", Last_Name = "Dot_last", City = "Dot city" };
            person[2] = new Person { First_Name = "Dot_first", Last_Name = "Dot_last", City = "Dot city" };
            person[3] = new Person { First_Name = "Dot_first", Last_Name = "Dot_last", City = "Dot city" };
            person[4] = new Person { First_Name = "Dot_first", Last_Name = "Dot_last", City = "Dot city" };
            dataGridView1.DataSource = person;    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
