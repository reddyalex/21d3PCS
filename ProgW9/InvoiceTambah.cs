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

            this.gLAccountsTableAdapter.Fill(this.payablesDataSet1.GLAccounts);
            accountNoComboBox.SelectedIndex = -1;
            this.termsTableAdapter.Fill(this.payablesDataSet1.Terms);
            termsIDComboBox.SelectedIndex = -1;
            invoiceDateDateTimePicker.Value = DateTime.Today;

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
                    int defaultTermsID = Convert.ToInt32(vendorsTableAdapter.getDefaultTermsID(vendorID));
                    termsIDComboBox.SelectedValue = defaultTermsID;

                    int defaultAccountNumber = Convert.ToInt32(vendorsTableAdapter.getDefaultAccountNo(vendorID));
                    accountNoComboBox.SelectedValue = defaultAccountNumber;

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
    }
}
