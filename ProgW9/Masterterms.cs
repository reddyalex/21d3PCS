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
    public partial class Masterterms : Form
    {
        public Masterterms()
        {
            InitializeComponent();
        }

        private void termsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //try
            //{
                this.Validate();
                this.termsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.payablesDataSet);
            //}
            //catch (DataException ex)
            //{
            //    MessageBox.Show(ex.Message, ex.GetType().ToString());
            //    this.termsBindingSource.CancelEdit();
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payablesDataSet.Terms' table. You can move, or remove it, as needed.
            this.termsTableAdapter.Fill(this.payablesDataSet.Terms);

        }

        private void termsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void termsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void termsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            int row = e.RowIndex + 1;
            string errorMessage = "A data error occured.\n" +
                "Row: " + row + "\n" +
                "Error: " + e.Exception.Message;
            MessageBox.Show(errorMessage, "Data Error!");
        }
    }
}
