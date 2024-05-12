using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ParsianApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void چاپفاکتورهاToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void فاکتورهایبدهکاربسنتکارToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void خریدوفروشToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Address newForm = new Address();
            newForm.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.parsiansoftgroup.com/#price");

        }

        private void کارکردحسابهاToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("لطفا قفل سخت افزاری خود را متصل نمایید", "Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void صدورفاکتورخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuyForm NewForm = new BuyForm();
            NewForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaleForm NewForm = new SaleForm();
            NewForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Transactions NewForm = new Transactions();
            NewForm.Show();
        }
    }
}
