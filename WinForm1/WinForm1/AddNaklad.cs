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
    public partial class AddNaklad : Form
    {
        string connectString = @"Data Source = DESKTOP-BU6FNLI\SQLEXPRESS; Database = naklad; User Id = ws08;password=123";
        public AddNaklad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);
            string date = dateTimePicker1.Value.ToShortDateString();
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            string sql = $"INSERT INTO waybills (number_waybill, date_waybill) VALUES ({number},'{date}')";
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
