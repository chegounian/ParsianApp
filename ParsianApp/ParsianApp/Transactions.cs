using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParsianApp
{
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
          MessageBox.Show("نوع تراکنش را تعیین کنید");
            
        }
    }
}
