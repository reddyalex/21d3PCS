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
    public partial class MasterVendor : Form
    {
        public MasterVendor()
        {
            InitializeComponent();

            int a = 0;
            Binding b = phoneTextBox.DataBindings["Text"];
            b.Format += LibraryInvoice.formatPhoneNumber;
            b.Parse += LibraryInvoice.unFormatPhoneNumber;
        }

        private void vendorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.vendorsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.payablesDataSet);
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message + ex.GetType().ToString());
                this.vendorsBindingSource.CancelEdit();
            }
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
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
    }
}
