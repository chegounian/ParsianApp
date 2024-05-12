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
    public partial class BuyForm : Form
    {
        public BuyForm()
        {
            InitializeComponent();
        }

        private void مشتریمتفرقهToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuyForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_buyFormDataSet.tbl_Buy' table. You can move, or remove it, as needed.
            this.tbl_BuyTableAdapter.Fill(this.dB_buyFormDataSet.tbl_Buy);

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void فاکتورجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
