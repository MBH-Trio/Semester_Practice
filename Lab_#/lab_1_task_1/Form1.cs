using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;



namespace lab_1_task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getUserData();

        }
        public void getUserData()
        {
            lblinfo.Text = "";
            int id;
            string username;
            string password;
            string connectionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select * from username";
            connection.Open();
            SqlDataReader datareader = command.ExecuteReader();

            while (datareader.Read())
            {
                id = (int)datareader[0];
                username = (string)datareader["username"];
                password = (string)datareader["password"];

                this.lblinfo.Text += id + "\n";
                this.lblinfo.Text += username + "\n";
                this.lblinfo.Text += password + "\n\n";
            }

            datareader.Close();
            connection.Close();


        }
    }
}
