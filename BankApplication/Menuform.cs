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
using System.Net.Security;

namespace BankApplication
{
    public partial class Menuform : Form
    {
        public Menuform()
        {
            InitializeComponent();
        }

        private void Menuform_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            statement statement = new statement();
            statement.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Open_a_new_account Open_a_new_account = new Open_a_new_account();
            Open_a_new_account.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bank_transfer Bank_transfer = new Bank_transfer();
            Bank_transfer.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close_account Close_account = new Close_account();
            Close_account.Show();
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
            {
                return;
            }
            else
            {
                Application.Exit();
            }


        }
    }
}
