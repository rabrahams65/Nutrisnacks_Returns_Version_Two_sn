
namespace Nutrisnacks_Returns_Version_Two.Child_Forms
{
    partial class Reps
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
            System.Windows.Forms.Label rep_nameLabel;
            System.Windows.Forms.Label rep_NameLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reps));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.reps_TableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.reps_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add_entry_ds = new Nutrisnacks_Returns_Version_Two.Dataset.add_entry_ds();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.reps_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.repNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_new_rep = new System.Windows.Forms.Panel();
            this.rep_nameTextBox = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add_new = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_rep_search = new System.Windows.Forms.TextBox();
            this.reps_TableTableAdapter = new Nutrisnacks_Returns_Version_Two.Dataset.add_entry_dsTableAdapters.Reps_TableTableAdapter();
            this.tableAdapterManager = new Nutrisnacks_Returns_Version_Two.Dataset.add_entry_dsTableAdapters.TableAdapterManager();
            this.label_current_state = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rep_NameLabel2 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            rep_nameLabel = new System.Windows.Forms.Label();
            rep_NameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reps_TableBindingNavigator)).BeginInit();
            this.reps_TableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reps_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_entry_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reps_TableDataGridView)).BeginInit();
            this.panel_new_rep.SuspendLayout();
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
            // rep_nameLabel
            // 
            rep_nameLabel.AutoSize = true;
            rep_nameLabel.Location = new System.Drawing.Point(67, 15);
            rep_nameLabel.Name = "rep_nameLabel";
            rep_nameLabel.Size = new System.Drawing.Size(68, 15);
            rep_nameLabel.TabIndex = 2;
            rep_nameLabel.Text = "Rep name:";
            // 
            // rep_NameLabel1
            // 
            rep_NameLabel1.AutoSize = true;
            rep_NameLabel1.Location = new System.Drawing.Point(829, 144);
            rep_NameLabel1.Name = "rep_NameLabel1";
            rep_NameLabel1.Size = new System.Drawing.Size(70, 15);
            rep_NameLabel1.TabIndex = 52;
            rep_NameLabel1.Text = "Rep Name:";
            // 
            // reps_TableBindingNavigator
            // 
            this.reps_TableBindingNavigator.AddNewItem = null;
            this.reps_TableBindingNavigator.BindingSource = this.reps_TableBindingSource;
            this.reps_TableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.reps_TableBindingNavigator.DeleteItem = null;
            this.reps_TableBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reps_TableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.reps_TableBindingNavigator.Location = new System.Drawing.Point(0, 561);
            this.reps_TableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.reps_TableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.reps_TableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.reps_TableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.reps_TableBindingNavigator.Name = "reps_TableBindingNavigator";
            this.reps_TableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.reps_TableBindingNavigator.Size = new System.Drawing.Size(559, 25);
            this.reps_TableBindingNavigator.TabIndex = 0;
            this.reps_TableBindingNavigator.Text = "bindingNavigator1";
            // 
            // reps_TableBindingSource
            // 
            this.reps_TableBindingSource.DataMember = "Reps_Table";
            this.reps_TableBindingSource.DataSource = this.add_entry_ds;
            // 
            // add_entry_ds
            // 
            this.add_entry_ds.DataSetName = "add_entry_ds";
            this.add_entry_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // reps_TableDataGridView
            // 
            this.reps_TableDataGridView.AllowUserToAddRows = false;
            this.reps_TableDataGridView.AllowUserToDeleteRows = false;
            this.reps_TableDataGridView.AutoGenerateColumns = false;
            this.reps_TableDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reps_TableDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.reps_TableDataGridView.ColumnHeadersHeight = 30;
            this.reps_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.reps_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repNameDataGridViewTextBoxColumn});
            this.reps_TableDataGridView.DataSource = this.reps_TableBindingSource;
            this.reps_TableDataGridView.EnableHeadersVisualStyles = false;
            this.reps_TableDataGridView.Location = new System.Drawing.Point(12, 123);
            this.reps_TableDataGridView.Name = "reps_TableDataGridView";
            this.reps_TableDataGridView.ReadOnly = true;
            this.reps_TableDataGridView.RowHeadersVisible = false;
            this.reps_TableDataGridView.RowHeadersWidth = 120;
            this.reps_TableDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.reps_TableDataGridView.RowTemplate.Height = 44;
            this.reps_TableDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reps_TableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reps_TableDataGridView.Size = new System.Drawing.Size(532, 418);
            this.reps_TableDataGridView.TabIndex = 2;
            // 
            // repNameDataGridViewTextBoxColumn
            // 
            this.repNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.repNameDataGridViewTextBoxColumn.DataPropertyName = "Rep_Name";
            this.repNameDataGridViewTextBoxColumn.HeaderText = "Rep Name";
            this.repNameDataGridViewTextBoxColumn.Name = "repNameDataGridViewTextBoxColumn";
            this.repNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel_new_rep
            // 
            this.panel_new_rep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_new_rep.Controls.Add(label2);
            this.panel_new_rep.Controls.Add(this.rep_nameTextBox);
            this.panel_new_rep.Controls.Add(rep_nameLabel);
            this.panel_new_rep.Location = new System.Drawing.Point(12, 57);
            this.panel_new_rep.Name = "panel_new_rep";
            this.panel_new_rep.Size = new System.Drawing.Size(532, 71);
            this.panel_new_rep.TabIndex = 50;
            this.panel_new_rep.Visible = false;
            // 
            // rep_nameTextBox
            // 
            this.rep_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reps_TableBindingSource, "Rep_Name", true));
            this.rep_nameTextBox.Location = new System.Drawing.Point(141, 12);
            this.rep_nameTextBox.Name = "rep_nameTextBox";
            this.rep_nameTextBox.Size = new System.Drawing.Size(356, 21);
            this.rep_nameTextBox.TabIndex = 5;
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
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
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
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
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
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
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
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
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
            this.btn_add_new.Click += new System.EventHandler(this.btn_add_new_Click);
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
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_rep_search
            // 
            this.txt_rep_search.Location = new System.Drawing.Point(12, 87);
            this.txt_rep_search.Name = "txt_rep_search";
            this.txt_rep_search.Size = new System.Drawing.Size(420, 21);
            this.txt_rep_search.TabIndex = 43;
            this.txt_rep_search.TextChanged += new System.EventHandler(this.txt_rep_search_TextChanged);
            // 
            // reps_TableTableAdapter
            // 
            this.reps_TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Categories_TableTableAdapter = null;
            this.tableAdapterManager.Customers_TableTableAdapter = null;
            this.tableAdapterManager.Faults_TableTableAdapter = null;
            this.tableAdapterManager.Product_TableTableAdapter = null;
            this.tableAdapterManager.Reps_TableTableAdapter = this.reps_TableTableAdapter;
            this.tableAdapterManager.Returns_TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Nutrisnacks_Returns_Version_Two.Dataset.add_entry_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Users_TableTableAdapter = null;
            // 
            // label_current_state
            // 
            this.label_current_state.AutoSize = true;
            this.label_current_state.Location = new System.Drawing.Point(911, 102);
            this.label_current_state.Name = "label_current_state";
            this.label_current_state.Size = new System.Drawing.Size(23, 15);
            this.label_current_state.TabIndex = 52;
            this.label_current_state.Text = "----";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(829, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 51;
            this.label3.Text = "Current state";
            // 
            // rep_NameLabel2
            // 
            this.rep_NameLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reps_TableBindingSource, "Rep_Name", true));
            this.rep_NameLabel2.Location = new System.Drawing.Point(905, 144);
            this.rep_NameLabel2.Name = "rep_NameLabel2";
            this.rep_NameLabel2.Size = new System.Drawing.Size(100, 23);
            this.rep_NameLabel2.TabIndex = 53;
            this.rep_NameLabel2.Text = "label1";
            // 
            // Reps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 586);
            this.Controls.Add(rep_NameLabel1);
            this.Controls.Add(this.rep_NameLabel2);
            this.Controls.Add(this.label_current_state);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel_new_rep);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add_new);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_rep_search);
            this.Controls.Add(this.reps_TableDataGridView);
            this.Controls.Add(this.reps_TableBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Reps";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reps";
            this.Load += new System.EventHandler(this.Reps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reps_TableBindingNavigator)).EndInit();
            this.reps_TableBindingNavigator.ResumeLayout(false);
            this.reps_TableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reps_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_entry_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reps_TableDataGridView)).EndInit();
            this.panel_new_rep.ResumeLayout(false);
            this.panel_new_rep.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dataset.add_entry_ds add_entry_ds;
        private System.Windows.Forms.BindingSource reps_TableBindingSource;
        private Dataset.add_entry_dsTableAdapters.Reps_TableTableAdapter reps_TableTableAdapter;
        private Dataset.add_entry_dsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator reps_TableBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView reps_TableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn repNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel_new_rep;
        private System.Windows.Forms.TextBox rep_nameTextBox;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add_new;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_rep_search;
        private System.Windows.Forms.Label label_current_state;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rep_NameLabel2;
    }
}