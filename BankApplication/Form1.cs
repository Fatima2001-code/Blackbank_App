﻿// <auto-generated/>
global using global::System;
global using global::System.Collections.Generic;
global using global::System.Drawing;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
global using global::System.Windows.Forms;
global using global::System.Data.SqlClient;
global using global::System.Data;




using System.Data;

namespace BankApplication
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FATIMA\SQLEXPRESS;Initial Catalog=BankDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "LoggIn";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", text_username.Text);
            cmd.Parameters.AddWithValue("@password", text_password.Text);
            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                string Employee_jopName = rdr[1].ToString();
                string Employee_id = rdr[0].ToString();
                if (Employee_jopName == "1")
                {
                    MessageBox.Show("Welcome Admin In Bank System, There Is So Much Money Here $_$", "WELCOME");
                }
                else
                {
                    MessageBox.Show("Welcome Employee, The Bank Needs You. ( ͡° ͜ʖ ͡°)", "WELCOME");
                }

                Menuform menuform = new Menuform();
                menuform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error ,Please try again..", "WELCOME");
            }
            conn.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}