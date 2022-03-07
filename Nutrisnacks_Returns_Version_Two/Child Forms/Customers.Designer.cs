
namespace Nutrisnacks_Returns_Version_Two.Child_Forms
{
    partial class Customers
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label customer_nameLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label customer_nameLabel1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.customers_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customers_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add_entry_ds = new Nutrisnacks_Returns_Version_Two.Dataset.add_entry_ds();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.customers_TableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.txt_cust_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_add_new = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.customer_nameTextBox = new System.Windows.Forms.TextBox();
            this.panel_new_cust = new System.Windows.Forms.Panel();
            this.customers_TableTableAdapter = new Nutrisnacks_Returns_Version_Two.Dataset.add_entry_dsTableAdapters.Customers_TableTableAdapter();
            this.tableAdapterManager = new Nutrisnacks_Returns_Version_Two.Dataset.add_entry_dsTableAdapters.TableAdapterManager();
            this.customer_nameLabel2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_current_state = new System.Windows.Forms.Label();
            this.returns_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.returns_TableTableAdapter = new Nutrisnacks_Returns_Version_Two.Dataset.add_entry_dsTableAdapters.Returns_TableTableAdapter();
            label1 = new System.Windows.Forms.Label();
            customer_nameLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            customer_nameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customers_TableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customers_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_entry_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customers_TableBindingNavigator)).BeginInit();
            this.customers_TableBindingNavigator.SuspendLayout();
            this.panel_new_cust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returns_TableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Location = new System.Drawing.Point(735, 428);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(349, 15);
            label1.TabIndex = 4;
            label1.Text = "The table below will update if a similar customer already exists:";
            // 
            // customer_nameLabel
            // 
            customer_nameLabel.AutoSize = true;
            customer_nameLabel.Location = new System.Drawing.Point(37, 15);
            customer_nameLabel.Name = "customer_nameLabel";
            customer_nameLabel.Size = new System.Drawing.Size(98, 15);
            customer_nameLabel.TabIndex = 2;
            customer_nameLabel.Text = "Customer name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.Red;
            label2.Location = new System.Drawing.Point(204, 42);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(135, 15);
            label2.TabIndex = 6;
            label2.Text = "Press Save when done!";
            // 
            // customer_nameLabel1
            // 
            customer_nameLabel1.AutoSize = true;
            customer_nameLabel1.Location = new System.Drawing.Point(772, 132);
            customer_nameLabel1.Name = "customer_nameLabel1";
            customer_nameLabel1.Size = new System.Drawing.Size(98, 15);
            customer_nameLabel1.TabIndex = 42;
            customer_nameLabel1.Text = "Customer name:";
            // 
            // customers_TableDataGridView
            // 
            this.customers_TableDataGridView.AllowUserToAddRows = false;
            this.customers_TableDataGridView.AllowUserToDeleteRows = false;
            this.customers_TableDataGridView.AutoGenerateColumns = false;
            this.customers_TableDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customers_TableDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customers_TableDataGridView.ColumnHeadersHeight = 30;
            this.customers_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.customers_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.customers_TableDataGridView.DataSource = this.customers_TableBindingSource;
            this.customers_TableDataGridView.EnableHeadersVisualStyles = false;
            this.customers_TableDataGridView.Location = new System.Drawing.Point(12, 123);
            this.customers_TableDataGridView.Name = "customers_TableDataGridView";
            this.customers_TableDataGridView.ReadOnly = true;
            this.customers_TableDataGridView.RowHeadersVisible = false;
            this.customers_TableDataGridView.RowHeadersWidth = 120;
            this.customers_TableDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.customers_TableDataGridView.RowTemplate.Height = 44;
            this.customers_TableDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.customers_TableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customers_TableDataGridView.Size = new System.Drawing.Size(532, 418);
            this.customers_TableDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Customer_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // customers_TableBindingSource
            // 
            this.customers_TableBindingSource.DataMember = "Customers_Table";
            this.customers_TableBindingSource.DataSource = this.add_entry_ds;
            // 
            // add_entry_ds
            // 
            this.add_entry_ds.DataSetName = "add_entry_ds";
            this.add_entry_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // customers_TableBindingNavigator
            // 
            this.customers_TableBindingNavigator.AddNewItem = null;
            this.customers_TableBindingNavigator.BindingSource = this.customers_TableBindingSource;
            this.customers_TableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customers_TableBindingNavigator.DeleteItem = null;
            this.customers_TableBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customers_TableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.customers_TableBindingNavigator.Location = new System.Drawing.Point(0, 561);
            this.customers_TableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customers_TableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customers_TableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customers_TableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customers_TableBindingNavigator.Name = "customers_TableBindingNavigator";
            this.customers_TableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customers_TableBindingNavigator.Size = new System.Drawing.Size(560, 25);
            this.customers_TableBindingNavigator.TabIndex = 0;
            this.customers_TableBindingNavigator.Text = "bindingNavigator1";
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
            // txt_cust_search
            // 
            this.txt_cust_search.Location = new System.Drawing.Point(12, 87);
            this.txt_cust_search.Name = "txt_cust_search";
            this.txt_cust_search.Size = new System.Drawing.Size(420, 21);
            this.txt_cust_search.TabIndex = 2;
            this.txt_cust_search.TextChanged += new System.EventHandler(this.txt_cust_search_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Location = new System.Drawing.Point(446, 78);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(98, 39);
            this.btn_search.TabIndex = 36;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_add_new
            // 
            this.btn_add_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_new.Location = new System.Drawing.Point(22, 12);
            this.btn_add_new.Name = "btn_add_new";
            this.btn_add_new.Size = new System.Drawing.Size(98, 39);
            this.btn_add_new.TabIndex = 37;
            this.btn_add_new.Text = "Add New";
            this.btn_add_new.UseVisualStyleBackColor = true;
            this.btn_add_new.Click += new System.EventHandler(this.btn_add_new_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Location = new System.Drawing.Point(126, 12);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(98, 39);
            this.btn_edit.TabIndex = 38;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Location = new System.Drawing.Point(230, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(98, 39);
            this.btn_delete.TabIndex = 39;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(334, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(98, 39);
            this.btn_save.TabIndex = 40;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Enabled = false;
            this.btn_cancel.Location = new System.Drawing.Point(438, 12);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(98, 39);
            this.btn_cancel.TabIndex = 41;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // customer_nameTextBox
            // 
            this.customer_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customers_TableBindingSource, "Customer_name", true));
            this.customer_nameTextBox.Location = new System.Drawing.Point(141, 12);
            this.customer_nameTextBox.Name = "customer_nameTextBox";
            this.customer_nameTextBox.Size = new System.Drawing.Size(356, 21);
            this.customer_nameTextBox.TabIndex = 5;
            // 
            // panel_new_cust
            // 
            this.panel_new_cust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_new_cust.Controls.Add(label2);
            this.panel_new_cust.Controls.Add(this.customer_nameTextBox);
            this.panel_new_cust.Controls.Add(customer_nameLabel);
            this.panel_new_cust.Location = new System.Drawing.Point(12, 57);
            this.panel_new_cust.Name = "panel_new_cust";
            this.panel_new_cust.Size = new System.Drawing.Size(532, 71);
            this.panel_new_cust.TabIndex = 42;
            this.panel_new_cust.Visible = false;
            // 
            // customers_TableTableAdapter
            // 
            this.customers_TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Categories_TableTableAdapter = null;
            this.tableAdapterManager.Customers_TableTableAdapter = this.customers_TableTableAdapter;
            this.tableAdapterManager.Faults_TableTableAdapter = null;
            this.tableAdapterManager.Product_TableTableAdapter = null;
            this.tableAdapterManager.Reps_TableTableAdapter = null;
            this.tableAdapterManager.Returns_TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Nutrisnacks_Returns_Version_Two.Dataset.add_entry_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Users_TableTableAdapter = null;
            // 
            // customer_nameLabel2
            // 
            this.customer_nameLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customers_TableBindingSource, "Customer_name", true));
            this.customer_nameLabel2.Location = new System.Drawing.Point(876, 132);
            this.customer_nameLabel2.Name = "customer_nameLabel2";
            this.customer_nameLabel2.Size = new System.Drawing.Size(233, 23);
            this.customer_nameLabel2.TabIndex = 43;
            this.customer_nameLabel2.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(794, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "Current state";
            // 
            // label_current_state
            // 
            this.label_current_state.AutoSize = true;
            this.label_current_state.Location = new System.Drawing.Point(876, 70);
            this.label_current_state.Name = "label_current_state";
            this.label_current_state.Size = new System.Drawing.Size(23, 15);
            this.label_current_state.TabIndex = 45;
            this.label_current_state.Text = "----";
            // 
            // returns_TableBindingSource
            // 
            this.returns_TableBindingSource.DataMember = "Returns_Table";
            this.returns_TableBindingSource.DataSource = this.add_entry_ds;
            // 
            // returns_TableTableAdapter
            // 
            this.returns_TableTableAdapter.ClearBeforeFill = true;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(560, 586);
            this.Controls.Add(this.label_current_state);
            this.Controls.Add(this.label3);
            this.Controls.Add(customer_nameLabel1);
            this.Controls.Add(this.customer_nameLabel2);
            this.Controls.Add(this.panel_new_cust);
            this.Controls.Add(label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add_new);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_cust_search);
            this.Controls.Add(this.customers_TableDataGridView);
            this.Controls.Add(this.customers_TableBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Customers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customers_TableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customers_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_entry_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customers_TableBindingNavigator)).EndInit();
            this.customers_TableBindingNavigator.ResumeLayout(false);
            this.customers_TableBindingNavigator.PerformLayout();
            this.panel_new_cust.ResumeLayout(false);
            this.panel_new_cust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returns_TableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dataset.add_entry_ds add_entry_ds;
        private System.Windows.Forms.BindingSource customers_TableBindingSource;
        private Dataset.add_entry_dsTableAdapters.Customers_TableTableAdapter customers_TableTableAdapter;
        private Dataset.add_entry_dsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView customers_TableDataGridView;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingNavigator customers_TableBindingNavigator;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox txt_cust_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_add_new;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox customer_nameTextBox;
        private System.Windows.Forms.Panel panel_new_cust;
        private System.Windows.Forms.Label customer_nameLabel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_current_state;
        private System.Windows.Forms.BindingSource returns_TableBindingSource;
        private Dataset.add_entry_dsTableAdapters.Returns_TableTableAdapter returns_TableTableAdapter;
    }
}