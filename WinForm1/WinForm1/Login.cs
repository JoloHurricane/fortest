using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm1
{
    public partial class Login : Form
    {
        string connectString = @"Data Source = DESKTOP-BU6FNLI\SQLEXPRESS; Database = naklad; User Id = ws08;password=123";
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            string sql = $"SELECT * FROM users WHERE login_user='{login}' and password_user='{password}'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                Form1 win = new Form1();
                win.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("idi nahui");
            }
          
           
            connection.Close();
        }
    }
}
