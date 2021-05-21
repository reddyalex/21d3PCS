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
    public partial class InvoiceTambah : Form
    {
        public InvoiceTambah()
        {
            InitializeComponent();
        }

        private void vendorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.payablesDataSet);

        }

        private void DisableControls()
        {
            invoiceNumberTextBox.Enabled = false;
            invoiceDateDateTimePicker.Enabled = false;
            termsIDComboBox.Enabled = false;
            accountNoComboBox.Enabled = false;
            descriptionTextBox.Enabled = false;
            amountTextBox.Enabled = false;
            button1.Enabled = false;

        }

        private void enableControls()
        {
            invoiceNumberTextBox.Enabled = true;
            invoiceDateDateTimePicker.Enabled = true;
            termsIDComboBox.Enabled = true;
            accountNoComboBox.Enabled = true;
            descriptionTextBox.Enabled = true;
            amountTextBox.Enabled = true;
            button1.Enabled = true;

        }

        private void InvoiceTambah_Load(object sender, EventArgs e)
        {

            this.gLAccountsTableAdapter.Fill(this.payablesDataSet.GLAccounts);
            accountNoComboBox.SelectedIndex = -1;
            this.termsTableAdapter.Fill(this.payablesDataSet.Terms);
            termsIDComboBox.SelectedIndex = -1;
            

            DisableControls();




        }

        private void fillByVendorIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                int vendorID = Convert.ToInt32(vendorIDToolStripTextBox.Text);
                this.vendorsTableAdapter.FillByVendorID(this.payablesDataSet.Vendors, vendorID);
                if (vendorsBindingSource.Count == 0)
                {
                    MessageBox.Show("No vendor found with this ID. "
                        + "Please try again.", "Vendor Not Found");
                    
                }
                else
                {

                    enableControls();
                    //disini nambah invoice
                    

                    invoicesBindingSource.CancelEdit();

                    //invoiceLineItemsBindingSource.Clear();
                    while (invoiceLineItemsDataGridView.Rows.Count>0)
                    {
                        invoiceLineItemsDataGridView.Rows.RemoveAt(0);
                    }

                    invoicesBindingSource.AddNew();

                    invoiceSequence = 0;

                    int defaultTermsID = Convert.ToInt32(vendorsTableAdapter.getDefaultTermsID(vendorID));
                    termsIDComboBox.SelectedValue = defaultTermsID;

                    int defaultAccountNumber = Convert.ToInt32(vendorsTableAdapter.getDefaultAccountNo(vendorID));
                    accountNoComboBox.SelectedValue = defaultAccountNumber;
                    invoiceDateDateTimePicker.Value = DateTime.Today;
                    vendorIDTextBox.Text = vendorIDToolStripTextBox.Text;
                    invoiceTotalTextBox.Text = "0";

                }

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

        void hitungDueDays()
        {
            if (termsIDComboBox.SelectedIndex >= 0)
            {
                //SqlConnection conn = gLAccountsTableAdapter.Connection;
                //conn.Open();
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = conn;
                //cmd.CommandText = "select duedays from terms where termsid=@termsid";
                //cmd.Parameters.AddWithValue("termsid", termsIDComboBox.SelectedValue);

                //int hari = Convert.ToInt32(cmd.ExecuteScalar());
                int termid = Convert.ToInt32(termsIDComboBox.SelectedValue);
                int hari = Convert.ToInt32(termsTableAdapter.getDudeDays(termid));
                dueDateTextBox.Text = invoiceDateDateTimePicker.Value.AddDays(hari).ToShortDateString();


                //conn.Close();
            }
        }

        private void termsIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            hitungDueDays();
        }

        private void invoiceDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            hitungDueDays();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                
                
                invoicesBindingSource.EndEdit();
                invoicesTableAdapter.Update(payablesDataSet.Invoices);

                int InvoiceID = Convert.ToInt32(invoicesTableAdapter.getLastID());
                foreach (DataGridViewRow row in invoiceLineItemsDataGridView.Rows)
                {
                    row.Cells[0].Value = InvoiceID;
                }

                invoiceLineItemsTableAdapter.Update(payablesDataSet.InvoiceLineItems);

                payablesDataSet.Vendors.Clear();
                payablesDataSet.Invoices.Clear();
                payablesDataSet.InvoiceLineItems.Clear();
                invoiceSequence = 0;
                DisableControls();

                //this.Validate();
                //this.vendorsBindingSource.EndEdit();
                //this.tableAdapterManager.UpdateAll(this.payablesDataSet);
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message + ex.GetType().ToString());
                this.invoicesBindingSource.CancelEdit();
            }
            catch (ArgumentException ex)
            {
                // This block catches exceptions such as a value that's beyond
                // the maximum length for a column in a dataset.
                MessageBox.Show(ex.Message, "Argument Exception");
                this.invoicesBindingSource.CancelEdit();
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("A concurrency error occurred. " +
                    "The row was not updated.", "Concurrency Exception");
                //this.vendorsTableAdapter.Fill(this.payablesDataSet.Vendors);
            }

            catch (SqlException ex)
            {
                MessageBox.Show("SQL Server error # " + ex.Number +
                    ": " + ex.Message, ex.GetType().ToString());
            }
        }

        short invoiceSequence = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            invoiceLineItemsBindingSource.AddNew();

            //var baru =  payablesDataSet.InvoiceLineItems.NewInvoiceLineItemsRow();

            //baru.Description = descriptionTextBox.Text;
            //baru.AccountNo = Convert.ToInt32( accountNoComboBox.SelectedValue);
            //baru.InvoiceSequence = invoiceSequence;
            //baru.InvoiceID = 1;
            //baru.Amount = Convert.ToDecimal( amountTextBox.Text );


            int rowIndex = invoiceLineItemsDataGridView.Rows.Count - 1;

            DataGridViewRow row = invoiceLineItemsDataGridView.Rows[rowIndex];
            row.Cells[0].Value = 1;//kita belum tahun;
            invoiceSequence += 1;
            row.Cells[1].Value = invoiceSequence;
            row.Cells[2].Value = accountNoComboBox.SelectedValue;
            row.Cells[3].Value = amountTextBox.Text;
            row.Cells[4].Value = descriptionTextBox.Text;
            //payablesDataSet.InvoiceLineItems.Rows.Add(baru);

            //invoiceLineItemsBindingSource.Add(baru);
            invoiceLineItemsBindingSource.EndEdit();

            invoiceTotalTextBox.Text = Convert.ToDecimal(invoiceTotalTextBox.Text) + Convert.ToDecimal(amountTextBox.Text) +"";

            descriptionTextBox.Text = "";
            amountTextBox.Text = "";
            descriptionTextBox.Focus();


        }
    }
}
