
namespace Nutrisnacks_Returns_Version_Two.Child_Forms
{
    partial class Faults
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
            System.Windows.Forms.Label faults_nameLabel;
            System.Windows.Forms.Label fault_NameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faults));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.add_entry_ds = new Nutrisnacks_Returns_Version_Two.Dataset.add_entry_ds();
            this.faults_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faults_TableTableAdapter = new Nutrisnacks_Returns_Version_Two.Dataset.add_entry_dsTableAdapters.Faults_TableTableAdapter();
            this.tableAdapterManager = new Nutrisnacks_Returns_Version_Two.Dataset.add_entry_dsTableAdapters.TableAdapterManager();
            this.faults_TableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.faults_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.faultNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_new_fault = new System.Windows.Forms.Panel();
            this.fault_nameTextBox = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add_new = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_fault_search = new System.Windows.Forms.TextBox();
            this.fault_NameLabel1 = new System.Windows.Forms.Label();
            this.label_current_state = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            faults_nameLabel = new System.Windows.Forms.Label();
            fault_NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.add_entry_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faults_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faults_TableBindingNavigator)).BeginInit();
            this.faults_TableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faults_TableDataGridView)).BeginInit();
            this.panel_new_fault.SuspendLayout();
            this.SuspendLayout();
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
            // faults_nameLabel
            // 
            faults_nameLabel.AutoSize = true;
            faults_nameLabel.Location = new System.Drawing.Point(63, 15);
            faults_nameLabel.Name = "faults_nameLabel";
            faults_nameLabel.Size = new System.Drawing.Size(72, 15);
            faults_nameLabel.TabIndex = 2;
            faults_nameLabel.Text = "Fault name:";
            // 
            // fault_NameLabel
            // 
            fault_NameLabel.AutoSize = true;
            fault_NameLabel.Location = new System.Drawing.Point(806, 147);
            fault_NameLabel.Name = "fault_NameLabel";
            fault_NameLabel.Size = new System.Drawing.Size(74, 15);
            fault_NameLabel.TabIndex = 58;
            fault_NameLabel.Text = "Fault Name:";
            // 
            // add_entry_ds
            // 
            this.add_entry_ds.DataSetName = "add_entry_ds";
            this.add_entry_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // faults_TableBindingSource
            // 
            this.faults_TableBindingSource.DataMember = "Faults_Table";
            this.faults_TableBindingSource.DataSource = this.add_entry_ds;
            // 
            // faults_TableTableAdapter
            // 
            this.faults_TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Categories_TableTableAdapter = null;
            this.tableAdapterManager.Customers_TableTableAdapter = null;
            this.tableAdapterManager.Faults_TableTableAdapter = this.faults_TableTableAdapter;
            this.tableAdapterManager.Product_TableTableAdapter = null;
            this.tableAdapterManager.Reps_TableTableAdapter = null;
            this.tableAdapterManager.Returns_TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Nutrisnacks_Returns_Version_Two.Dataset.add_entry_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Users_TableTableAdapter = null;
            // 
            // faults_TableBindingNavigator
            // 
            this.faults_TableBindingNavigator.AddNewItem = null;
            this.faults_TableBindingNavigator.BindingSource = this.faults_TableBindingSource;
            this.faults_TableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.faults_TableBindingNavigator.DeleteItem = null;
            this.faults_TableBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.faults_TableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.faults_TableBindingNavigator.Location = new System.Drawing.Point(0, 561);
            this.faults_TableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.faults_TableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.faults_TableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.faults_TableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.faults_TableBindingNavigator.Name = "faults_TableBindingNavigator";
            this.faults_TableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.faults_TableBindingNavigator.Size = new System.Drawing.Size(560, 25);
            this.faults_TableBindingNavigator.TabIndex = 0;
            this.faults_TableBindingNavigator.Text = "bindingNavigator1";
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
            // faults_TableDataGridView
            // 
            this.faults_TableDataGridView.AllowUserToAddRows = false;
            this.faults_TableDataGridView.AllowUserToDeleteRows = false;
            this.faults_TableDataGridView.AutoGenerateColumns = false;
            this.faults_TableDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.faults_TableDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.faults_TableDataGridView.ColumnHeadersHeight = 30;
            this.faults_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.faults_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.faultNameDataGridViewTextBoxColumn});
            this.faults_TableDataGridView.DataSource = this.faults_TableBindingSource;
            this.faults_TableDataGridView.EnableHeadersVisualStyles = false;
            this.faults_TableDataGridView.Location = new System.Drawing.Point(12, 123);
            this.faults_TableDataGridView.Name = "faults_TableDataGridView";
            this.faults_TableDataGridView.ReadOnly = true;
            this.faults_TableDataGridView.RowHeadersVisible = false;
            this.faults_TableDataGridView.RowHeadersWidth = 120;
            this.faults_TableDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.faults_TableDataGridView.RowTemplate.Height = 44;
            this.faults_TableDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.faults_TableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.faults_TableDataGridView.Size = new System.Drawing.Size(532, 418);
            this.faults_TableDataGridView.TabIndex = 3;
            // 
            // faultNameDataGridViewTextBoxColumn
            // 
            this.faultNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.faultNameDataGridViewTextBoxColumn.DataPropertyName = "Fault_Name";
            this.faultNameDataGridViewTextBoxColumn.HeaderText = "Fault Name";
            this.faultNameDataGridViewTextBoxColumn.Name = "faultNameDataGridViewTextBoxColumn";
            this.faultNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.faultNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel_new_fault
            // 
            this.panel_new_fault.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_new_fault.Controls.Add(label2);
            this.panel_new_fault.Controls.Add(this.fault_nameTextBox);
            this.panel_new_fault.Controls.Add(faults_nameLabel);
            this.panel_new_fault.Location = new System.Drawing.Point(12, 54);
            this.panel_new_fault.Name = "panel_new_fault";
            this.panel_new_fault.Size = new System.Drawing.Size(532, 71);
            this.panel_new_fault.TabIndex = 58;
            this.panel_new_fault.Visible = false;
            // 
            // fault_nameTextBox
            // 
            this.fault_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.faults_TableBindingSource, "Fault_Name", true));
            this.fault_nameTextBox.Location = new System.Drawing.Point(141, 12);
            this.fault_nameTextBox.Name = "fault_nameTextBox";
            this.fault_nameTextBox.Size = new System.Drawing.Size(356, 21);
            this.fault_nameTextBox.TabIndex = 5;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Enabled = false;
            this.btn_cancel.Location = new System.Drawing.Point(437, 9);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(98, 39);
            this.btn_cancel.TabIndex = 57;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(333, 9);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(98, 39);
            this.btn_save.TabIndex = 56;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Location = new System.Drawing.Point(229, 9);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(98, 39);
            this.btn_delete.TabIndex = 55;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Location = new System.Drawing.Point(125, 9);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(98, 39);
            this.btn_edit.TabIndex = 54;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add_new
            // 
            this.btn_add_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_new.Location = new System.Drawing.Point(21, 9);
            this.btn_add_new.Name = "btn_add_new";
            this.btn_add_new.Size = new System.Drawing.Size(98, 39);
            this.btn_add_new.TabIndex = 53;
            this.btn_add_new.Text = "Add New";
            this.btn_add_new.UseVisualStyleBackColor = true;
            this.btn_add_new.Click += new System.EventHandler(this.btn_add_new_Click);
            // 
            // btn_search
            // 
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Location = new System.Drawing.Point(445, 75);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(98, 39);
            this.btn_search.TabIndex = 52;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_fault_search
            // 
            this.txt_fault_search.Location = new System.Drawing.Point(12, 84);
            this.txt_fault_search.Name = "txt_fault_search";
            this.txt_fault_search.Size = new System.Drawing.Size(419, 21);
            this.txt_fault_search.TabIndex = 51;
            this.txt_fault_search.TextChanged += new System.EventHandler(this.txt_fault_search_TextChanged);
            // 
            // fault_NameLabel1
            // 
            this.fault_NameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.faults_TableBindingSource, "Fault_Name", true));
            this.fault_NameLabel1.Location = new System.Drawing.Point(886, 147);
            this.fault_NameLabel1.Name = "fault_NameLabel1";
            this.fault_NameLabel1.Size = new System.Drawing.Size(100, 23);
            this.fault_NameLabel1.TabIndex = 59;
            this.fault_NameLabel1.Text = "label1";
            // 
            // label_current_state
            // 
            this.label_current_state.AutoSize = true;
            this.label_current_state.Location = new System.Drawing.Point(888, 110);
            this.label_current_state.Name = "label_current_state";
            this.label_current_state.Size = new System.Drawing.Size(23, 15);
            this.label_current_state.TabIndex = 61;
            this.label_current_state.Text = "----";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(806, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 60;
            this.label3.Text = "Current state";
            // 
            // Faults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 586);
            this.Controls.Add(this.label_current_state);
            this.Controls.Add(this.label3);
            this.Controls.Add(fault_NameLabel);
            this.Controls.Add(this.fault_NameLabel1);
            this.Controls.Add(this.panel_new_fault);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add_new);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_fault_search);
            this.Controls.Add(this.faults_TableDataGridView);
            this.Controls.Add(this.faults_TableBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Faults";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faults";
            this.Load += new System.EventHandler(this.Faults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.add_entry_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faults_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faults_TableBindingNavigator)).EndInit();
            this.faults_TableBindingNavigator.ResumeLayout(false);
            this.faults_TableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faults_TableDataGridView)).EndInit();
            this.panel_new_fault.ResumeLayout(false);
            this.panel_new_fault.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dataset.add_entry_ds add_entry_ds;
        private System.Windows.Forms.BindingSource faults_TableBindingSource;
        private Dataset.add_entry_dsTableAdapters.Faults_TableTableAdapter faults_TableTableAdapter;
        private Dataset.add_entry_dsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator faults_TableBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView faults_TableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn faultNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel_new_fault;
        private System.Windows.Forms.TextBox fault_nameTextBox;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add_new;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_fault_search;
        private System.Windows.Forms.Label fault_NameLabel1;
        private System.Windows.Forms.Label label_current_state;
        private System.Windows.Forms.Label label3;
    }
}