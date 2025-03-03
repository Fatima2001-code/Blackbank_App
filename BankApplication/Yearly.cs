using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Created by Fatima Hamdan :)

namespace BankApplication
{
    public partial class Yearly : Form
    {
        public Yearly()
        {
            InitializeComponent();
        }

        private void Yearly_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Application.OpenForms[2].Show();
            this.Close();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FATIMA\SQLEXPRESS;Initial Catalog=BankDB;Integrated Security=True");
            DataTable dt = new DataTable();

            string query = "SELECT * FROM [TRANSACTION] WHERE (Acc_id_sender = @AccID OR Acc_id_receiver = @AccID) AND YEAR(Tra_date) = @Year";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@AccID", text_AccID.Text);
            cmd.Parameters.AddWithValue("@Year", numericUpDown1.Value);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            sda = new SqlDataAdapter("SELECT * FROM ACCOUNT WHERE Acc_id LIKE '" + text_AccID.Text + "%'", conn);
            sda.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void print_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void Back_Click_1(object sender, EventArgs e)
        {
            Application.OpenForms[2].Show();
            this.Close();
            this.Hide();
        }
    }

}
// Created by Fatima Hamdan :)
