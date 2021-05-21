
namespace ProgW9
{
    partial class InvoiceMaintenance
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
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label zipCodeLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label contactLNameLabel;
            System.Windows.Forms.Label contactFNameLabel;
            System.Windows.Forms.Label defaultTermsIDLabel;
            System.Windows.Forms.Label defaultAccountNoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceMaintenance));
            this.payablesDataSet = new ProgW9.PayablesDataSet();
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorsTableAdapter = new ProgW9.PayablesDataSetTableAdapters.VendorsTableAdapter();
            this.tableAdapterManager = new ProgW9.PayablesDataSetTableAdapters.TableAdapterManager();
            this.vendorsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vendorsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vendorIDSpinEdit = new System.Windows.Forms.TextBox();
            this.nameTextEdit = new System.Windows.Forms.TextBox();
            this.address1TextEdit = new System.Windows.Forms.TextBox();
            this.address2TextEdit = new System.Windows.Forms.TextBox();
            this.cityTextEdit = new System.Windows.Forms.TextBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.zipCodeTextEdit = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.contactLNameTextEdit = new System.Windows.Forms.TextBox();
            this.contactFNameTextEdit = new System.Windows.Forms.TextBox();
            this.defaultTermsIDComboBox = new System.Windows.Forms.ComboBox();
            this.defaultAccountNoComboBox = new System.Windows.Forms.ComboBox();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoicesTableAdapter = new ProgW9.PayablesDataSetTableAdapters.InvoicesTableAdapter();
            this.invoicesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceLineItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceLineItemsTableAdapter = new ProgW9.PayablesDataSetTableAdapters.InvoiceLineItemsTableAdapter();
            this.invoiceLineItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            vendorIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zipCodeLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            contactLNameLabel = new System.Windows.Forms.Label();
            contactFNameLabel = new System.Windows.Forms.Label();
            defaultTermsIDLabel = new System.Windows.Forms.Label();
            defaultAccountNoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.payablesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingNavigator)).BeginInit();
            this.vendorsBindingNavigator.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.vendorIDSpinEdit.Properties)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.address1TextEdit.Properties)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.address2TextEdit.Properties)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.cityTextEdit.Properties)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.zipCodeTextEdit.Properties)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.contactLNameTextEdit.Properties)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.contactFNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vendorIDLabel
            // 
            vendorIDLabel.AutoSize = true;
            vendorIDLabel.Location = new System.Drawing.Point(174, 58);
            vendorIDLabel.Name = "vendorIDLabel";
            vendorIDLabel.Size = new System.Drawing.Size(58, 13);
            vendorIDLabel.TabIndex = 1;
            vendorIDLabel.Text = "Vendor ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(174, 84);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(174, 110);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(54, 13);
            address1Label.TabIndex = 5;
            address1Label.Text = "Address1:";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Location = new System.Drawing.Point(174, 136);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(54, 13);
            address2Label.TabIndex = 7;
            address2Label.Text = "Address2:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(174, 162);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 9;
            cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(174, 191);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 11;
            stateLabel.Text = "State:";
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new System.Drawing.Point(465, 55);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new System.Drawing.Size(53, 13);
            zipCodeLabel.TabIndex = 13;
            zipCodeLabel.Text = "Zip Code:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(465, 84);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 15;
            phoneLabel.Text = "Phone:";
            // 
            // contactLNameLabel
            // 
            contactLNameLabel.AutoSize = true;
            contactLNameLabel.Location = new System.Drawing.Point(465, 107);
            contactLNameLabel.Name = "contactLNameLabel";
            contactLNameLabel.Size = new System.Drawing.Size(84, 13);
            contactLNameLabel.TabIndex = 17;
            contactLNameLabel.Text = "Contact LName:";
            // 
            // contactFNameLabel
            // 
            contactFNameLabel.AutoSize = true;
            contactFNameLabel.Location = new System.Drawing.Point(465, 133);
            contactFNameLabel.Name = "contactFNameLabel";
            contactFNameLabel.Size = new System.Drawing.Size(84, 13);
            contactFNameLabel.TabIndex = 19;
            contactFNameLabel.Text = "Contact FName:";
            // 
            // defaultTermsIDLabel
            // 
            defaultTermsIDLabel.AutoSize = true;
            defaultTermsIDLabel.Location = new System.Drawing.Point(465, 162);
            defaultTermsIDLabel.Name = "defaultTermsIDLabel";
            defaultTermsIDLabel.Size = new System.Drawing.Size(90, 13);
            defaultTermsIDLabel.TabIndex = 21;
            defaultTermsIDLabel.Text = "Default Terms ID:";
            // 
            // defaultAccountNoLabel
            // 
            defaultAccountNoLabel.AutoSize = true;
            defaultAccountNoLabel.Location = new System.Drawing.Point(465, 189);
            defaultAccountNoLabel.Name = "defaultAccountNoLabel";
            defaultAccountNoLabel.Size = new System.Drawing.Size(104, 13);
            defaultAccountNoLabel.TabIndex = 23;
            defaultAccountNoLabel.Text = "Default Account No:";
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
            this.tableAdapterManager.StatesTableAdapter = null;
            this.tableAdapterManager.TermsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProgW9.PayablesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorsTableAdapter = this.vendorsTableAdapter;
            // 
            // vendorsBindingNavigator
            // 
            this.vendorsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vendorsBindingNavigator.BindingSource = this.vendorsBindingSource;
            this.vendorsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vendorsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vendorsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.vendorsBindingNavigatorSaveItem});
            this.vendorsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vendorsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vendorsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vendorsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vendorsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vendorsBindingNavigator.Name = "vendorsBindingNavigator";
            this.vendorsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vendorsBindingNavigator.Size = new System.Drawing.Size(965, 25);
            this.vendorsBindingNavigator.TabIndex = 0;
            this.vendorsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // vendorsBindingNavigatorSaveItem
            // 
            this.vendorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vendorsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vendorsBindingNavigatorSaveItem.Image")));
            this.vendorsBindingNavigatorSaveItem.Name = "vendorsBindingNavigatorSaveItem";
            this.vendorsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vendorsBindingNavigatorSaveItem.Text = "Save Data";
            this.vendorsBindingNavigatorSaveItem.Click += new System.EventHandler(this.vendorsBindingNavigatorSaveItem_Click_1);
            // 
            // vendorIDSpinEdit
            // 
            this.vendorIDSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorID", true));
            //this.vendorIDSpinEdit.EditValue = new decimal(new int[] {
            //0,
            //0,
            //0,
            //0});
            this.vendorIDSpinEdit.Location = new System.Drawing.Point(284, 55);
            this.vendorIDSpinEdit.Name = "vendorIDSpinEdit";
            //this.vendorIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            //new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.vendorIDSpinEdit.Size = new System.Drawing.Size(121, 20);
            this.vendorIDSpinEdit.TabIndex = 2;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "Name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(284, 81);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(121, 20);
            this.nameTextEdit.TabIndex = 4;
            // 
            // address1TextEdit
            // 
            this.address1TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "Address1", true));
            this.address1TextEdit.Location = new System.Drawing.Point(284, 107);
            this.address1TextEdit.Name = "address1TextEdit";
            this.address1TextEdit.Size = new System.Drawing.Size(121, 20);
            this.address1TextEdit.TabIndex = 6;
            // 
            // address2TextEdit
            // 
            this.address2TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "Address2", true));
            this.address2TextEdit.Location = new System.Drawing.Point(284, 133);
            this.address2TextEdit.Name = "address2TextEdit";
            this.address2TextEdit.Size = new System.Drawing.Size(121, 20);
            this.address2TextEdit.TabIndex = 8;
            // 
            // cityTextEdit
            // 
            this.cityTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "City", true));
            this.cityTextEdit.Location = new System.Drawing.Point(284, 159);
            this.cityTextEdit.Name = "cityTextEdit";
            this.cityTextEdit.Size = new System.Drawing.Size(121, 20);
            this.cityTextEdit.TabIndex = 10;
            // 
            // stateComboBox
            // 
            this.stateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "State", true));
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(284, 188);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(121, 21);
            this.stateComboBox.TabIndex = 12;
            // 
            // zipCodeTextEdit
            // 
            this.zipCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "ZipCode", true));
            this.zipCodeTextEdit.Location = new System.Drawing.Point(575, 52);
            this.zipCodeTextEdit.Name = "zipCodeTextEdit";
            this.zipCodeTextEdit.Size = new System.Drawing.Size(121, 20);
            this.zipCodeTextEdit.TabIndex = 14;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(575, 81);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(121, 20);
            this.phoneTextBox.TabIndex = 16;
            // 
            // contactLNameTextEdit
            // 
            this.contactLNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "ContactLName", true));
            this.contactLNameTextEdit.Location = new System.Drawing.Point(575, 104);
            this.contactLNameTextEdit.Name = "contactLNameTextEdit";
            this.contactLNameTextEdit.Size = new System.Drawing.Size(121, 20);
            this.contactLNameTextEdit.TabIndex = 18;
            // 
            // contactFNameTextEdit
            // 
            this.contactFNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "ContactFName", true));
            this.contactFNameTextEdit.Location = new System.Drawing.Point(575, 130);
            this.contactFNameTextEdit.Name = "contactFNameTextEdit";
            this.contactFNameTextEdit.Size = new System.Drawing.Size(121, 20);
            this.contactFNameTextEdit.TabIndex = 20;
            // 
            // defaultTermsIDComboBox
            // 
            this.defaultTermsIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "DefaultTermsID", true));
            this.defaultTermsIDComboBox.FormattingEnabled = true;
            this.defaultTermsIDComboBox.Location = new System.Drawing.Point(575, 159);
            this.defaultTermsIDComboBox.Name = "defaultTermsIDComboBox";
            this.defaultTermsIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.defaultTermsIDComboBox.TabIndex = 22;
            // 
            // defaultAccountNoComboBox
            // 
            this.defaultAccountNoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "DefaultAccountNo", true));
            this.defaultAccountNoComboBox.FormattingEnabled = true;
            this.defaultAccountNoComboBox.Location = new System.Drawing.Point(575, 186);
            this.defaultAccountNoComboBox.Name = "defaultAccountNoComboBox";
            this.defaultAccountNoComboBox.Size = new System.Drawing.Size(121, 21);
            this.defaultAccountNoComboBox.TabIndex = 24;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "FK_Invoices_Vendors";
            this.invoicesBindingSource.DataSource = this.vendorsBindingSource;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // invoicesDataGridView
            // 
            this.invoicesDataGridView.AutoGenerateColumns = false;
            this.invoicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.invoicesDataGridView.DataSource = this.invoicesBindingSource;
            this.invoicesDataGridView.Location = new System.Drawing.Point(29, 236);
            this.invoicesDataGridView.Name = "invoicesDataGridView";
            this.invoicesDataGridView.Size = new System.Drawing.Size(889, 249);
            this.invoicesDataGridView.TabIndex = 25;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "VendorID";
            this.dataGridViewTextBoxColumn2.HeaderText = "VendorID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "InvoiceNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "InvoiceNumber";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "InvoiceDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "InvoiceDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "InvoiceTotal";
            this.dataGridViewTextBoxColumn5.HeaderText = "InvoiceTotal";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PaymentTotal";
            this.dataGridViewTextBoxColumn6.HeaderText = "PaymentTotal";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CreditTotal";
            this.dataGridViewTextBoxColumn7.HeaderText = "CreditTotal";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TermsID";
            this.dataGridViewTextBoxColumn8.HeaderText = "TermsID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DueDate";
            this.dataGridViewTextBoxColumn9.HeaderText = "DueDate";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PaymentDate";
            this.dataGridViewTextBoxColumn10.HeaderText = "PaymentDate";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // invoiceLineItemsBindingSource
            // 
            this.invoiceLineItemsBindingSource.DataMember = "FK_InvoiceLineItems_Invoices";
            this.invoiceLineItemsBindingSource.DataSource = this.invoicesBindingSource;
            // 
            // invoiceLineItemsTableAdapter
            // 
            this.invoiceLineItemsTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceLineItemsDataGridView
            // 
            this.invoiceLineItemsDataGridView.AutoGenerateColumns = false;
            this.invoiceLineItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceLineItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.invoiceLineItemsDataGridView.DataSource = this.invoiceLineItemsBindingSource;
            this.invoiceLineItemsDataGridView.Location = new System.Drawing.Point(29, 526);
            this.invoiceLineItemsDataGridView.Name = "invoiceLineItemsDataGridView";
            this.invoiceLineItemsDataGridView.Size = new System.Drawing.Size(565, 218);
            this.invoiceLineItemsDataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "InvoiceID";
            this.dataGridViewTextBoxColumn11.HeaderText = "InvoiceID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "InvoiceSequence";
            this.dataGridViewTextBoxColumn12.HeaderText = "InvoiceSequence";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "AccountNo";
            this.dataGridViewTextBoxColumn13.HeaderText = "AccountNo";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn14.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn15.HeaderText = "Description";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // InvoiceMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 793);
            this.Controls.Add(this.invoiceLineItemsDataGridView);
            this.Controls.Add(this.invoicesDataGridView);
            this.Controls.Add(vendorIDLabel);
            this.Controls.Add(this.vendorIDSpinEdit);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextEdit);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.address1TextEdit);
            this.Controls.Add(address2Label);
            this.Controls.Add(this.address2TextEdit);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextEdit);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(zipCodeLabel);
            this.Controls.Add(this.zipCodeTextEdit);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(contactLNameLabel);
            this.Controls.Add(this.contactLNameTextEdit);
            this.Controls.Add(contactFNameLabel);
            this.Controls.Add(this.contactFNameTextEdit);
            this.Controls.Add(defaultTermsIDLabel);
            this.Controls.Add(this.defaultTermsIDComboBox);
            this.Controls.Add(defaultAccountNoLabel);
            this.Controls.Add(this.defaultAccountNoComboBox);
            this.Controls.Add(this.vendorsBindingNavigator);
            this.Name = "InvoiceMaintenance";
            this.Text = "InvoiceMaintenance";
            this.Load += new System.EventHandler(this.InvoiceMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payablesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingNavigator)).EndInit();
            this.vendorsBindingNavigator.ResumeLayout(false);
            this.vendorsBindingNavigator.PerformLayout();
            //((System.ComponentModel.ISupportInitialize)(this.vendorIDSpinEdit.Properties)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.address1TextEdit.Properties)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.address2TextEdit.Properties)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.cityTextEdit.Properties)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.zipCodeTextEdit.Properties)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.contactLNameTextEdit.Properties)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.contactFNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PayablesDataSet payablesDataSet;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        private PayablesDataSetTableAdapters.VendorsTableAdapter vendorsTableAdapter;
        private PayablesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vendorsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton vendorsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox vendorIDSpinEdit;
        private System.Windows.Forms.TextBox nameTextEdit;
        private System.Windows.Forms.TextBox address1TextEdit;
        private System.Windows.Forms.TextBox address2TextEdit;
        private System.Windows.Forms.TextBox cityTextEdit;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.TextBox zipCodeTextEdit;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox contactLNameTextEdit;
        private System.Windows.Forms.TextBox contactFNameTextEdit;
        private System.Windows.Forms.ComboBox defaultTermsIDComboBox;
        private System.Windows.Forms.ComboBox defaultAccountNoComboBox;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private PayablesDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private System.Windows.Forms.DataGridView invoicesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource invoiceLineItemsBindingSource;
        private PayablesDataSetTableAdapters.InvoiceLineItemsTableAdapter invoiceLineItemsTableAdapter;
        private System.Windows.Forms.DataGridView invoiceLineItemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    }
}