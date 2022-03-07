
namespace Nutrisnacks_Returns_Version_Two
{
    partial class main_form
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
            System.Windows.Forms.Label entry_IDLabel;
            System.Windows.Forms.Label from_Label;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.logged_in_user_label = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.btn_add_new = new System.Windows.Forms.Button();
            this.btn_users = new System.Windows.Forms.Button();
            this.btn_faults = new System.Windows.Forms.Button();
            this.btn_reps = new System.Windows.Forms.Button();
            this.btn_products = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            this.returns_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returns_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.current_record_ds = new Nutrisnacks_Returns_Version_Two.Dataset.current_record_ds();
            this.entry_IDLabel1 = new System.Windows.Forms.Label();
            this.from_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.to_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.origin_date_combobox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_current_role = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_cust_or_prod_name = new System.Windows.Forms.TextBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.btn_export_to_trend_analysis = new System.Windows.Forms.Button();
            this.basic_ViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basic_ViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stiReport2 = new Stimulsoft.Report.StiReport();
            this.stiReport3 = new Stimulsoft.Report.StiReport();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_load_all = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_not_returned = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.returns_TableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.btn_prepare_trend_analysis = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.checkBox_no_date = new System.Windows.Forms.CheckBox();
            this.label_Doc_date = new System.Windows.Forms.Label();
            this.returns_TableTableAdapter = new Nutrisnacks_Returns_Version_Two.Dataset.current_record_dsTableAdapters.Returns_TableTableAdapter();
            this.tableAdapterManager = new Nutrisnacks_Returns_Version_Two.Dataset.current_record_dsTableAdapters.TableAdapterManager();
            this.basic_ViewTableAdapter = new Nutrisnacks_Returns_Version_Two.Dataset.current_record_dsTableAdapters.Basic_ViewTableAdapter();
            this.summaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.summaryTableAdapter = new Nutrisnacks_Returns_Version_Two.Dataset.current_record_dsTableAdapters.SummaryTableAdapter();
            this.buttonTest = new System.Windows.Forms.Button();
            this.labelTest = new System.Windows.Forms.Label();
            entry_IDLabel = new System.Windows.Forms.Label();
            from_Label = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returns_TableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returns_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.current_record_ds)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basic_ViewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basic_ViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returns_TableBindingNavigator)).BeginInit();
            this.returns_TableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.summaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // entry_IDLabel
            // 
            entry_IDLabel.AutoSize = true;
            entry_IDLabel.Location = new System.Drawing.Point(1450, 12);
            entry_IDLabel.Name = "entry_IDLabel";
            entry_IDLabel.Size = new System.Drawing.Size(52, 15);
            entry_IDLabel.TabIndex = 3;
            entry_IDLabel.Text = "Entry ID:";
            // 
            // from_Label
            // 
            from_Label.AutoSize = true;
            from_Label.Location = new System.Drawing.Point(592, 91);
            from_Label.Name = "from_Label";
            from_Label.Size = new System.Drawing.Size(39, 15);
            from_Label.TabIndex = 41;
            from_Label.Text = "From:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(847, 91);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(24, 15);
            label1.TabIndex = 43;
            label1.Text = "To:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(21, 11);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 15);
            label2.TabIndex = 44;
            label2.Text = "Welcome";
            // 
            // logged_in_user_label
            // 
            this.logged_in_user_label.AutoSize = true;
            this.logged_in_user_label.Location = new System.Drawing.Point(25, 27);
            this.logged_in_user_label.Name = "logged_in_user_label";
            this.logged_in_user_label.Size = new System.Drawing.Size(16, 15);
            this.logged_in_user_label.TabIndex = 45;
            this.logged_in_user_label.Text = "...";
            this.logged_in_user_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_main
            // 
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_main.Controls.Add(this.btn_add_new);
            this.panel_main.Controls.Add(this.btn_users);
            this.panel_main.Controls.Add(this.btn_faults);
            this.panel_main.Controls.Add(this.btn_reps);
            this.panel_main.Controls.Add(this.btn_products);
            this.panel_main.Controls.Add(this.btn_customers);
            this.panel_main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_main.Location = new System.Drawing.Point(109, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1069, 70);
            this.panel_main.TabIndex = 0;
            // 
            // btn_add_new
            // 
            this.btn_add_new.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_new.Image = global::Nutrisnacks_Returns_Version_Two.Properties.Resources.add_img;
            this.btn_add_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_new.Location = new System.Drawing.Point(855, 11);
            this.btn_add_new.Name = "btn_add_new";
            this.btn_add_new.Size = new System.Drawing.Size(119, 45);
            this.btn_add_new.TabIndex = 38;
            this.btn_add_new.Text = "&Add New/Edit...";
            this.btn_add_new.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add_new.UseVisualStyleBackColor = true;
            this.btn_add_new.Click += new System.EventHandler(this.btn_add_new_Click_1);
            // 
            // btn_users
            // 
            this.btn_users.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.Image = global::Nutrisnacks_Returns_Version_Two.Properties.Resources.users_img;
            this.btn_users.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_users.Location = new System.Drawing.Point(980, 11);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(75, 45);
            this.btn_users.TabIndex = 37;
            this.btn_users.Text = "&Users";
            this.btn_users.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_users.UseVisualStyleBackColor = true;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // btn_faults
            // 
            this.btn_faults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_faults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_faults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_faults.Image = global::Nutrisnacks_Returns_Version_Two.Properties.Resources._381599_error_icon;
            this.btn_faults.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_faults.Location = new System.Drawing.Point(311, 11);
            this.btn_faults.Name = "btn_faults";
            this.btn_faults.Size = new System.Drawing.Size(81, 45);
            this.btn_faults.TabIndex = 36;
            this.btn_faults.Text = "&Faults";
            this.btn_faults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_faults.UseVisualStyleBackColor = true;
            this.btn_faults.Click += new System.EventHandler(this.btn_faults_Click);
            // 
            // btn_reps
            // 
            this.btn_reps.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_reps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reps.Image = global::Nutrisnacks_Returns_Version_Two.Properties.Resources.employees_new;
            this.btn_reps.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reps.Location = new System.Drawing.Point(226, 11);
            this.btn_reps.Name = "btn_reps";
            this.btn_reps.Size = new System.Drawing.Size(79, 45);
            this.btn_reps.TabIndex = 35;
            this.btn_reps.Text = "&Reps";
            this.btn_reps.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reps.UseVisualStyleBackColor = true;
            this.btn_reps.Click += new System.EventHandler(this.btn_reps_Click);
            // 
            // btn_products
            // 
            this.btn_products.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products.Image = global::Nutrisnacks_Returns_Version_Two.Properties.Resources.ic_shopping;
            this.btn_products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_products.Location = new System.Drawing.Point(121, 11);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(99, 45);
            this.btn_products.TabIndex = 34;
            this.btn_products.Text = "&Products";
            this.btn_products.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_products.UseVisualStyleBackColor = true;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_customers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customers.Image = global::Nutrisnacks_Returns_Version_Two.Properties.Resources._3209291_contacts_customers_family_group_team_icon;
            this.btn_customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customers.Location = new System.Drawing.Point(6, 11);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(109, 45);
            this.btn_customers.TabIndex = 33;
            this.btn_customers.Text = "&Customers";
            this.btn_customers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_customers.UseVisualStyleBackColor = true;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // returns_TableDataGridView
            // 
            this.returns_TableDataGridView.AllowUserToAddRows = false;
            this.returns_TableDataGridView.AllowUserToDeleteRows = false;
            this.returns_TableDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.returns_TableDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.returns_TableDataGridView.AutoGenerateColumns = false;
            this.returns_TableDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.returns_TableDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.returns_TableDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.returns_TableDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.returns_TableDataGridView.ColumnHeadersHeight = 40;
            this.returns_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.returns_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.returns_TableDataGridView.DataSource = this.returns_TableBindingSource;
            this.returns_TableDataGridView.EnableHeadersVisualStyles = false;
            this.returns_TableDataGridView.Location = new System.Drawing.Point(7, 124);
            this.returns_TableDataGridView.MultiSelect = false;
            this.returns_TableDataGridView.Name = "returns_TableDataGridView";
            this.returns_TableDataGridView.ReadOnly = true;
            this.returns_TableDataGridView.RowHeadersVisible = false;
            this.returns_TableDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.returns_TableDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.returns_TableDataGridView.RowTemplate.Height = 35;
            this.returns_TableDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.returns_TableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.returns_TableDataGridView.Size = new System.Drawing.Size(1166, 439);
            this.returns_TableDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Doc_Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Doc. Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Customer_Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Product_Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Product_Qty";
            this.dataGridViewTextBoxColumn5.HeaderText = "QTY";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Batch_Date";
            this.dataGridViewTextBoxColumn7.HeaderText = "Batch Date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "User_Rep";
            this.dataGridViewTextBoxColumn8.HeaderText = "User / Rep";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Fault_Description";
            this.dataGridViewTextBoxColumn9.HeaderText = "Fault Description";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Loyverse_Pastel_Doc_Number";
            this.dataGridViewTextBoxColumn10.HeaderText = "Doc. Number";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Qty_Returned";
            this.dataGridViewTextBoxColumn11.HeaderText = "QTY Returned";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // returns_TableBindingSource
            // 
            this.returns_TableBindingSource.DataMember = "Returns_Table";
            this.returns_TableBindingSource.DataSource = this.current_record_ds;
            // 
            // current_record_ds
            // 
            this.current_record_ds.DataSetName = "current_record_ds";
            this.current_record_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entry_IDLabel1
            // 
            this.entry_IDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returns_TableBindingSource, "Entry_ID", true));
            this.entry_IDLabel1.Location = new System.Drawing.Point(1338, 12);
            this.entry_IDLabel1.Name = "entry_IDLabel1";
            this.entry_IDLabel1.Size = new System.Drawing.Size(100, 23);
            this.entry_IDLabel1.TabIndex = 4;
            this.entry_IDLabel1.Text = "label1";
            // 
            // from_dateTimePicker
            // 
            this.from_dateTimePicker.Location = new System.Drawing.Point(637, 89);
            this.from_dateTimePicker.Name = "from_dateTimePicker";
            this.from_dateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.from_dateTimePicker.TabIndex = 40;
            // 
            // to_dateTimePicker
            // 
            this.to_dateTimePicker.Location = new System.Drawing.Point(877, 89);
            this.to_dateTimePicker.Name = "to_dateTimePicker";
            this.to_dateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.to_dateTimePicker.TabIndex = 42;
            // 
            // origin_date_combobox
            // 
            this.origin_date_combobox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.origin_date_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.origin_date_combobox.FormattingEnabled = true;
            this.origin_date_combobox.Items.AddRange(new object[] {
            "Document Date",
            "Batch Date"});
            this.origin_date_combobox.Location = new System.Drawing.Point(313, 88);
            this.origin_date_combobox.Name = "origin_date_combobox";
            this.origin_date_combobox.Size = new System.Drawing.Size(129, 23);
            this.origin_date_combobox.TabIndex = 45;
            this.origin_date_combobox.SelectedIndexChanged += new System.EventHandler(this.origin_date_combobox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label_current_role);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.logged_in_user_label);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 70);
            this.panel1.TabIndex = 46;
            // 
            // label_current_role
            // 
            this.label_current_role.AutoSize = true;
            this.label_current_role.Location = new System.Drawing.Point(27, 48);
            this.label_current_role.Name = "label_current_role";
            this.label_current_role.Size = new System.Drawing.Size(11, 15);
            this.label_current_role.TabIndex = 48;
            this.label_current_role.Text = "-";
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Image = global::Nutrisnacks_Returns_Version_Two.Properties.Resources.search_img;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(1236, 81);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(76, 35);
            this.btn_search.TabIndex = 39;
            this.btn_search.Text = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_cust_or_prod_name
            // 
            this.txt_cust_or_prod_name.Location = new System.Drawing.Point(75, 89);
            this.txt_cust_or_prod_name.Name = "txt_cust_or_prod_name";
            this.txt_cust_or_prod_name.Size = new System.Drawing.Size(232, 21);
            this.txt_cust_or_prod_name.TabIndex = 47;
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(1060, 571);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(113, 35);
            this.btn_export.TabIndex = 48;
            this.btn_export.Text = "&Returns Register";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // stiReport1
            // 
            this.stiReport1.CookieContainer = null;
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.Key = "cfb001767de34180a0cae9819ba9d19e";
            this.stiReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport1.ReportAlias = "Report";
            this.stiReport1.ReportGuid = "adf1111b325b4c75b9db5c8cac313a2b";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = null;
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.StoreImagesInResources = true;
            this.stiReport1.UseProgressInThread = false;
            // 
            // btn_export_to_trend_analysis
            // 
            this.btn_export_to_trend_analysis.Enabled = false;
            this.btn_export_to_trend_analysis.Location = new System.Drawing.Point(942, 571);
            this.btn_export_to_trend_analysis.Name = "btn_export_to_trend_analysis";
            this.btn_export_to_trend_analysis.Size = new System.Drawing.Size(113, 35);
            this.btn_export_to_trend_analysis.TabIndex = 49;
            this.btn_export_to_trend_analysis.Text = "&Trend Analysis";
            this.btn_export_to_trend_analysis.UseVisualStyleBackColor = true;
            this.btn_export_to_trend_analysis.Click += new System.EventHandler(this.btn_export_to_trend_analysis_Click);
            // 
            // basic_ViewDataGridView
            // 
            this.basic_ViewDataGridView.AllowUserToAddRows = false;
            this.basic_ViewDataGridView.AllowUserToDeleteRows = false;
            this.basic_ViewDataGridView.AutoGenerateColumns = false;
            this.basic_ViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.basic_ViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27});
            this.basic_ViewDataGridView.DataSource = this.basic_ViewBindingSource;
            this.basic_ViewDataGridView.Enabled = false;
            this.basic_ViewDataGridView.Location = new System.Drawing.Point(1332, 38);
            this.basic_ViewDataGridView.Name = "basic_ViewDataGridView";
            this.basic_ViewDataGridView.ReadOnly = true;
            this.basic_ViewDataGridView.Size = new System.Drawing.Size(161, 53);
            this.basic_ViewDataGridView.TabIndex = 49;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Doc_Date";
            this.dataGridViewTextBoxColumn1.HeaderText = "Doc_Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Entry_Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Entry_Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Product_Name";
            this.dataGridViewTextBoxColumn12.HeaderText = "Product_Name";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Product_Qty";
            this.dataGridViewTextBoxColumn13.HeaderText = "Product_Qty";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Customer_name";
            this.dataGridViewTextBoxColumn14.HeaderText = "Customer_name";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Rep_Name";
            this.dataGridViewTextBoxColumn15.HeaderText = "Rep_Name";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Fault_Name";
            this.dataGridViewTextBoxColumn16.HeaderText = "Fault_Name";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Batch_Date";
            this.dataGridViewTextBoxColumn17.HeaderText = "Batch_Date";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Loyverse_Pastel_Doc_Number";
            this.dataGridViewTextBoxColumn18.HeaderText = "Loyverse_Pastel_Doc_Number";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Qty_Returned";
            this.dataGridViewTextBoxColumn19.HeaderText = "Qty_Returned";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Investigate_Resolved";
            this.dataGridViewTextBoxColumn20.HeaderText = "Investigate_Resolved";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Manager";
            this.dataGridViewTextBoxColumn21.HeaderText = "Manager";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn22.HeaderText = "Comment";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Product_Category";
            this.dataGridViewTextBoxColumn23.HeaderText = "Product_Category";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Product_Price_Ex_Vat";
            this.dataGridViewTextBoxColumn24.HeaderText = "Product_Price_Ex_Vat";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Product_Price_Inc_Vat";
            this.dataGridViewTextBoxColumn25.HeaderText = "Product_Price_Inc_Vat";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Product_Vat";
            this.dataGridViewTextBoxColumn26.HeaderText = "Product_Vat";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Vat_Percentage";
            this.dataGridViewTextBoxColumn27.HeaderText = "Vat_Percentage";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            // 
            // basic_ViewBindingSource
            // 
            this.basic_ViewBindingSource.DataMember = "Basic_View";
            this.basic_ViewBindingSource.DataSource = this.current_record_ds;
            // 
            // stiReport2
            // 
            this.stiReport2.CookieContainer = null;
            this.stiReport2.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport2.Key = "068a181f021c4e8782bbb57643594d21";
            this.stiReport2.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport2.ReportAlias = "Report";
            this.stiReport2.ReportGuid = "9618a584a12543748917deeb8376f4ab";
            this.stiReport2.ReportName = "Report";
            this.stiReport2.ReportSource = null;
            this.stiReport2.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.stiReport2.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport2.StoreImagesInResources = true;
            this.stiReport2.UseProgressInThread = false;
            // 
            // stiReport3
            // 
            this.stiReport3.CookieContainer = null;
            this.stiReport3.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport3.Key = "b543ef0579404af888aa9e0ec43c73cb";
            this.stiReport3.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport3.ReportAlias = "Report";
            this.stiReport3.ReportGuid = "6345bc87045243a8b45bb3576263e999";
            this.stiReport3.ReportName = "Report";
            this.stiReport3.ReportSource = null;
            this.stiReport3.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.stiReport3.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport3.StoreImagesInResources = true;
            this.stiReport3.UseProgressInThread = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 38);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 38);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 41);
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 38);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 38);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 38);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 41);
            // 
            // btn_load_all
            // 
            this.btn_load_all.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_load_all.Image = ((System.Drawing.Image)(resources.GetObject("btn_load_all.Image")));
            this.btn_load_all.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_load_all.Name = "btn_load_all";
            this.btn_load_all.Size = new System.Drawing.Size(54, 38);
            this.btn_load_all.Text = "Load All";
            this.btn_load_all.Click += new System.EventHandler(this.btn_load_all_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // btn_not_returned
            // 
            this.btn_not_returned.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_not_returned.Image = ((System.Drawing.Image)(resources.GetObject("btn_not_returned.Image")));
            this.btn_not_returned.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_not_returned.Name = "btn_not_returned";
            this.btn_not_returned.Size = new System.Drawing.Size(149, 38);
            this.btn_not_returned.Text = "Load Outstanding Returns";
            this.btn_not_returned.Click += new System.EventHandler(this.btn_not_returned_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 41);
            // 
            // returns_TableBindingNavigator
            // 
            this.returns_TableBindingNavigator.AddNewItem = null;
            this.returns_TableBindingNavigator.AutoSize = false;
            this.returns_TableBindingNavigator.BindingSource = this.returns_TableBindingSource;
            this.returns_TableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.returns_TableBindingNavigator.DeleteItem = null;
            this.returns_TableBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.returns_TableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btn_load_all,
            this.toolStripSeparator1,
            this.btn_not_returned,
            this.toolStripSeparator2,
            this.btn_prepare_trend_analysis,
            this.toolStripSeparator3});
            this.returns_TableBindingNavigator.Location = new System.Drawing.Point(0, 568);
            this.returns_TableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.returns_TableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.returns_TableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.returns_TableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.returns_TableBindingNavigator.Name = "returns_TableBindingNavigator";
            this.returns_TableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.returns_TableBindingNavigator.Size = new System.Drawing.Size(1472, 41);
            this.returns_TableBindingNavigator.TabIndex = 1;
            this.returns_TableBindingNavigator.Text = "bindingNavigator1";
            // 
            // btn_prepare_trend_analysis
            // 
            this.btn_prepare_trend_analysis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_prepare_trend_analysis.Image = ((System.Drawing.Image)(resources.GetObject("btn_prepare_trend_analysis.Image")));
            this.btn_prepare_trend_analysis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_prepare_trend_analysis.Name = "btn_prepare_trend_analysis";
            this.btn_prepare_trend_analysis.Size = new System.Drawing.Size(129, 38);
            this.btn_prepare_trend_analysis.Text = "Prepare Trend Analysis";
            this.btn_prepare_trend_analysis.Click += new System.EventHandler(this.btn_prepare_trend_analysis_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 41);
            // 
            // checkBox_no_date
            // 
            this.checkBox_no_date.AutoSize = true;
            this.checkBox_no_date.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_no_date.Location = new System.Drawing.Point(450, 91);
            this.checkBox_no_date.Name = "checkBox_no_date";
            this.checkBox_no_date.Size = new System.Drawing.Size(71, 19);
            this.checkBox_no_date.TabIndex = 50;
            this.checkBox_no_date.Text = "No Date";
            this.checkBox_no_date.UseVisualStyleBackColor = true;
            this.checkBox_no_date.Visible = false;
            this.checkBox_no_date.CheckedChanged += new System.EventHandler(this.checkBox_no_date_CheckedChanged);
            // 
            // label_Doc_date
            // 
            this.label_Doc_date.AutoSize = true;
            this.label_Doc_date.Location = new System.Drawing.Point(531, 91);
            this.label_Doc_date.Name = "label_Doc_date";
            this.label_Doc_date.Size = new System.Drawing.Size(65, 15);
            this.label_Doc_date.TabIndex = 51;
            this.label_Doc_date.Text = "Doc Date -";
            this.label_Doc_date.Visible = false;
            // 
            // returns_TableTableAdapter
            // 
            this.returns_TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Returns_TableTableAdapter = this.returns_TableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Nutrisnacks_Returns_Version_Two.Dataset.current_record_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // basic_ViewTableAdapter
            // 
            this.basic_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // summaryBindingSource
            // 
            this.summaryBindingSource.DataMember = "Summary";
            this.summaryBindingSource.DataSource = this.current_record_ds;
            // 
            // summaryTableAdapter
            // 
            this.summaryTableAdapter.ClearBeforeFill = true;
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(1212, 189);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 52;
            this.buttonTest.Text = "buttonTest";
            this.buttonTest.UseVisualStyleBackColor = true;
            //this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(1220, 215);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(57, 15);
            this.labelTest.TabIndex = 53;
            this.labelTest.Text = "labelTest";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1472, 609);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.label_Doc_date);
            this.Controls.Add(this.checkBox_no_date);
            this.Controls.Add(this.basic_ViewDataGridView);
            this.Controls.Add(this.btn_export_to_trend_analysis);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.txt_cust_or_prod_name);
            this.Controls.Add(this.origin_date_combobox);
            this.Controls.Add(label1);
            this.Controls.Add(this.to_dateTimePicker);
            this.Controls.Add(from_Label);
            this.Controls.Add(this.from_dateTimePicker);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(entry_IDLabel);
            this.Controls.Add(this.entry_IDLabel1);
            this.Controls.Add(this.returns_TableDataGridView);
            this.Controls.Add(this.returns_TableBindingNavigator);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nutrisnacks Returns";
            this.Load += new System.EventHandler(this.main_form_Load);
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.returns_TableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returns_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.current_record_ds)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basic_ViewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basic_ViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returns_TableBindingNavigator)).EndInit();
            this.returns_TableBindingNavigator.ResumeLayout(false);
            this.returns_TableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.summaryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private Dataset.current_record_ds current_record_ds;
        private System.Windows.Forms.BindingSource returns_TableBindingSource;
        private Dataset.current_record_dsTableAdapters.Returns_TableTableAdapter returns_TableTableAdapter;
        private Dataset.current_record_dsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView returns_TableDataGridView;
        public System.Windows.Forms.Label entry_IDLabel1;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.Button btn_users;
        private System.Windows.Forms.Button btn_faults;
        private System.Windows.Forms.Button btn_reps;
        private System.Windows.Forms.Button btn_products;
        private System.Windows.Forms.Button btn_add_new;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DateTimePicker from_dateTimePicker;
        private System.Windows.Forms.DateTimePicker to_dateTimePicker;
        public System.Windows.Forms.Label logged_in_user_label;
        private System.Windows.Forms.ComboBox origin_date_combobox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_current_role;
        private System.Windows.Forms.TextBox txt_cust_or_prod_name;
        private System.Windows.Forms.Button btn_export;
        private Stimulsoft.Report.StiReport stiReport1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button btn_export_to_trend_analysis;
        private System.Windows.Forms.BindingSource basic_ViewBindingSource;
        private Dataset.current_record_dsTableAdapters.Basic_ViewTableAdapter basic_ViewTableAdapter;
        private System.Windows.Forms.DataGridView basic_ViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private Stimulsoft.Report.StiReport stiReport2;
        private Stimulsoft.Report.StiReport stiReport3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btn_load_all;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_not_returned;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.BindingNavigator returns_TableBindingNavigator;
        private System.Windows.Forms.BindingSource summaryBindingSource;
        private Dataset.current_record_dsTableAdapters.SummaryTableAdapter summaryTableAdapter;
        private System.Windows.Forms.CheckBox checkBox_no_date;
        private System.Windows.Forms.Label label_Doc_date;
        private System.Windows.Forms.ToolStripButton btn_prepare_trend_analysis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Label labelTest;
    }
}