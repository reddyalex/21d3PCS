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
    public partial class FormInvoiceDetail : Form
    {
        public FormInvoiceDetail()
        {
            InitializeComponent();
        }

        private void invoiceLineItemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoiceLineItemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.payablesDataSet);

        }

        private void FormInvoiceDetail_Load(object sender, EventArgs e)
        {
            this.invoiceLineItemsTableAdapter.FillByInvoiceID(this.payablesDataSet.InvoiceLineItems, Convert.ToInt32( this.Tag));

        }

      

        private void fillByInvoiceIDToolStripButton_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
