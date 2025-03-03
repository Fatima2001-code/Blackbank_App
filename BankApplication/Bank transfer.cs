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
    public partial class Bank_transfer : Form
    {
        public Bank_transfer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
            cmd.CommandText = "insetIntoTransam";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accountSender", text_Sender.Text);
            cmd.Parameters.AddWithValue("@AccountReciver", text_Receiver.Text);
            cmd.Parameters.AddWithValue("@HowMuch", text_Amount.Text);
            cmd.Parameters.AddWithValue("@dateOfTransaction", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@employeeID", text_ID.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Transfer completed successfully ..$$", "Transfer ..$");

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bank_transfer_Load(object sender, EventArgs e)
        {

        }
    }
}
// Created by Fatima Hamdan :)
