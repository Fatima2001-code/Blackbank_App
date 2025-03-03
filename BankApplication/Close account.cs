using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Created by Fatima Hamdan :)


namespace BankApplication
{
    public partial class Close_account : Form
    {
        public Close_account()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void text_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Close_account_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Application.OpenForms[1].Show();
            this.Close();
            this.Hide();

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FATIMA\SQLEXPRESS;Initial Catalog=BankDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delet";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Customer_name", text_name.Text);
            cmd.Parameters.AddWithValue("@AccId", text_ID.Text);
            conn.Open();
            MessageBox.Show("Are You Sure You Deleted This Account?", "Delete");
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Account Deleted Successfully..","Delete");
        }
    }
}
// Created by Fatima Hamdan :)
