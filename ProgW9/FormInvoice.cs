using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgW9
{
    public partial class FormInvoice : Form
    {
        public FormInvoice()
        {
            InitializeComponent();
        }


        private void FormInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payablesDataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.payablesDataSet.Invoices);



        }

        private void invoicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.payablesDataSet);

        }

        private void invoicesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.ColumnIndex == 8)
            {
                //MessageBox.Show(invoicesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString() );


                // Get the ID of the selected invoice
                int i = e.RowIndex;
                DataGridViewRow row = invoicesDataGridView.Rows[i];
                DataGridViewCell cell = row.Cells[0];
                int invoiceID = (int)cell.Value;

                // Display the Line Items form
                Form lineItemsForm = new FormInvoiceDetail();
                lineItemsForm.Tag = invoiceID;
                lineItemsForm.ShowDialog();
            }



        }

        private void fillByVendorIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                int vendorID = Convert.ToInt32(vendorIDToolStripTextBox.Text);
                this.vendorsTableAdapter.FillByVendorID(
                    this.payablesDataSet.Vendors, vendorID);
                if (vendorsBindingSource.Count > 0)
                    this.invoicesTableAdapter.FillByVendorID(
                        this.payablesDataSet.Invoices, vendorID);
                else
                    MessageBox.Show("No vendor found with this ID. "
                        + "Please try again.", "Vendor Not Found");
            }
            catch (FormatException)
            {
                MessageBox.Show("Vendor ID must be an integer.", "Entry Error");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void invoicesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            int row = e.RowIndex + 1;
            string errorMessage = "A data error occurred.\n" +
                "Row: " + row + "\n" +
                "Error: " + e.Exception.Message;
            MessageBox.Show(errorMessage, "Data Error");



        }
    }
}
