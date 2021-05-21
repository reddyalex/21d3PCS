
namespace ProgW9
{
    partial class InvoiceTambah
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label vendorIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label zipCodeLabel;
            System.Windows.Forms.Label invoiceNumberLabel;
            System.Windows.Forms.Label invoiceDateLabel;
            System.Windows.Forms.Label termsIDLabel;
            System.Windows.Forms.Label dueDateLabel;
            System.Windows.Forms.Label accountNoLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label invoiceTotalLabel;
            this.payablesDataSet = new ProgW9.PayablesDataSet();
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorsTableAdapter = new ProgW9.PayablesDataSetTableAdapters.VendorsTableAdapter();
            this.tableAdapterManager = new ProgW9.PayablesDataSetTableAdapters.TableAdapterManager();
            this.vendorIDTextBox = new System.Windows.Forms.TextBox();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.fillByVendorIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.vendorIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.vendorIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByVendorIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.invoicesTableAdapter = new ProgW9.PayablesDataSetTableAdapters.InvoicesTableAdapter();
            this.invoiceNumberTextBox = new System.Windows.Forms.TextBox();
            this.invoiceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.termsIDComboBox = new System.Windows.Forms.ComboBox();
            this.termsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dueDateTextBox = new System.Windows.Forms.TextBox();
            this.invoiceLineItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceLineItemsTableAdapter = new ProgW9.PayablesDataSetTableAdapters.InvoiceLineItemsTableAdapter();
            this.accountNoComboBox = new System.Windows.Forms.ComboBox();
            this.gLAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.invoiceLineItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.termsTableAdapter = new ProgW9.PayablesDataSetTableAdapters.TermsTableAdapter();
            this.gLAccountsTableAdapter = new ProgW9.PayablesDataSetTableAdapters.GLAccountsTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.invoiceTotalTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            vendorIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            zipCodeLabel = new System.Windows.Forms.Label();
            invoiceNumberLabel = new System.Windows.Forms.Label();
            invoiceDateLabel = new System.Windows.Forms.Label();
            termsIDLabel = new System.Windows.Forms.Label();
            dueDateLabel = new System.Windows.Forms.Label();
            accountNoLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            invoiceTotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.payablesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            this.fillByVendorIDToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.termsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gLAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vendorIDLabel
            // 
            vendorIDLabel.AutoSize = true;
            vendorIDLabel.Location = new System.Drawing.Point(60, 49);
            vendorIDLabel.Name = "vendorIDLabel";
            vendorIDLabel.Size = new System.Drawing.Size(58, 13);
            vendorIDLabel.TabIndex = 1;
            vendorIDLabel.Text = "Vendor ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(80, 75);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(64, 100);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(54, 13);
            address1Label.TabIndex = 5;
            address1Label.Text = "Address1:";
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new System.Drawing.Point(11, 152);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new System.Drawing.Size(107, 13);
            zipCodeLabel.TabIndex = 13;
            zipCodeLabel.Text = "City, State, Zip Code:";
            // 
            // invoiceNumberLabel
            // 
            invoiceNumberLabel.AutoSize = true;
            invoiceNumberLabel.Location = new System.Drawing.Point(511, 49);
            invoiceNumberLabel.Name = "invoiceNumberLabel";
            invoiceNumberLabel.Size = new System.Drawing.Size(85, 13);
            invoiceNumberLabel.TabIndex = 15;
            invoiceNumberLabel.Text = "Invoice Number:";
            // 
            // invoiceDateLabel
            // 
            invoiceDateLabel.AutoSize = true;
            invoiceDateLabel.Location = new System.Drawing.Point(525, 79);
            invoiceDateLabel.Name = "invoiceDateLabel";
            invoiceDateLabel.Size = new System.Drawing.Size(71, 13);
            invoiceDateLabel.TabIndex = 16;
            invoiceDateLabel.Text = "Invoice Date:";
            // 
            // termsIDLabel
            // 
            termsIDLabel.AutoSize = true;
            termsIDLabel.Location = new System.Drawing.Point(543, 104);
            termsIDLabel.Name = "termsIDLabel";
            termsIDLabel.Size = new System.Drawing.Size(53, 13);
            termsIDLabel.TabIndex = 17;
            termsIDLabel.Text = "Terms ID:";
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Location = new System.Drawing.Point(540, 130);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new System.Drawing.Size(56, 13);
            dueDateLabel.TabIndex = 18;
            dueDateLabel.Text = "Due Date:";
            // 
            // accountNoLabel
            // 
            accountNoLabel.AutoSize = true;
            accountNoLabel.Location = new System.Drawing.Point(51, 221);
            accountNoLabel.Name = "accountNoLabel";
            accountNoLabel.Size = new System.Drawing.Size(67, 13);
            accountNoLabel.TabIndex = 20;
            accountNoLabel.Text = "Account No:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(287, 221);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 22;
            descriptionLabel.Text = "Description:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(494, 221);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(46, 13);
            amountLabel.TabIndex = 24;
            amountLabel.Text = "Amount:";
            // 
            // invoiceTotalLabel
            // 
            invoiceTotalLabel.AutoSize = true;
            invoiceTotalLabel.Location = new System.Drawing.Point(494, 536);
            invoiceTotalLabel.Name = "invoiceTotalLabel";
            invoiceTotalLabel.Size = new System.Drawing.Size(72, 13);
            invoiceTotalLabel.TabIndex = 29;
            invoiceTotalLabel.Text = "Invoice Total:";
            // 
            // payablesDataSet
            // 
            this.payablesDataSet.DataSetName = "PayablesDataSet";
            this.payablesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorsBindingSource
            // 
            this.vendorsBindingSource.DataMember = "Vendors";
            this.vendorsBindingSource.DataSource = this.payablesDataSet;
            // 
            // vendorsTableAdapter
            // 
            this.vendorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GLAccountsTableAdapter = null;
            this.tableAdapterManager.InvoiceLineItemsTableAdapter = null;
            this.tableAdapterManager.InvoicesTableAdapter = null;
            this.tableAdapterManager.StatesTableAdapter = null;
            this.tableAdapterManager.TermsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProgW9.PayablesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorsTableAdapter = this.vendorsTableAdapter;
            // 
            // vendorIDTextBox
            // 
            this.vendorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "VendorID", true));
            this.vendorIDTextBox.Enabled = false;
            this.vendorIDTextBox.Location = new System.Drawing.Point(124, 46);
            this.vendorIDTextBox.Name = "vendorIDTextBox";
            this.vendorIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.vendorIDTextBox.TabIndex = 2;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this.payablesDataSet;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "Name", true));
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(124, 72);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(279, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // address1TextBox
            // 
            this.address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "Address1", true));
            this.address1TextBox.Enabled = false;
            this.address1TextBox.Location = new System.Drawing.Point(124, 97);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(279, 20);
            this.address1TextBox.TabIndex = 6;
            // 
            // address2TextBox
            // 
            this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "Address2", true));
            this.address2TextBox.Enabled = false;
            this.address2TextBox.Location = new System.Drawing.Point(124, 123);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(279, 20);
            this.address2TextBox.TabIndex = 8;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "City", true));
            this.cityTextBox.Enabled = false;
            this.cityTextBox.Location = new System.Drawing.Point(124, 149);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 10;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "State", true));
            this.stateTextBox.Enabled = false;
            this.stateTextBox.Location = new System.Drawing.Point(230, 149);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(58, 20);
            this.stateTextBox.TabIndex = 12;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "ZipCode", true));
            this.zipCodeTextBox.Enabled = false;
            this.zipCodeTextBox.Location = new System.Drawing.Point(303, 149);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.zipCodeTextBox.TabIndex = 14;
            // 
            // fillByVendorIDToolStrip
            // 
            this.fillByVendorIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendorIDToolStripLabel,
            this.vendorIDToolStripTextBox,
            this.fillByVendorIDToolStripButton});
            this.fillByVendorIDToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByVendorIDToolStrip.Name = "fillByVendorIDToolStrip";
            this.fillByVendorIDToolStrip.Size = new System.Drawing.Size(883, 25);
            this.fillByVendorIDToolStrip.TabIndex = 15;
            this.fillByVendorIDToolStrip.Text = "fillByVendorIDToolStrip";
            // 
            // vendorIDToolStripLabel
            // 
            this.vendorIDToolStripLabel.Name = "vendorIDToolStripLabel";
            this.vendorIDToolStripLabel.Size = new System.Drawing.Size(58, 22);
            this.vendorIDToolStripLabel.Text = "vendorID:";
            // 
            // vendorIDToolStripTextBox
            // 
            this.vendorIDToolStripTextBox.Name = "vendorIDToolStripTextBox";
            this.vendorIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByVendorIDToolStripButton
            // 
            this.fillByVendorIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByVendorIDToolStripButton.Name = "fillByVendorIDToolStripButton";
            this.fillByVendorIDToolStripButton.Size = new System.Drawing.Size(34, 22);
            this.fillByVendorIDToolStripButton.Text = "Find";
            this.fillByVendorIDToolStripButton.Click += new System.EventHandler(this.fillByVendorIDToolStripButton_Click);
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceNumberTextBox
            // 
            this.invoiceNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "InvoiceNumber", true));
            this.invoiceNumberTextBox.Location = new System.Drawing.Point(602, 46);
            this.invoiceNumberTextBox.Name = "invoiceNumberTextBox";
            this.invoiceNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.invoiceNumberTextBox.TabIndex = 16;
            // 
            // invoiceDateDateTimePicker
            // 
            this.invoiceDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoicesBindingSource, "InvoiceDate", true));
            this.invoiceDateDateTimePicker.Location = new System.Drawing.Point(602, 75);
            this.invoiceDateDateTimePicker.Name = "invoiceDateDateTimePicker";
            this.invoiceDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.invoiceDateDateTimePicker.TabIndex = 17;
            this.invoiceDateDateTimePicker.ValueChanged += new System.EventHandler(this.invoiceDateDateTimePicker_ValueChanged);
            // 
            // termsIDComboBox
            // 
            this.termsIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoicesBindingSource, "TermsID", true));
            this.termsIDComboBox.DataSource = this.termsBindingSource;
            this.termsIDComboBox.DisplayMember = "Description";
            this.termsIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.termsIDComboBox.FormattingEnabled = true;
            this.termsIDComboBox.Location = new System.Drawing.Point(602, 101);
            this.termsIDComboBox.Name = "termsIDComboBox";
            this.termsIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.termsIDComboBox.TabIndex = 18;
            this.termsIDComboBox.ValueMember = "TermsID";
            this.termsIDComboBox.SelectedIndexChanged += new System.EventHandler(this.termsIDComboBox_SelectedIndexChanged);
            // 
            // termsBindingSource
            // 
            this.termsBindingSource.DataMember = "Terms";
            this.termsBindingSource.DataSource = this.payablesDataSet;
            // 
            // dueDateTextBox
            // 
            this.dueDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "DueDate", true));
            this.dueDateTextBox.Enabled = false;
            this.dueDateTextBox.Location = new System.Drawing.Point(602, 127);
            this.dueDateTextBox.Name = "dueDateTextBox";
            this.dueDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.dueDateTextBox.TabIndex = 19;
            // 
            // invoiceLineItemsBindingSource
            // 
            this.invoiceLineItemsBindingSource.DataMember = "InvoiceLineItems";
            this.invoiceLineItemsBindingSource.DataSource = this.payablesDataSet;
            // 
            // invoiceLineItemsTableAdapter
            // 
            this.invoiceLineItemsTableAdapter.ClearBeforeFill = true;
            // 
            // accountNoComboBox
            // 
            this.accountNoComboBox.DataSource = this.gLAccountsBindingSource;
            this.accountNoComboBox.DisplayMember = "Description";
            this.accountNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountNoComboBox.FormattingEnabled = true;
            this.accountNoComboBox.Location = new System.Drawing.Point(124, 218);
            this.accountNoComboBox.Name = "accountNoComboBox";
            this.accountNoComboBox.Size = new System.Drawing.Size(121, 21);
            this.accountNoComboBox.TabIndex = 21;
            this.accountNoComboBox.ValueMember = "AccountNo";
            // 
            // gLAccountsBindingSource
            // 
            this.gLAccountsBindingSource.DataMember = "GLAccounts";
            this.gLAccountsBindingSource.DataSource = this.payablesDataSet;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(356, 218);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 23;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(546, 218);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // invoiceLineItemsDataGridView
            // 
            this.invoiceLineItemsDataGridView.AllowUserToAddRows = false;
            this.invoiceLineItemsDataGridView.AllowUserToDeleteRows = false;
            this.invoiceLineItemsDataGridView.AutoGenerateColumns = false;
            this.invoiceLineItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceLineItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.invoiceLineItemsDataGridView.DataSource = this.invoiceLineItemsBindingSource;
            this.invoiceLineItemsDataGridView.Location = new System.Drawing.Point(14, 266);
            this.invoiceLineItemsDataGridView.Name = "invoiceLineItemsDataGridView";
            this.invoiceLineItemsDataGridView.ReadOnly = true;
            this.invoiceLineItemsDataGridView.Size = new System.Drawing.Size(749, 259);
            this.invoiceLineItemsDataGridView.TabIndex = 27;
            // 
            // termsTableAdapter
            // 
            this.termsTableAdapter.ClearBeforeFill = true;
            // 
            // gLAccountsTableAdapter
            // 
            this.gLAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(688, 531);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // invoiceTotalTextBox
            // 
            this.invoiceTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "InvoiceTotal", true));
            this.invoiceTotalTextBox.Location = new System.Drawing.Point(572, 533);
            this.invoiceTotalTextBox.Name = "invoiceTotalTextBox";
            this.invoiceTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.invoiceTotalTextBox.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "InvoiceID";
            this.dataGridViewTextBoxColumn1.HeaderText = "InvoiceID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "InvoiceSequence";
            this.dataGridViewTextBoxColumn2.HeaderText = "InvoiceSequence";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AccountNo";
            this.dataGridViewTextBoxColumn3.HeaderText = "AccountNo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn5.HeaderText = "Description";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // InvoiceTambah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 582);
            this.Controls.Add(invoiceTotalLabel);
            this.Controls.Add(this.invoiceTotalTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.invoiceLineItemsDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(accountNoLabel);
            this.Controls.Add(this.accountNoComboBox);
            this.Controls.Add(dueDateLabel);
            this.Controls.Add(this.dueDateTextBox);
            this.Controls.Add(termsIDLabel);
            this.Controls.Add(this.termsIDComboBox);
            this.Controls.Add(invoiceDateLabel);
            this.Controls.Add(this.invoiceDateDateTimePicker);
            this.Controls.Add(invoiceNumberLabel);
            this.Controls.Add(this.invoiceNumberTextBox);
            this.Controls.Add(this.fillByVendorIDToolStrip);
            this.Controls.Add(zipCodeLabel);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(vendorIDLabel);
            this.Controls.Add(this.vendorIDTextBox);
            this.Name = "InvoiceTambah";
            this.Text = "InvoiceTambah";
            this.Load += new System.EventHandler(this.InvoiceTambah_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payablesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            this.fillByVendorIDToolStrip.ResumeLayout(false);
            this.fillByVendorIDToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.termsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gLAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PayablesDataSet payablesDataSet;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        private PayablesDataSetTableAdapters.VendorsTableAdapter vendorsTableAdapter;
        private PayablesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox vendorIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.ToolStrip fillByVendorIDToolStrip;
        private System.Windows.Forms.ToolStripLabel vendorIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox vendorIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByVendorIDToolStripButton;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private PayablesDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private System.Windows.Forms.TextBox invoiceNumberTextBox;
        private System.Windows.Forms.DateTimePicker invoiceDateDateTimePicker;
        private System.Windows.Forms.ComboBox termsIDComboBox;
        private System.Windows.Forms.TextBox dueDateTextBox;
        private System.Windows.Forms.BindingSource invoiceLineItemsBindingSource;
        private PayablesDataSetTableAdapters.InvoiceLineItemsTableAdapter invoiceLineItemsTableAdapter;
        private System.Windows.Forms.ComboBox accountNoComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView invoiceLineItemsDataGridView;
        private System.Windows.Forms.BindingSource termsBindingSource;
        private PayablesDataSetTableAdapters.TermsTableAdapter termsTableAdapter;
        private System.Windows.Forms.BindingSource gLAccountsBindingSource;
        private PayablesDataSetTableAdapters.GLAccountsTableAdapter gLAccountsTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox invoiceTotalTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}