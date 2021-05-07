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
    public partial class InvoiceMaintenance : Form
    {
        public InvoiceMaintenance()
        {
            InitializeComponent();
        }



        private void InvoiceMaintenance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payablesDataSet.InvoiceLineItems' table. You can move, or remove it, as needed.
            this.invoiceLineItemsTableAdapter.Fill(this.payablesDataSet.InvoiceLineItems);
            // TODO: This line of code loads data into the 'payablesDataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.payablesDataSet.Invoices);
            this.vendorsTableAdapter.Fill(this.payablesDataSet.Vendors);

        }

        private void vendorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void vendorsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.vendorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.payablesDataSet);

        }
    }
}
