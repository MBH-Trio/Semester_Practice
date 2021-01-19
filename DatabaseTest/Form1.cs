using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace DatabaseTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //Database_connection();
            insert_data(guna2TextBox4.Text,guna2TextBox3.Text);
        }
        void insert_data(String name,String data)
        {

        }
        SQLiteConnection sqLiteConnection;
        void Database_connection()
        {
            sqLiteConnection = new SQLiteConnection("Data Source=database.sqlite3");
            if(!File.Exists("./database.sqlite3"))
            {
                SQLiteConnection.CreateFile("database.sqlite3");
                DialogResult dialog =  MessageBox.Show("Welcome to C# Corner", "Learn C#", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
            

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
