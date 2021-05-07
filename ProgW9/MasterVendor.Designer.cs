
namespace ProgW9
{
    partial class MasterVendor
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
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label zipCodeLabel;
            System.Windows.Forms.Label defaultTermsIDLabel;
            System.Windows.Forms.Label defaultAccountNoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterVendor));
            System.Windows.Forms.Label phoneLabel1;
            System.Windows.Forms.Label stateLabel1;
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
            this.vendorIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.statesTableAdapter = new ProgW9.PayablesDataSetTableAdapters.StatesTableAdapter();
            this.defaultTermsIDComboBox = new System.Windows.Forms.ComboBox();
            this.termsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.termsTableAdapter = new ProgW9.PayablesDataSetTableAdapters.TermsTableAdapter();
            this.defaultAccountNoComboBox = new System.Windows.Forms.ComboBox();
            this.gLAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gLAccountsTableAdapter = new ProgW9.PayablesDataSetTableAdapters.GLAccountsTableAdapter();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.stateComboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            vendorIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zipCodeLabel = new System.Windows.Forms.Label();
            defaultTermsIDLabel = new System.Windows.Forms.Label();
            defaultAccountNoLabel = new System.Windows.Forms.Label();
            phoneLabel1 = new System.Windows.Forms.Label();
            stateLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.payablesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingNavigator)).BeginInit();
            this.vendorsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gLAccountsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vendorIDLabel
            // 
            vendorIDLabel.AutoSize = true;
            vendorIDLabel.Location = new System.Drawing.Point(12, 36);
            vendorIDLabel.Name = "vendorIDLabel";
            vendorIDLabel.Size = new System.Drawing.Size(58, 13);
            vendorIDLabel.TabIndex = 1;
            vendorIDLabel.Text = "Vendor ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 62);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(12, 88);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(54, 13);
            address1Label.TabIndex = 5;
            address1Label.Text = "Address1:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(12, 140);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 9;
            cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(12, 166);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 11;
            stateLabel.Text = "State:";
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new System.Drawing.Point(222, 166);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new System.Drawing.Size(53, 13);
            zipCodeLabel.TabIndex = 13;
            zipCodeLabel.Text = "Zip Code:";
            // 
            // defaultTermsIDLabel
            // 
            defaultTermsIDLabel.AutoSize = true;
            defaultTermsIDLabel.Location = new System.Drawing.Point(12, 195);
            defaultTermsIDLabel.Name = "defaultTermsIDLabel";
            defaultTermsIDLabel.Size = new System.Drawing.Size(90, 13);
            defaultTermsIDLabel.TabIndex = 14;
            defaultTermsIDLabel.Text = "Default Terms ID:";
            // 
            // defaultAccountNoLabel
            // 
            defaultAccountNoLabel.AutoSize = true;
            defaultAccountNoLabel.Location = new System.Drawing.Point(12, 222);
            defaultAccountNoLabel.Name = "defaultAccountNoLabel";
            defaultAccountNoLabel.Size = new System.Drawing.Size(104, 13);
            defaultAccountNoLabel.TabIndex = 16;
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
            this.tableAdapterManager.InvoicesTableAdapter = null;
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
            this.vendorsBindingNavigator.Size = new System.Drawing.Size(800, 25);
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
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            this.vendorsBindingNavigatorSaveItem.Click += new System.EventHandler(this.vendorsBindingNavigatorSaveItem_Click);
            // 
            // vendorIDTextBox
            // 
            this.vendorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorID", true));
            this.vendorIDTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.vendorIDTextBox.Location = new System.Drawing.Point(122, 33);
            this.vendorIDTextBox.Name = "vendorIDTextBox";
            this.vendorIDTextBox.Size = new System.Drawing.Size(227, 20);
            this.vendorIDTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(122, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(227, 20);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // address1TextBox
            // 
            this.address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "Address1", true));
            this.address1TextBox.Location = new System.Drawing.Point(122, 85);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(227, 20);
            this.address1TextBox.TabIndex = 6;
            // 
            // address2TextBox
            // 
            this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "Address2", true));
            this.address2TextBox.Location = new System.Drawing.Point(122, 111);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(227, 20);
            this.address2TextBox.TabIndex = 8;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(122, 137);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(227, 20);
            this.cityTextBox.TabIndex = 10;
            // 
            // stateComboBox
            // 
            this.stateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendorsBindingSource, "State", true));
            this.stateComboBox.DataSource = this.statesBindingSource;
            this.stateComboBox.DisplayMember = "StateName";
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(122, 163);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(82, 21);
            this.stateComboBox.TabIndex = 12;
            this.stateComboBox.ValueMember = "StateCode";
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.payablesDataSet;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "ZipCode", true));
            this.zipCodeTextBox.Location = new System.Drawing.Point(281, 163);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(68, 20);
            this.zipCodeTextBox.TabIndex = 14;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // defaultTermsIDComboBox
            // 
            this.defaultTermsIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendorsBindingSource, "DefaultTermsID", true));
            this.defaultTermsIDComboBox.DataSource = this.termsBindingSource;
            this.defaultTermsIDComboBox.DisplayMember = "Description";
            this.defaultTermsIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defaultTermsIDComboBox.FormattingEnabled = true;
            this.defaultTermsIDComboBox.Location = new System.Drawing.Point(122, 192);
            this.defaultTermsIDComboBox.Name = "defaultTermsIDComboBox";
            this.defaultTermsIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.defaultTermsIDComboBox.TabIndex = 15;
            this.defaultTermsIDComboBox.ValueMember = "TermsID";
            // 
            // termsBindingSource
            // 
            this.termsBindingSource.DataMember = "Terms";
            this.termsBindingSource.DataSource = this.payablesDataSet;
            // 
            // termsTableAdapter
            // 
            this.termsTableAdapter.ClearBeforeFill = true;
            // 
            // defaultAccountNoComboBox
            // 
            this.defaultAccountNoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendorsBindingSource, "DefaultAccountNo", true));
            this.defaultAccountNoComboBox.DataSource = this.gLAccountsBindingSource;
            this.defaultAccountNoComboBox.DisplayMember = "Description";
            this.defaultAccountNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defaultAccountNoComboBox.FormattingEnabled = true;
            this.defaultAccountNoComboBox.Location = new System.Drawing.Point(122, 219);
            this.defaultAccountNoComboBox.Name = "defaultAccountNoComboBox";
            this.defaultAccountNoComboBox.Size = new System.Drawing.Size(121, 21);
            this.defaultAccountNoComboBox.TabIndex = 17;
            this.defaultAccountNoComboBox.ValueMember = "AccountNo";
            // 
            // gLAccountsBindingSource
            // 
            this.gLAccountsBindingSource.DataMember = "GLAccounts";
            this.gLAccountsBindingSource.DataSource = this.payablesDataSet;
            // 
            // gLAccountsTableAdapter
            // 
            this.gLAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // phoneLabel1
            // 
            phoneLabel1.AutoSize = true;
            phoneLabel1.Location = new System.Drawing.Point(12, 249);
            phoneLabel1.Name = "phoneLabel1";
            phoneLabel1.Size = new System.Drawing.Size(41, 13);
            phoneLabel1.TabIndex = 19;
            phoneLabel1.Text = "Phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(122, 249);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(227, 20);
            this.phoneTextBox.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stateLabel1
            // 
            stateLabel1.AutoSize = true;
            stateLabel1.Location = new System.Drawing.Point(81, 291);
            stateLabel1.Name = "stateLabel1";
            stateLabel1.Size = new System.Drawing.Size(35, 13);
            stateLabel1.TabIndex = 21;
            stateLabel1.Text = "State:";
            // 
            // stateComboBox1
            // 
            this.stateComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendorsBindingSource, "State", true));
            this.stateComboBox1.DataSource = this.statesBindingSource;
            this.stateComboBox1.DisplayMember = "StateName";
            this.stateComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox1.FormattingEnabled = true;
            this.stateComboBox1.Location = new System.Drawing.Point(122, 288);
            this.stateComboBox1.Name = "stateComboBox1";
            this.stateComboBox1.Size = new System.Drawing.Size(121, 21);
            this.stateComboBox1.TabIndex = 22;
            this.stateComboBox1.ValueMember = "StateCode";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MasterVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.button2);
            this.Controls.Add(stateLabel1);
            this.Controls.Add(this.stateComboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(phoneLabel1);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(defaultAccountNoLabel);
            this.Controls.Add(this.defaultAccountNoComboBox);
            this.Controls.Add(defaultTermsIDLabel);
            this.Controls.Add(this.defaultTermsIDComboBox);
            this.Controls.Add(vendorIDLabel);
            this.Controls.Add(this.vendorIDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(zipCodeLabel);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.vendorsBindingNavigator);
            this.Name = "MasterVendor";
            this.Text = "`";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payablesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingNavigator)).EndInit();
            this.vendorsBindingNavigator.ResumeLayout(false);
            this.vendorsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gLAccountsBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox vendorIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private PayablesDataSetTableAdapters.StatesTableAdapter statesTableAdapter;
        private System.Windows.Forms.ComboBox defaultTermsIDComboBox;
        private System.Windows.Forms.BindingSource termsBindingSource;
        private PayablesDataSetTableAdapters.TermsTableAdapter termsTableAdapter;
        private System.Windows.Forms.ComboBox defaultAccountNoComboBox;
        private System.Windows.Forms.BindingSource gLAccountsBindingSource;
        private PayablesDataSetTableAdapters.GLAccountsTableAdapter gLAccountsTableAdapter;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox stateComboBox1;
        private System.Windows.Forms.Button button2;
    }
}