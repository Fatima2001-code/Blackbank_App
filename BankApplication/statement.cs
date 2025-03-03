using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class statement : Form
    {

        public statement()
        {
            InitializeComponent();
        }

        private void statement_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[1].Show();
            this.Close();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Daily Daily = new Daily();
            Daily.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Monthly Monthly = new Monthly();
            Monthly.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Yearly Yearly = new Yearly();
            Yearly.Show();
            this.Hide();
        }


    }
}
