using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            dataTable.TableName = "UserName";

            DataColumn id_column = new DataColumn();
            id_column.ColumnName = "ID";
            id_column.DataType = Type.GetType("System.Int32");

            DataColumn user_name_col = new DataColumn();
            user_name_col.ColumnName = "UserName";
            user_name_col.DataType = Type.GetType("System.String");

            DataColumn passowrd_col = new DataColumn();
            passowrd_col.ColumnName = "Password";
            passowrd_col.DataType = Type.GetType("System.String");


            dataTable.Columns.Add(id_column);//,user_name_col,passowrd_col);
            dataTable.Columns.Add(user_name_col);//,user_name_col,passowrd_col);
            dataTable.Columns.Add(passowrd_col);//,user_name_col,);

            DataRow data = dataTable.NewRow();
            data[0] = 1;
            data[1] = "user";
            data[2] = "password";

            dataTable.Rows.Add(data);
            dataSet.Tables.Add(dataTable);

            dataGridView1.DataSource = dataTable;
            dataGridView1.DataSource = dataSet.Tables["UserName"];




        }
    }
}
