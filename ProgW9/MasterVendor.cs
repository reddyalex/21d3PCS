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
    public partial class MasterVendor : Form
    {
        public MasterVendor()
        {
            InitializeComponent();

           
        }

        private void vendorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                try
                {

                    //this.Validate();
                    this.vendorsBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.payablesDataSet);
                }
                catch (DataException ex)
                {
                    MessageBox.Show(ex.Message + ex.GetType().ToString());
                    this.vendorsBindingSource.CancelEdit();
                }
                catch (ArgumentException ex)
                {
                    // This block catches exceptions such as a value that's beyond
                    // the maximum length for a column in a dataset.
                    MessageBox.Show(ex.Message, "Argument Exception");
                    this.vendorsBindingSource.CancelEdit();
                }
                catch (DBConcurrencyException)
                {
                    MessageBox.Show("A concurrency error occurred. " +
                        "The row was not updated.", "Concurrency Exception");
                    this.vendorsTableAdapter.Fill(this.payablesDataSet.Vendors);
                }
                
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Server error # " + ex.Number +
                        ": " + ex.Message, ex.GetType().ToString());
                }

            }



        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payablesDataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.payablesDataSet.Invoices);
            Binding b = phoneTextBox.DataBindings["Text"];
            b.Format += LibraryInvoice.formatPhoneNumber;
            b.Parse += LibraryInvoice.unFormatPhoneNumber;


            // TODO: This line of code loads data into the 'payablesDataSet.GLAccounts' table. You can move, or remove it, as needed.
            this.gLAccountsTableAdapter.Fill(this.payablesDataSet.GLAccounts);
            // TODO: This line of code loads data into the 'payablesDataSet.Terms' table. You can move, or remove it, as needed.
            this.termsTableAdapter.Fill(this.payablesDataSet.Terms);
            // TODO: This line of code loads data into the 'payablesDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.payablesDataSet.States);
            // TODO: This line of code loads data into the 'payablesDataSet.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter.Fill(this.payablesDataSet.Vendors);

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(phoneTextBox);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vendorsBindingSource.MoveNext();
            this.Text = "Pos=" + vendorsBindingSource.Position; 
        }

        private void fillByVendorIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {

                int vendorID = Convert.ToInt32(vendorIDToolStripTextBox.Text);
                this.vendorsTableAdapter.FillByVendorID(this.payablesDataSet.Vendors, vendorID);
                if (vendorsBindingSource.Count == 0)
                {
                    MessageBox.Show("Kode Vendor Tidak ditemukan", "Error");
                }

            }
            catch (FormatException ex)
            {
                System.Windows.Forms.MessageBox.Show("Kode vendor harus angka");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //int vendorID = Convert.ToInt32(vendorIDToolStripTextBox.Text);
                this.vendorsTableAdapter.Fill(this.payablesDataSet.Vendors);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            vendorsBindingSource.CancelEdit();

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {


            var hasil = MessageBox.Show("Yakin mau hapus data ini?\nVendorID = "+vendorIDTextBox.Text+"\nNama="+ nameTextBox.Text,"Confirmation", MessageBoxButtons.OKCancel);

            if (hasil == DialogResult.OK)
            {
                vendorsBindingSource.RemoveCurrent();
            }
            else
            {
            }


        }

        private bool IsValidData()
        {
            if (vendorsBindingSource.Count > 0)
            {
                return
                    IsPresent(nameTextBox, "Name") &&
                    IsPresent(address1TextBox, "Address1") &&
                    IsPresent(cityTextBox, "City") &&
                    IsPresent(stateComboBox, "State") &&
                    IsPresent(zipCodeTextBox, "Zip code");
            }
            else
                return true;
        }

        private bool IsPresent(Control control, string name)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (textBox.Text == "")
                {
                    MessageBox.Show(name + " is a required field.", "Entry Error");
                    textBox.Focus();
                    return false;
                }
            }
            else if (control.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                ComboBox comboBox = (ComboBox)control;
                if (comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show(name + " is a required field.", "Entry Error");
                    comboBox.Focus();
                    return false;
                }
            }
            return true;
        }

        private void vendorsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void invoicesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {

            }
        }
    }
}
