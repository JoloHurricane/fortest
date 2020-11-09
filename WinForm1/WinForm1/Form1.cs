using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm1
{
    public partial class Form1 : Form
    {
        string connectString = @"Data Source = DESKTOP-BU6FNLI\SQLEXPRESS; Database = naklad; User Id = ws08;password=123";
        public Form1()
        {
            InitializeComponent();
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            string sql = "SELECT * FROM products";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable newTable = new DataTable();
            adapter.Fill(newTable);
            dataGridView1.DataSource = newTable.DefaultView;
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login win = new Login();
            win.Show();
            this.Hide();
        }

        private void обновитьЧтотоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
           string sql = "UPDATE waybills SET number_waybill = 1231 WHERE id_waybill = 7";
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
          
            connection.Close();

        }

        private void aDDTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNaklad win1 = new AddNaklad();
            win1.Show();
        }
    }
}
