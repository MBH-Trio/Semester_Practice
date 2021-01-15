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


namespace Lab_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sql_connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=db_dot;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("select * from Person", sql_connection);
            DataTable dataTable = new DataTable();
            sql_connection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);

            sql_connection.Close();
            dataGridView1.DataSource = dataTable;
            sqlDataReader.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            show_all_data();
        }

        private void show_all_data()
        {
            listBox1.Items.Clear();
            SqlCommand sqlCommand = new SqlCommand("select * from Person", sql_connection);
            DataTable dataTable = new DataTable();
            sql_connection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            // adding data to dataview 
            dataTable.Load(sqlDataReader);
            dataGridView1.DataSource = dataTable;
            //adding data to list
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Person person = (new Person(sqlDataReader.GetString(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetString(3), sqlDataReader.GetString(4)));
                listBox1.Items.Add(person);
            }
            sql_connection.Close();

            sqlDataReader.Close();
        }
        public void insert_data()
        {
            SqlCommand sqlCommand = new SqlCommand("Insert into person (First_Name,Last_Name,City,State,Country) Values (@first_name,@last_name,@city,@state,@country)", sql_connection);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.AddWithValue("@first_name", first_name.Text);
            sqlCommand.Parameters.AddWithValue("@last_name", last_name.Text);
            sqlCommand.Parameters.AddWithValue("@city", city.Text);
            sqlCommand.Parameters.AddWithValue("@state", state.Text);
            sqlCommand.Parameters.AddWithValue("@country", country.Text);


            sql_connection.Open();
            sqlCommand.ExecuteNonQuery();
            sql_connection.Close();
            show_all_data();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if(first_name.Text=="" ||last_name.Text == "" || country.Text == "" || state.Text == ""|| city.Text =="")
            {
                MessageBox.Show("Please enter all the data ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    insert_data();
                    MessageBox.Show("Please Data IS Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception exp)
                {
                    sql_connection.Close();
                   // MessageBox.Show("Please Data Already Exists", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person person =(Person)listBox1.SelectedItem;
            first_name.Text = person.name;
            last_name.Text = person.last_name;
            city.Text = person.city;
            country.Text = person.country;
            state.Text = person.state;


        }

        private void update_Click(object sender, EventArgs e)
        {
            if (first_name.Text == "" || last_name.Text == "" || country.Text == "" || state.Text == "" || city.Text == "")
            {
                MessageBox.Show("Please enter all the data ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            {




                SqlCommand sqlCommand = new SqlCommand("UPDATE person SET Last_Name = @last_name, City = @city, Country = @country,State = @state  WHERE First_Name = @first_name; ", sql_connection);

                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@first_name", first_name.Text);
                sqlCommand.Parameters.AddWithValue("@last_name", last_name.Text);
                sqlCommand.Parameters.AddWithValue("@city", city.Text);
                sqlCommand.Parameters.AddWithValue("@state", state.Text);
                sqlCommand.Parameters.AddWithValue("@country", country.Text);

                sql_connection.Open();
                sqlCommand.ExecuteNonQuery();
                sql_connection.Close();
                show_all_data();
                MessageBox.Show("Data is updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (first_name.Text == "" || last_name.Text == "" || country.Text == "" || state.Text == "" || city.Text == "")
            {
                MessageBox.Show("Please enter all the data ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            {




                SqlCommand sqlCommand = new SqlCommand("Delete  person WHERE First_Name = @first_name; ", sql_connection);

                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@first_name", first_name.Text);
                sqlCommand.Parameters.AddWithValue("@last_name", last_name.Text);
                sqlCommand.Parameters.AddWithValue("@city", city.Text);
                sqlCommand.Parameters.AddWithValue("@state", state.Text);
                sqlCommand.Parameters.AddWithValue("@country", country.Text);

                sql_connection.Open();
                sqlCommand.ExecuteNonQuery();
                sql_connection.Close();
                show_all_data();
                MessageBox.Show("Data is Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            first_name.Text = "";
            last_name.Text = "";
            country.Text = "";
            state.Text = "";
            city.Text = "";

        }
    }
}
