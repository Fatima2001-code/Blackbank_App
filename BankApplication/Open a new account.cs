using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace BankApplication
{
    public partial class Open_a_new_account : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=FATIMA\SQLEXPRESS;Initial Catalog=BankDB;Integrated Security=True");

        public Open_a_new_account()
        {
            InitializeComponent();
        }

        private void text_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Open_a_new_account_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "InsertNewCustm";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", text_name.Text);
            cmd.Parameters.AddWithValue("@phone", text_Phone.Text);
            cmd.Parameters.AddWithValue("@address", text_Address.Text);
            cmd.Parameters.AddWithValue("@email", text_Email.Text);
            cmd.Parameters.AddWithValue("@Acc_Balance", text_Balance.Text);
            cmd.Parameters.AddWithValue("@Acc_Type", text_type.Text);
            cmd.Parameters.AddWithValue("Deposite_date", dateTimePicker1.Value);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Add Account Successfully", "New Account ..$");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Application.OpenForms[1].Show();
            this.Close();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void text_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
