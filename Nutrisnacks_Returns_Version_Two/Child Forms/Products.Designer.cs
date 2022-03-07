
namespace Nutrisnacks_Returns_Version_Two.Child_Forms
{
    partial class Products
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label product_nameLabel;
            System.Windows.Forms.Label product_NameLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label product_Price_Ex_VatLabel;
            System.Windows.Forms.Label product_IdLabel;
            this.product_TableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.products_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.panel_new_prod = new System.Windows.Forms.Panel();
            this.product_nameTextBox = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add_new = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_prod_search = new System.Windows.Forms.TextBox();
            this.label_current_state = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.product_NameLabel2 = new System.Windows.Forms.Label();
            this.product_Price_Ex_VatNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.product_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add_entry_ds = new Nutrisnacks_Returns_Version_Two.Dataset.add_entry_ds();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_TableTableAdapter = new Nutrisnacks_Returns_Version_Two.Dataset.add_entry_dsTableAdapters.Product_TableTableAdapter();
            this.tableAdapterManager = new Nutrisnacks_Returns_Version_Two.Dataset.add_entry_dsTableAdapters.TableAdapterManager();
            this.product_IdLabel1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            product_nameLabel = new System.Windows.Forms.Label();
            product_NameLabel1 = new System.Windows.Forms.Label();
            product_Price_Ex_VatLabel = new System.Windows.Forms.Label();
            product_IdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.product_TableBindingNavigator)).BeginInit();
            this.product_TableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.products_TableDataGridView)).BeginInit();
            this.panel_new_prod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_Price_Ex_VatNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_TableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_entry_ds)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.Red;
            label2.Location = new System.Drawing.Point(213, 450);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(135, 15);
            label2.TabIndex = 6;
            label2.Text = "Press Save when done!";
            // 
            // product_nameLabel
            // 
            product_nameLabel.AutoSize = true;
            product_nameLabel.Location = new System.Drawing.Point(101, 98);
            product_nameLabel.Name = "product_nameLabel";
            product_nameLabel.Size = new System.Drawing.Size(87, 15);
            product_nameLabel.TabIndex = 2;
            product_nameLabel.Text = "Product name:";
            // 
            // product_NameLabel1
            // 
            product_NameLabel1.AutoSize = true;
            product_NameLabel1.Location = new System.Drawing.Point(824, 123);
            product_NameLabel1.Name = "product_NameLabel1";
            product_NameLabel1.Size = new System.Drawing.Size(89, 15);
            product_NameLabel1.TabIndex = 52;
            product_NameLabel1.Text = "Product Name:";
            // 
            // product_TableBindingNavigator
            // 
            this.product_TableBindingNavigator.AddNewItem = null;
            this.product_TableBindingNavigator.BindingSource = this.product_TableBindingSource;
            this.product_TableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.product_TableBindingNavigator.DeleteItem = null;
            this.product_TableBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.product_TableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.product_TableBindingNavigator.Location = new System.Drawing.Point(0, 564);
            this.product_TableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.product_TableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.product_TableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.product_TableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.product_TableBindingNavigator.Name = "product_TableBindingNavigator";
            this.product_TableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.product_TableBindingNavigator.Size = new System.Drawing.Size(553, 25);
            this.product_TableBindingNavigator.TabIndex = 0;
            this.product_TableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // products_TableDataGridView
            // 
            this.products_TableDataGridView.AllowUserToAddRows = false;
            this.products_TableDataGridView.AllowUserToDeleteRows = false;
            this.products_TableDataGridView.AutoGenerateColumns = false;
            this.products_TableDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.products_TableDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.products_TableDataGridView.ColumnHeadersHeight = 30;
            this.products_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.products_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn});
            this.products_TableDataGridView.DataSource = this.product_TableBindingSource;
            this.products_TableDataGridView.EnableHeadersVisualStyles = false;
            this.products_TableDataGridView.Location = new System.Drawing.Point(13, 123);
            this.products_TableDataGridView.Name = "products_TableDataGridView";
            this.products_TableDataGridView.ReadOnly = true;
            this.products_TableDataGridView.RowHeadersVisible = false;
            this.products_TableDataGridView.RowHeadersWidth = 120;
            this.products_TableDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.products_TableDataGridView.RowTemplate.Height = 44;
            this.products_TableDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.products_TableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.products_TableDataGridView.Size = new System.Drawing.Size(532, 418);
            this.products_TableDataGridView.TabIndex = 2;
            // 
            // panel_new_prod
            // 
            this.panel_new_prod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_new_prod.Controls.Add(product_Price_Ex_VatLabel);
            this.panel_new_prod.Controls.Add(this.product_Price_Ex_VatNumericUpDown);
            this.panel_new_prod.Controls.Add(label2);
            this.panel_new_prod.Controls.Add(this.product_nameTextBox);
            this.panel_new_prod.Controls.Add(product_nameLabel);
            this.panel_new_prod.Location = new System.Drawing.Point(13, 57);
            this.panel_new_prod.Name = "panel_new_prod";
            this.panel_new_prod.Size = new System.Drawing.Size(532, 487);
            this.panel_new_prod.TabIndex = 50;
            this.panel_new_prod.Visible = false;
            // 
            // product_nameTextBox
            // 
            this.product_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_TableBindingSource, "Product_Name", true));
            this.product_nameTextBox.Location = new System.Drawing.Point(194, 95);
            this.product_nameTextBox.Name = "product_nameTextBox";
            this.product_nameTextBox.Size = new System.Drawing.Size(252, 21);
            this.product_nameTextBox.TabIndex = 5;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Enabled = false;
            this.btn_cancel.Location = new System.Drawing.Point(438, 12);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(98, 39);
            this.btn_cancel.TabIndex = 49;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click_1);
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(334, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(98, 39);
            this.btn_save.TabIndex = 48;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_1);
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Location = new System.Drawing.Point(230, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(98, 39);
            this.btn_delete.TabIndex = 47;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click_1);
            // 
            // btn_edit
            // 
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Location = new System.Drawing.Point(126, 12);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(98, 39);
            this.btn_edit.TabIndex = 46;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click_1);
            // 
            // btn_add_new
            // 
            this.btn_add_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_new.Location = new System.Drawing.Point(22, 12);
            this.btn_add_new.Name = "btn_add_new";
            this.btn_add_new.Size = new System.Drawing.Size(98, 39);
            this.btn_add_new.TabIndex = 45;
            this.btn_add_new.Text = "Add New";
            this.btn_add_new.UseVisualStyleBackColor = true;
            this.btn_add_new.Click += new System.EventHandler(this.btn_add_new_Click_1);
            // 
            // btn_search
            // 
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Location = new System.Drawing.Point(446, 78);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(98, 39);
            this.btn_search.TabIndex = 44;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
            // 
            // txt_prod_search
            // 
            this.txt_prod_search.Location = new System.Drawing.Point(13, 87);
            this.txt_prod_search.Name = "txt_prod_search";
            this.txt_prod_search.Size = new System.Drawing.Size(419, 21);
            this.txt_prod_search.TabIndex = 43;
            this.txt_prod_search.TextChanged += new System.EventHandler(this.txt_prod_search_TextChanged_1);
            // 
            // label_current_state
            // 
            this.label_current_state.AutoSize = true;
            this.label_current_state.Location = new System.Drawing.Point(919, 87);
            this.label_current_state.Name = "label_current_state";
            this.label_current_state.Size = new System.Drawing.Size(23, 15);
            this.label_current_state.TabIndex = 52;
            this.label_current_state.Text = "----";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(837, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 51;
            this.label3.Text = "Current state";
            // 
            // product_NameLabel2
            // 
            this.product_NameLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_TableBindingSource, "Product_Name", true));
            this.product_NameLabel2.Location = new System.Drawing.Point(919, 123);
            this.product_NameLabel2.Name = "product_NameLabel2";
            this.product_NameLabel2.Size = new System.Drawing.Size(100, 23);
            this.product_NameLabel2.TabIndex = 53;
            this.product_NameLabel2.Text = "label1";
            // 
            // product_Price_Ex_VatLabel
            // 
            product_Price_Ex_VatLabel.AutoSize = true;
            product_Price_Ex_VatLabel.Location = new System.Drawing.Point(68, 128);
            product_Price_Ex_VatLabel.Name = "product_Price_Ex_VatLabel";
            product_Price_Ex_VatLabel.Size = new System.Drawing.Size(120, 15);
            product_Price_Ex_VatLabel.TabIndex = 6;
            product_Price_Ex_VatLabel.Text = "Product Price Ex Vat:";
            // 
            // product_Price_Ex_VatNumericUpDown
            // 
            this.product_Price_Ex_VatNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.product_TableBindingSource, "Product_Price_Ex_Vat", true));
            this.product_Price_Ex_VatNumericUpDown.DecimalPlaces = 2;
            this.product_Price_Ex_VatNumericUpDown.Location = new System.Drawing.Point(194, 126);
            this.product_Price_Ex_VatNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.product_Price_Ex_VatNumericUpDown.Name = "product_Price_Ex_VatNumericUpDown";
            this.product_Price_Ex_VatNumericUpDown.Size = new System.Drawing.Size(120, 21);
            this.product_Price_Ex_VatNumericUpDown.TabIndex = 7;
            // 
            // product_TableDataGridView
            // 
            this.product_TableDataGridView.AutoGenerateColumns = false;
            this.product_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.product_TableDataGridView.DataSource = this.product_TableBindingSource;
            this.product_TableDataGridView.Location = new System.Drawing.Point(787, 227);
            this.product_TableDataGridView.Name = "product_TableDataGridView";
            this.product_TableDataGridView.Size = new System.Drawing.Size(300, 220);
            this.product_TableDataGridView.TabIndex = 53;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product_Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Product_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Product_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Product_Category";
            this.dataGridViewTextBoxColumn3.HeaderText = "Product_Category";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Product_Price_Ex_Vat";
            this.dataGridViewTextBoxColumn4.HeaderText = "Product_Price_Ex_Vat";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Product_Price_Inc_Vat";
            this.dataGridViewTextBoxColumn5.HeaderText = "Product_Price_Inc_Vat";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Product_Vat";
            this.dataGridViewTextBoxColumn6.HeaderText = "Product_Vat";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Vat_Percentage";
            this.dataGridViewTextBoxColumn7.HeaderText = "Vat_Percentage";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // product_TableBindingSource
            // 
            this.product_TableBindingSource.DataMember = "Product_Table";
            this.product_TableBindingSource.DataSource = this.add_entry_ds;
            // 
            // add_entry_ds
            // 
            this.add_entry_ds.DataSetName = "add_entry_ds";
            this.add_entry_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // product_TableTableAdapter
            // 
            this.product_TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Categories_TableTableAdapter = null;
            this.tableAdapterManager.Customers_TableTableAdapter = null;
            this.tableAdapterManager.Faults_TableTableAdapter = null;
            this.tableAdapterManager.Product_TableTableAdapter = this.product_TableTableAdapter;
            this.tableAdapterManager.Reps_TableTableAdapter = null;
            this.tableAdapterManager.Returns_TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Nutrisnacks_Returns_Version_Two.Dataset.add_entry_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Users_TableTableAdapter = null;
            // 
            // product_IdLabel
            // 
            product_IdLabel.AutoSize = true;
            product_IdLabel.Location = new System.Drawing.Point(836, 176);
            product_IdLabel.Name = "product_IdLabel";
            product_IdLabel.Size = new System.Drawing.Size(65, 15);
            product_IdLabel.TabIndex = 53;
            product_IdLabel.Text = "Product Id:";
            // 
            // product_IdLabel1
            // 
            this.product_IdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_TableBindingSource, "Product_Id", true));
            this.product_IdLabel1.Location = new System.Drawing.Point(907, 176);
            this.product_IdLabel1.Name = "product_IdLabel1";
            this.product_IdLabel1.Size = new System.Drawing.Size(100, 23);
            this.product_IdLabel1.TabIndex = 54;
            this.product_IdLabel1.Text = "label1";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 589);
            this.Controls.Add(product_IdLabel);
            this.Controls.Add(this.product_IdLabel1);
            this.Controls.Add(this.product_TableDataGridView);
            this.Controls.Add(product_NameLabel1);
            this.Controls.Add(this.product_NameLabel2);
            this.Controls.Add(this.label_current_state);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel_new_prod);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add_new);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_prod_search);
            this.Controls.Add(this.products_TableDataGridView);
            this.Controls.Add(this.product_TableBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Products";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_TableBindingNavigator)).EndInit();
            this.product_TableBindingNavigator.ResumeLayout(false);
            this.product_TableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.products_TableDataGridView)).EndInit();
            this.panel_new_prod.ResumeLayout(false);
            this.panel_new_prod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_Price_Ex_VatNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_TableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_entry_ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dataset.add_entry_ds add_entry_ds;
        private System.Windows.Forms.BindingSource product_TableBindingSource;
        private Dataset.add_entry_dsTableAdapters.Product_TableTableAdapter product_TableTableAdapter;
        private Dataset.add_entry_dsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator product_TableBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView products_TableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel_new_prod;
        private System.Windows.Forms.TextBox product_nameTextBox;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add_new;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_prod_search;
        private System.Windows.Forms.Label label_current_state;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label product_NameLabel2;
        private System.Windows.Forms.NumericUpDown product_Price_Ex_VatNumericUpDown;
        private System.Windows.Forms.DataGridView product_TableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label product_IdLabel1;
    }
}