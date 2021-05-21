using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgW9
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Masterterms f = new Masterterms();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MasterVendor f = new MasterVendor();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormInvoice f = new FormInvoice();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InvoiceMaintenance f = new InvoiceMaintenance();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InvoiceTambah f = new InvoiceTambah();
            f.Show();
        }
    }
}
