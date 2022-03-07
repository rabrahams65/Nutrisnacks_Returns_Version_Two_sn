
namespace Nutrisnacks_Returns_Version_Two
{
    partial class Form1
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
            System.Windows.Forms.Label doc_DateLabel;
            System.Windows.Forms.Label product_NameLabel;
            System.Windows.Forms.Label product_QtyLabel;
            System.Windows.Forms.Label customer_NameLabel;
            System.Windows.Forms.Label user_RepLabel;
            System.Windows.Forms.Label fault_DescriptionLabel;
            System.Windows.Forms.Label loyverse_Pastel_Doc_NumberLabel;
            System.Windows.Forms.Label qty_ReturnedLabel;
            System.Windows.Forms.Label investigate_ResolvedLabel;
            System.Windows.Forms.Label managerLabel;
            System.Windows.Forms.Label commentLabel;
            System.Windows.Forms.Label entry_DateLabel;
            System.Windows.Forms.Label manager_SignatureLabel;
            System.Windows.Forms.Label user_signatureLabel;
            System.Windows.Forms.Label fault_IdLabel;
            System.Windows.Forms.Label f_cust_idLabel;
            System.Windows.Forms.Label f_prod_idLabel;
            System.Windows.Forms.Label f_rep_idLabel;
            System.Windows.Forms.Label f_fault_idLabel;
            System.Windows.Forms.Label customer_IdLabel;
            System.Windows.Forms.Label product_IdLabel;
            System.Windows.Forms.Label rep_IdLabel;
            System.Windows.Forms.Label batch_DateLabel1;
            System.Windows.Forms.Label batch_DateLabel2;
            System.Windows.Forms.Label label1;
            this.current_record_ds = new Nutrisnacks_Returns_Version_Two.Dataset.current_record_ds();
            this.returns_TableTableAdapter = new Nutrisnacks_Returns_Version_Two.Dataset.current_record_dsTableAdapters.Returns_TableTableAdapter();
            this.returns_TableDataGridView = new System.Windows.Forms.DataGridView();
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
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returns_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entry_IDLabel1 = new System.Windows.Forms.Label();
            this.doc_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.product_NameComboBox = new System.Windows.Forms.ComboBox();
            this.productTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add_entry_ds = new Nutrisnacks_Returns_Version_Two.Dataset.add_entry_ds();
            this.product_QtyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.customer_NameComboBox = new System.Windows.Forms.ComboBox();
            this.customersTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_RepComboBox = new System.Windows.Forms.ComboBox();
            this.reps_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add_entry_ds1 = new Nutrisnacks_Returns_Version_Two.Dataset.add_entry_ds();
            this.fault_DescriptionComboBox = new System.Windows.Forms.ComboBox();
            this.faultsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loyverse_Pastel_Doc_NumberTextBox = new System.Windows.Forms.TextBox();
            this.qty_ReturnedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.investigate_ResolvedComboBox = new System.Windows.Forms.ComboBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.groupBox_info = new System.Windows.Forms.GroupBox();
            this.checkBox_show_batch_dt_picker = new System.Windows.Forms.CheckBox();
            this.panel_add_new_data = new System.Windows.Forms.Panel();
            this.btn_add_new_product = new System.Windows.Forms.Button();
            this.btn_add_new_fault_description = new System.Windows.Forms.Button();
            this.btn_add_new_rep = new System.Windows.Forms.Button();
            this.btn_add_new_customer = new System.Windows.Forms.Button();
            this.batch_DateTextBox = new System.Windows.Forms.TextBox();
            this.entry_DateLabel1 = new System.Windows.Forms.Label();
            this.btn_add_new = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.product_TableTableAdapter = new Nutrisnacks_Returns_Version_Two.Dataset.add_entry_dsTableAdapters.Product_TableTableAdapter();
            this.customers_TableTableAdapter = new Nutrisnacks_Returns_Version_Two.Dataset.add_entry_dsTableAdapters.Customers_TableTableAdapter();
            this.faults_TableTableAdapter = new Nutrisnacks_Returns_Version_Two.Dataset.add_entry_dsTableAdapters.Faults_TableTableAdapter();
            this.reps_TableTableAdapter = new Nutrisnacks_Returns_Version_Two.Dataset.add_entry_dsTableAdapters.Reps_TableTableAdapter();
            this.tableAdapterManager1 = new Nutrisnacks_Returns_Version_Two.Dataset.add_entry_dsTableAdapters.TableAdapterManager();
            this.customers_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_child_form = new System.Windows.Forms.Label();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.managerLabel1 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new Nutrisnacks_Returns_Version_Two.Dataset.current_record_dsTableAdapters.TableAdapterManager();
            this.manager_SignaturePictureBox = new System.Windows.Forms.PictureBox();
            this.users_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.users_TableTableAdapter = new Nutrisnacks_Returns_Version_Two.Dataset.add_entry_dsTableAdapters.Users_TableTableAdapter();
            this.user_signaturePictureBox = new System.Windows.Forms.PictureBox();
            this.users_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.f_fault_idTextBox = new System.Windows.Forms.TextBox();
            this.f_rep_idTextBox = new System.Windows.Forms.TextBox();
            this.f_prod_idTextBox = new System.Windows.Forms.TextBox();
            this.f_cust_idTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rep_IdLabel1 = new System.Windows.Forms.Label();
            this.fault_IdLabel1 = new System.Windows.Forms.Label();
            this.product_IdLabel1 = new System.Windows.Forms.Label();
            this.customer_IdLabel1 = new System.Windows.Forms.Label();
            this.product_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faults_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reps_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reps_TableDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.batch_DateLabel3 = new System.Windows.Forms.Label();
            this.label_current_state = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            entry_IDLabel = new System.Windows.Forms.Label();
            doc_DateLabel = new System.Windows.Forms.Label();
            product_NameLabel = new System.Windows.Forms.Label();
            product_QtyLabel = new System.Windows.Forms.Label();
            customer_NameLabel = new System.Windows.Forms.Label();
            user_RepLabel = new System.Windows.Forms.Label();
            fault_DescriptionLabel = new System.Windows.Forms.Label();
            loyverse_Pastel_Doc_NumberLabel = new System.Windows.Forms.Label();
            qty_ReturnedLabel = new System.Windows.Forms.Label();
            investigate_ResolvedLabel = new System.Windows.Forms.Label();
            managerLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            entry_DateLabel = new System.Windows.Forms.Label();
            manager_SignatureLabel = new System.Windows.Forms.Label();
            user_signatureLabel = new System.Windows.Forms.Label();
            fault_IdLabel = new System.Windows.Forms.Label();
            f_cust_idLabel = new System.Windows.Forms.Label();
            f_prod_idLabel = new System.Windows.Forms.Label();
            f_rep_idLabel = new System.Windows.Forms.Label();
            f_fault_idLabel = new System.Windows.Forms.Label();
            customer_IdLabel = new System.Windows.Forms.Label();
            product_IdLabel = new System.Windows.Forms.Label();
            rep_IdLabel = new System.Windows.Forms.Label();
            batch_DateLabel1 = new System.Windows.Forms.Label();
            batch_DateLabel2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.current_record_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returns_TableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returns_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_entry_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_QtyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reps_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_entry_ds1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty_ReturnedNumericUpDown)).BeginInit();
            this.groupBox_info.SuspendLayout();
            this.panel_add_new_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customers_TableDataGridView)).BeginInit();
            this.panel_footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manager_SignaturePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_signaturePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_TableDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_TableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faults_TableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reps_TableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reps_TableDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // entry_IDLabel
            // 
            entry_IDLabel.AutoSize = true;
            entry_IDLabel.Location = new System.Drawing.Point(218, 6);
            entry_IDLabel.Name = "entry_IDLabel";
            entry_IDLabel.Size = new System.Drawing.Size(37, 15);
            entry_IDLabel.TabIndex = 1;
            entry_IDLabel.Text = "Entry:";
            // 
            // doc_DateLabel
            // 
            doc_DateLabel.AutoSize = true;
            doc_DateLabel.Location = new System.Drawing.Point(142, 29);
            doc_DateLabel.Name = "doc_DateLabel";
            doc_DateLabel.Size = new System.Drawing.Size(61, 15);
            doc_DateLabel.TabIndex = 3;
            doc_DateLabel.Text = "Doc Date:";
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.Location = new System.Drawing.Point(114, 55);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(89, 15);
            product_NameLabel.TabIndex = 7;
            product_NameLabel.Text = "Product Name:";
            // 
            // product_QtyLabel
            // 
            product_QtyLabel.AutoSize = true;
            product_QtyLabel.Location = new System.Drawing.Point(134, 81);
            product_QtyLabel.Name = "product_QtyLabel";
            product_QtyLabel.Size = new System.Drawing.Size(69, 15);
            product_QtyLabel.TabIndex = 9;
            product_QtyLabel.Text = "Qty on Doc:";
            // 
            // customer_NameLabel
            // 
            customer_NameLabel.AutoSize = true;
            customer_NameLabel.Location = new System.Drawing.Point(103, 111);
            customer_NameLabel.Name = "customer_NameLabel";
            customer_NameLabel.Size = new System.Drawing.Size(100, 15);
            customer_NameLabel.TabIndex = 11;
            customer_NameLabel.Text = "Customer Name:";
            // 
            // user_RepLabel
            // 
            user_RepLabel.AutoSize = true;
            user_RepLabel.Location = new System.Drawing.Point(141, 217);
            user_RepLabel.Name = "user_RepLabel";
            user_RepLabel.Size = new System.Drawing.Size(62, 15);
            user_RepLabel.TabIndex = 15;
            user_RepLabel.Text = "User Rep:";
            // 
            // fault_DescriptionLabel
            // 
            fault_DescriptionLabel.AutoSize = true;
            fault_DescriptionLabel.Location = new System.Drawing.Point(101, 246);
            fault_DescriptionLabel.Name = "fault_DescriptionLabel";
            fault_DescriptionLabel.Size = new System.Drawing.Size(102, 15);
            fault_DescriptionLabel.TabIndex = 17;
            fault_DescriptionLabel.Text = "Fault Description:";
            // 
            // loyverse_Pastel_Doc_NumberLabel
            // 
            loyverse_Pastel_Doc_NumberLabel.AutoSize = true;
            loyverse_Pastel_Doc_NumberLabel.Location = new System.Drawing.Point(29, 275);
            loyverse_Pastel_Doc_NumberLabel.Name = "loyverse_Pastel_Doc_NumberLabel";
            loyverse_Pastel_Doc_NumberLabel.Size = new System.Drawing.Size(174, 15);
            loyverse_Pastel_Doc_NumberLabel.TabIndex = 19;
            loyverse_Pastel_Doc_NumberLabel.Text = "Loyverse / Pastel Doc Number:";
            // 
            // qty_ReturnedLabel
            // 
            qty_ReturnedLabel.AutoSize = true;
            qty_ReturnedLabel.Location = new System.Drawing.Point(122, 299);
            qty_ReturnedLabel.Name = "qty_ReturnedLabel";
            qty_ReturnedLabel.Size = new System.Drawing.Size(81, 15);
            qty_ReturnedLabel.TabIndex = 21;
            qty_ReturnedLabel.Text = "Qty Returned:";
            // 
            // investigate_ResolvedLabel
            // 
            investigate_ResolvedLabel.AutoSize = true;
            investigate_ResolvedLabel.Location = new System.Drawing.Point(75, 329);
            investigate_ResolvedLabel.Name = "investigate_ResolvedLabel";
            investigate_ResolvedLabel.Size = new System.Drawing.Size(128, 15);
            investigate_ResolvedLabel.TabIndex = 23;
            investigate_ResolvedLabel.Text = "Investigate / Resolved:";
            // 
            // managerLabel
            // 
            managerLabel.AutoSize = true;
            managerLabel.Location = new System.Drawing.Point(11, 6);
            managerLabel.Name = "managerLabel";
            managerLabel.Size = new System.Drawing.Size(99, 15);
            managerLabel.TabIndex = 25;
            managerLabel.Text = "Last Updated By:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(139, 358);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(64, 15);
            commentLabel.TabIndex = 27;
            commentLabel.Text = "Comment:";
            // 
            // entry_DateLabel
            // 
            entry_DateLabel.AutoSize = true;
            entry_DateLabel.Location = new System.Drawing.Point(388, 6);
            entry_DateLabel.Name = "entry_DateLabel";
            entry_DateLabel.Size = new System.Drawing.Size(66, 15);
            entry_DateLabel.TabIndex = 29;
            entry_DateLabel.Text = "Entry Date:";
            // 
            // manager_SignatureLabel
            // 
            manager_SignatureLabel.AutoSize = true;
            manager_SignatureLabel.Location = new System.Drawing.Point(1050, 12);
            manager_SignatureLabel.Name = "manager_SignatureLabel";
            manager_SignatureLabel.Size = new System.Drawing.Size(116, 15);
            manager_SignatureLabel.TabIndex = 36;
            manager_SignatureLabel.Text = "Manager Signature:";
            // 
            // user_signatureLabel
            // 
            user_signatureLabel.AutoSize = true;
            user_signatureLabel.Location = new System.Drawing.Point(1278, 12);
            user_signatureLabel.Name = "user_signatureLabel";
            user_signatureLabel.Size = new System.Drawing.Size(88, 15);
            user_signatureLabel.TabIndex = 37;
            user_signatureLabel.Text = "user signature:";
            // 
            // fault_IdLabel
            // 
            fault_IdLabel.AutoSize = true;
            fault_IdLabel.Location = new System.Drawing.Point(44, 112);
            fault_IdLabel.Name = "fault_IdLabel";
            fault_IdLabel.Size = new System.Drawing.Size(50, 15);
            fault_IdLabel.TabIndex = 6;
            fault_IdLabel.Text = "Fault Id:";
            // 
            // f_cust_idLabel
            // 
            f_cust_idLabel.AutoSize = true;
            f_cust_idLabel.Location = new System.Drawing.Point(32, 38);
            f_cust_idLabel.Name = "f_cust_idLabel";
            f_cust_idLabel.Size = new System.Drawing.Size(55, 15);
            f_cust_idLabel.TabIndex = 0;
            f_cust_idLabel.Text = "F cust id:";
            // 
            // f_prod_idLabel
            // 
            f_prod_idLabel.AutoSize = true;
            f_prod_idLabel.Location = new System.Drawing.Point(29, 76);
            f_prod_idLabel.Name = "f_prod_idLabel";
            f_prod_idLabel.Size = new System.Drawing.Size(58, 15);
            f_prod_idLabel.TabIndex = 2;
            f_prod_idLabel.Text = "F prod id:";
            // 
            // f_rep_idLabel
            // 
            f_rep_idLabel.AutoSize = true;
            f_rep_idLabel.Location = new System.Drawing.Point(36, 115);
            f_rep_idLabel.Name = "f_rep_idLabel";
            f_rep_idLabel.Size = new System.Drawing.Size(51, 15);
            f_rep_idLabel.TabIndex = 4;
            f_rep_idLabel.Text = "F rep id:";
            // 
            // f_fault_idLabel
            // 
            f_fault_idLabel.AutoSize = true;
            f_fault_idLabel.Location = new System.Drawing.Point(31, 158);
            f_fault_idLabel.Name = "f_fault_idLabel";
            f_fault_idLabel.Size = new System.Drawing.Size(56, 15);
            f_fault_idLabel.TabIndex = 6;
            f_fault_idLabel.Text = "F fault id:";
            // 
            // customer_IdLabel
            // 
            customer_IdLabel.AutoSize = true;
            customer_IdLabel.Location = new System.Drawing.Point(18, 25);
            customer_IdLabel.Name = "customer_IdLabel";
            customer_IdLabel.Size = new System.Drawing.Size(76, 15);
            customer_IdLabel.TabIndex = 0;
            customer_IdLabel.Text = "Customer Id:";
            // 
            // product_IdLabel
            // 
            product_IdLabel.AutoSize = true;
            product_IdLabel.Location = new System.Drawing.Point(29, 56);
            product_IdLabel.Name = "product_IdLabel";
            product_IdLabel.Size = new System.Drawing.Size(65, 15);
            product_IdLabel.TabIndex = 2;
            product_IdLabel.Text = "Product Id:";
            // 
            // rep_IdLabel
            // 
            rep_IdLabel.AutoSize = true;
            rep_IdLabel.Location = new System.Drawing.Point(44, 84);
            rep_IdLabel.Name = "rep_IdLabel";
            rep_IdLabel.Size = new System.Drawing.Size(46, 15);
            rep_IdLabel.TabIndex = 7;
            rep_IdLabel.Text = "Rep Id:";
            // 
            // batch_DateLabel1
            // 
            batch_DateLabel1.AutoSize = true;
            batch_DateLabel1.Location = new System.Drawing.Point(133, 189);
            batch_DateLabel1.Name = "batch_DateLabel1";
            batch_DateLabel1.Size = new System.Drawing.Size(70, 15);
            batch_DateLabel1.TabIndex = 44;
            batch_DateLabel1.Text = "Batch Date:";
            // 
            // batch_DateLabel2
            // 
            batch_DateLabel2.AutoSize = true;
            batch_DateLabel2.Location = new System.Drawing.Point(556, 223);
            batch_DateLabel2.Name = "batch_DateLabel2";
            batch_DateLabel2.Size = new System.Drawing.Size(70, 15);
            batch_DateLabel2.TabIndex = 45;
            batch_DateLabel2.Text = "Batch Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(226, 167);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 15);
            label1.TabIndex = 46;
            label1.Text = "dd/mm/yyyy";
            // 
            // current_record_ds
            // 
            this.current_record_ds.DataSetName = "current_record_ds";
            this.current_record_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // returns_TableTableAdapter
            // 
            this.returns_TableTableAdapter.ClearBeforeFill = true;
            // 
            // returns_TableDataGridView
            // 
            this.returns_TableDataGridView.AllowUserToAddRows = false;
            this.returns_TableDataGridView.AllowUserToDeleteRows = false;
            this.returns_TableDataGridView.AutoGenerateColumns = false;
            this.returns_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returns_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.returns_TableDataGridView.DataSource = this.returns_TableBindingSource;
            this.returns_TableDataGridView.Enabled = false;
            this.returns_TableDataGridView.Location = new System.Drawing.Point(1031, 81);
            this.returns_TableDataGridView.Name = "returns_TableDataGridView";
            this.returns_TableDataGridView.ReadOnly = true;
            this.returns_TableDataGridView.Size = new System.Drawing.Size(231, 77);
            this.returns_TableDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Entry_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Entry_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Doc_Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Doc_Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Entry_Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Entry_Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Product_Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Product_Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Product_Qty";
            this.dataGridViewTextBoxColumn5.HeaderText = "Product_Qty";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Customer_Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Customer_Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Batch_Date";
            this.dataGridViewTextBoxColumn7.HeaderText = "Batch_Date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "User_Rep";
            this.dataGridViewTextBoxColumn8.HeaderText = "User_Rep";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Fault_Description";
            this.dataGridViewTextBoxColumn9.HeaderText = "Fault_Description";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Loyverse_Pastel_Doc_Number";
            this.dataGridViewTextBoxColumn10.HeaderText = "Loyverse_Pastel_Doc_Number";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Qty_Returned";
            this.dataGridViewTextBoxColumn11.HeaderText = "Qty_Returned";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Investigate_Resolved";
            this.dataGridViewTextBoxColumn12.HeaderText = "Investigate_Resolved";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Manager";
            this.dataGridViewTextBoxColumn13.HeaderText = "Manager";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn14.HeaderText = "Comment";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // returns_TableBindingSource
            // 
            this.returns_TableBindingSource.DataMember = "Returns_Table";
            this.returns_TableBindingSource.DataSource = this.current_record_ds;
            // 
            // entry_IDLabel1
            // 
            this.entry_IDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returns_TableBindingSource, "Entry_ID", true));
            this.entry_IDLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_IDLabel1.Location = new System.Drawing.Point(254, 8);
            this.entry_IDLabel1.Name = "entry_IDLabel1";
            this.entry_IDLabel1.Size = new System.Drawing.Size(59, 23);
            this.entry_IDLabel1.TabIndex = 2;
            this.entry_IDLabel1.Text = "label1";
            // 
            // doc_DateDateTimePicker
            // 
            this.doc_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.returns_TableBindingSource, "Doc_Date", true));
            this.doc_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.doc_DateDateTimePicker.Location = new System.Drawing.Point(209, 24);
            this.doc_DateDateTimePicker.Name = "doc_DateDateTimePicker";
            this.doc_DateDateTimePicker.Size = new System.Drawing.Size(100, 21);
            this.doc_DateDateTimePicker.TabIndex = 1;
            // 
            // product_NameComboBox
            // 
            this.product_NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.product_NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.product_NameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returns_TableBindingSource, "Product_Name", true));
            this.product_NameComboBox.DataSource = this.productTableBindingSource;
            this.product_NameComboBox.DisplayMember = "Product_Name";
            this.product_NameComboBox.FormattingEnabled = true;
            this.product_NameComboBox.Location = new System.Drawing.Point(209, 51);
            this.product_NameComboBox.Name = "product_NameComboBox";
            this.product_NameComboBox.Size = new System.Drawing.Size(200, 23);
            this.product_NameComboBox.TabIndex = 2;
            this.product_NameComboBox.ValueMember = "Product_Name";
            // 
            // productTableBindingSource
            // 
            this.productTableBindingSource.DataMember = "Product_Table";
            this.productTableBindingSource.DataSource = this.add_entry_ds;
            // 
            // add_entry_ds
            // 
            this.add_entry_ds.DataSetName = "add_entry_ds";
            this.add_entry_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // product_QtyNumericUpDown
            // 
            this.product_QtyNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.returns_TableBindingSource, "Product_Qty", true));
            this.product_QtyNumericUpDown.Location = new System.Drawing.Point(209, 80);
            this.product_QtyNumericUpDown.Name = "product_QtyNumericUpDown";
            this.product_QtyNumericUpDown.Size = new System.Drawing.Size(116, 21);
            this.product_QtyNumericUpDown.TabIndex = 3;
            // 
            // customer_NameComboBox
            // 
            this.customer_NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.customer_NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.customer_NameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returns_TableBindingSource, "Customer_Name", true));
            this.customer_NameComboBox.DataSource = this.customersTableBindingSource;
            this.customer_NameComboBox.DisplayMember = "Customer_name";
            this.customer_NameComboBox.FormattingEnabled = true;
            this.customer_NameComboBox.Location = new System.Drawing.Point(209, 107);
            this.customer_NameComboBox.Name = "customer_NameComboBox";
            this.customer_NameComboBox.Size = new System.Drawing.Size(200, 23);
            this.customer_NameComboBox.TabIndex = 4;
            this.customer_NameComboBox.ValueMember = "Customer_name";
            // 
            // customersTableBindingSource
            // 
            this.customersTableBindingSource.DataMember = "Customers_Table";
            this.customersTableBindingSource.DataSource = this.add_entry_ds;
            // 
            // user_RepComboBox
            // 
            this.user_RepComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returns_TableBindingSource, "User_Rep", true));
            this.user_RepComboBox.DataSource = this.reps_TableBindingSource;
            this.user_RepComboBox.DisplayMember = "Rep_Name";
            this.user_RepComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.user_RepComboBox.FormattingEnabled = true;
            this.user_RepComboBox.Location = new System.Drawing.Point(209, 213);
            this.user_RepComboBox.Name = "user_RepComboBox";
            this.user_RepComboBox.Size = new System.Drawing.Size(200, 23);
            this.user_RepComboBox.TabIndex = 7;
            this.user_RepComboBox.ValueMember = "Rep_Name";
            // 
            // reps_TableBindingSource
            // 
            this.reps_TableBindingSource.DataMember = "Reps_Table";
            this.reps_TableBindingSource.DataSource = this.add_entry_ds;
            // 
            // repsTableBindingSource
            // 
            this.repsTableBindingSource.DataMember = "Reps_Table";
            this.repsTableBindingSource.DataSource = this.add_entry_ds1;
            // 
            // add_entry_ds1
            // 
            this.add_entry_ds1.DataSetName = "add_entry_ds";
            this.add_entry_ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fault_DescriptionComboBox
            // 
            this.fault_DescriptionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returns_TableBindingSource, "Fault_Description", true));
            this.fault_DescriptionComboBox.DataSource = this.faultsTableBindingSource;
            this.fault_DescriptionComboBox.DisplayMember = "Fault_Name";
            this.fault_DescriptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fault_DescriptionComboBox.FormattingEnabled = true;
            this.fault_DescriptionComboBox.Location = new System.Drawing.Point(209, 242);
            this.fault_DescriptionComboBox.Name = "fault_DescriptionComboBox";
            this.fault_DescriptionComboBox.Size = new System.Drawing.Size(200, 23);
            this.fault_DescriptionComboBox.TabIndex = 8;
            this.fault_DescriptionComboBox.ValueMember = "Fault_Name";
            // 
            // faultsTableBindingSource
            // 
            this.faultsTableBindingSource.DataMember = "Faults_Table";
            this.faultsTableBindingSource.DataSource = this.add_entry_ds;
            // 
            // loyverse_Pastel_Doc_NumberTextBox
            // 
            this.loyverse_Pastel_Doc_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returns_TableBindingSource, "Loyverse_Pastel_Doc_Number", true));
            this.loyverse_Pastel_Doc_NumberTextBox.Location = new System.Drawing.Point(209, 271);
            this.loyverse_Pastel_Doc_NumberTextBox.Name = "loyverse_Pastel_Doc_NumberTextBox";
            this.loyverse_Pastel_Doc_NumberTextBox.Size = new System.Drawing.Size(200, 21);
            this.loyverse_Pastel_Doc_NumberTextBox.TabIndex = 9;
            // 
            // qty_ReturnedNumericUpDown
            // 
            this.qty_ReturnedNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.returns_TableBindingSource, "Qty_Returned", true));
            this.qty_ReturnedNumericUpDown.Location = new System.Drawing.Point(209, 298);
            this.qty_ReturnedNumericUpDown.Name = "qty_ReturnedNumericUpDown";
            this.qty_ReturnedNumericUpDown.Size = new System.Drawing.Size(116, 21);
            this.qty_ReturnedNumericUpDown.TabIndex = 10;
            // 
            // investigate_ResolvedComboBox
            // 
            this.investigate_ResolvedComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returns_TableBindingSource, "Investigate_Resolved", true));
            this.investigate_ResolvedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.investigate_ResolvedComboBox.FormattingEnabled = true;
            this.investigate_ResolvedComboBox.Items.AddRange(new object[] {
            "Investigate",
            "Resolved"});
            this.investigate_ResolvedComboBox.Location = new System.Drawing.Point(209, 325);
            this.investigate_ResolvedComboBox.Name = "investigate_ResolvedComboBox";
            this.investigate_ResolvedComboBox.Size = new System.Drawing.Size(200, 23);
            this.investigate_ResolvedComboBox.TabIndex = 11;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returns_TableBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(209, 354);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(263, 123);
            this.commentTextBox.TabIndex = 12;
            // 
            // groupBox_info
            // 
            this.groupBox_info.Controls.Add(label1);
            this.groupBox_info.Controls.Add(this.checkBox_show_batch_dt_picker);
            this.groupBox_info.Controls.Add(this.panel_add_new_data);
            this.groupBox_info.Controls.Add(batch_DateLabel1);
            this.groupBox_info.Controls.Add(product_NameLabel);
            this.groupBox_info.Controls.Add(this.batch_DateTextBox);
            this.groupBox_info.Controls.Add(this.commentTextBox);
            this.groupBox_info.Controls.Add(commentLabel);
            this.groupBox_info.Controls.Add(doc_DateLabel);
            this.groupBox_info.Controls.Add(this.doc_DateDateTimePicker);
            this.groupBox_info.Controls.Add(this.investigate_ResolvedComboBox);
            this.groupBox_info.Controls.Add(investigate_ResolvedLabel);
            this.groupBox_info.Controls.Add(this.qty_ReturnedNumericUpDown);
            this.groupBox_info.Controls.Add(this.product_NameComboBox);
            this.groupBox_info.Controls.Add(qty_ReturnedLabel);
            this.groupBox_info.Controls.Add(product_QtyLabel);
            this.groupBox_info.Controls.Add(this.loyverse_Pastel_Doc_NumberTextBox);
            this.groupBox_info.Controls.Add(this.product_QtyNumericUpDown);
            this.groupBox_info.Controls.Add(loyverse_Pastel_Doc_NumberLabel);
            this.groupBox_info.Controls.Add(customer_NameLabel);
            this.groupBox_info.Controls.Add(this.fault_DescriptionComboBox);
            this.groupBox_info.Controls.Add(this.customer_NameComboBox);
            this.groupBox_info.Controls.Add(fault_DescriptionLabel);
            this.groupBox_info.Controls.Add(this.user_RepComboBox);
            this.groupBox_info.Controls.Add(user_RepLabel);
            this.groupBox_info.Location = new System.Drawing.Point(13, 57);
            this.groupBox_info.Name = "groupBox_info";
            this.groupBox_info.Size = new System.Drawing.Size(525, 490);
            this.groupBox_info.TabIndex = 29;
            this.groupBox_info.TabStop = false;
            this.groupBox_info.Text = "Info";
            // 
            // checkBox_show_batch_dt_picker
            // 
            this.checkBox_show_batch_dt_picker.AutoSize = true;
            this.checkBox_show_batch_dt_picker.Location = new System.Drawing.Point(209, 145);
            this.checkBox_show_batch_dt_picker.Name = "checkBox_show_batch_dt_picker";
            this.checkBox_show_batch_dt_picker.Size = new System.Drawing.Size(160, 19);
            this.checkBox_show_batch_dt_picker.TabIndex = 5;
            this.checkBox_show_batch_dt_picker.Text = "No / Change Batch Date ";
            this.checkBox_show_batch_dt_picker.UseVisualStyleBackColor = true;
            this.checkBox_show_batch_dt_picker.CheckedChanged += new System.EventHandler(this.checkBox_show_batch_dt_picker_CheckedChanged);
            // 
            // panel_add_new_data
            // 
            this.panel_add_new_data.Controls.Add(this.btn_add_new_product);
            this.panel_add_new_data.Controls.Add(this.btn_add_new_fault_description);
            this.panel_add_new_data.Controls.Add(this.btn_add_new_rep);
            this.panel_add_new_data.Controls.Add(this.btn_add_new_customer);
            this.panel_add_new_data.Location = new System.Drawing.Point(410, 21);
            this.panel_add_new_data.Name = "panel_add_new_data";
            this.panel_add_new_data.Size = new System.Drawing.Size(33, 279);
            this.panel_add_new_data.TabIndex = 30;
            // 
            // btn_add_new_product
            // 
            this.btn_add_new_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_new_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_new_product.Location = new System.Drawing.Point(5, 29);
            this.btn_add_new_product.Name = "btn_add_new_product";
            this.btn_add_new_product.Size = new System.Drawing.Size(25, 24);
            this.btn_add_new_product.TabIndex = 32;
            this.btn_add_new_product.Text = "+";
            this.btn_add_new_product.UseVisualStyleBackColor = true;
            this.btn_add_new_product.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_add_new_fault_description
            // 
            this.btn_add_new_fault_description.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_new_fault_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_new_fault_description.Location = new System.Drawing.Point(5, 221);
            this.btn_add_new_fault_description.Name = "btn_add_new_fault_description";
            this.btn_add_new_fault_description.Size = new System.Drawing.Size(25, 24);
            this.btn_add_new_fault_description.TabIndex = 31;
            this.btn_add_new_fault_description.Text = "+";
            this.btn_add_new_fault_description.UseVisualStyleBackColor = true;
            this.btn_add_new_fault_description.Click += new System.EventHandler(this.btn_add_new_fault_description_Click);
            // 
            // btn_add_new_rep
            // 
            this.btn_add_new_rep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_new_rep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_new_rep.Location = new System.Drawing.Point(5, 191);
            this.btn_add_new_rep.Name = "btn_add_new_rep";
            this.btn_add_new_rep.Size = new System.Drawing.Size(25, 24);
            this.btn_add_new_rep.TabIndex = 30;
            this.btn_add_new_rep.Text = "+";
            this.btn_add_new_rep.UseVisualStyleBackColor = true;
            this.btn_add_new_rep.Click += new System.EventHandler(this.btn_add_new_rep_Click);
            // 
            // btn_add_new_customer
            // 
            this.btn_add_new_customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_new_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_new_customer.Location = new System.Drawing.Point(5, 86);
            this.btn_add_new_customer.Name = "btn_add_new_customer";
            this.btn_add_new_customer.Size = new System.Drawing.Size(25, 24);
            this.btn_add_new_customer.TabIndex = 29;
            this.btn_add_new_customer.Text = "+";
            this.btn_add_new_customer.UseVisualStyleBackColor = true;
            this.btn_add_new_customer.Click += new System.EventHandler(this.btn_add_new_customer_Click);
            // 
            // batch_DateTextBox
            // 
            this.batch_DateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returns_TableBindingSource, "Batch_Date", true));
            this.batch_DateTextBox.Location = new System.Drawing.Point(209, 186);
            this.batch_DateTextBox.MaxLength = 10;
            this.batch_DateTextBox.Name = "batch_DateTextBox";
            this.batch_DateTextBox.Size = new System.Drawing.Size(100, 21);
            this.batch_DateTextBox.TabIndex = 6;
            this.batch_DateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.batch_DateTextBox_KeyPress);
            // 
            // entry_DateLabel1
            // 
            this.entry_DateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returns_TableBindingSource, "Entry_Date", true));
            this.entry_DateLabel1.Location = new System.Drawing.Point(453, 6);
            this.entry_DateLabel1.Name = "entry_DateLabel1";
            this.entry_DateLabel1.Size = new System.Drawing.Size(96, 23);
            this.entry_DateLabel1.TabIndex = 30;
            this.entry_DateLabel1.Text = "label1";
            // 
            // btn_add_new
            // 
            this.btn_add_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_new.Location = new System.Drawing.Point(15, 12);
            this.btn_add_new.Name = "btn_add_new";
            this.btn_add_new.Size = new System.Drawing.Size(98, 39);
            this.btn_add_new.TabIndex = 31;
            this.btn_add_new.Text = "&Add New";
            this.btn_add_new.UseVisualStyleBackColor = true;
            this.btn_add_new.Click += new System.EventHandler(this.btn_add_new_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Location = new System.Drawing.Point(119, 12);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(98, 39);
            this.btn_edit.TabIndex = 32;
            this.btn_edit.Text = "&Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Location = new System.Drawing.Point(223, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(98, 39);
            this.btn_delete.TabIndex = 33;
            this.btn_delete.Text = "&Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Location = new System.Drawing.Point(327, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(98, 39);
            this.btn_save.TabIndex = 34;
            this.btn_save.Text = "&Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Location = new System.Drawing.Point(431, 12);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(98, 39);
            this.btn_cancel.TabIndex = 35;
            this.btn_cancel.Text = "&Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // product_TableTableAdapter
            // 
            this.product_TableTableAdapter.ClearBeforeFill = true;
            // 
            // customers_TableTableAdapter
            // 
            this.customers_TableTableAdapter.ClearBeforeFill = true;
            // 
            // faults_TableTableAdapter
            // 
            this.faults_TableTableAdapter.ClearBeforeFill = true;
            // 
            // reps_TableTableAdapter
            // 
            this.reps_TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Categories_TableTableAdapter = null;
            this.tableAdapterManager1.Customers_TableTableAdapter = null;
            this.tableAdapterManager1.Faults_TableTableAdapter = null;
            this.tableAdapterManager1.Product_TableTableAdapter = null;
            this.tableAdapterManager1.Reps_TableTableAdapter = this.reps_TableTableAdapter;
            this.tableAdapterManager1.Returns_TableTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Nutrisnacks_Returns_Version_Two.Dataset.add_entry_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.Users_TableTableAdapter = null;
            // 
            // customers_TableDataGridView
            // 
            this.customers_TableDataGridView.AllowUserToAddRows = false;
            this.customers_TableDataGridView.AllowUserToDeleteRows = false;
            this.customers_TableDataGridView.AutoGenerateColumns = false;
            this.customers_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customers_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.customers_TableDataGridView.DataSource = this.customersTableBindingSource;
            this.customers_TableDataGridView.Enabled = false;
            this.customers_TableDataGridView.Location = new System.Drawing.Point(1031, 168);
            this.customers_TableDataGridView.Name = "customers_TableDataGridView";
            this.customers_TableDataGridView.ReadOnly = true;
            this.customers_TableDataGridView.Size = new System.Drawing.Size(231, 93);
            this.customers_TableDataGridView.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Customer_Id";
            this.dataGridViewTextBoxColumn15.HeaderText = "Customer_Id";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Customer_name";
            this.dataGridViewTextBoxColumn16.HeaderText = "Customer_name";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // label_child_form
            // 
            this.label_child_form.AutoSize = true;
            this.label_child_form.Location = new System.Drawing.Point(1028, 47);
            this.label_child_form.Name = "label_child_form";
            this.label_child_form.Size = new System.Drawing.Size(41, 15);
            this.label_child_form.TabIndex = 36;
            this.label_child_form.Text = "label1";
            // 
            // panel_footer
            // 
            this.panel_footer.Controls.Add(this.entry_DateLabel1);
            this.panel_footer.Controls.Add(this.managerLabel1);
            this.panel_footer.Controls.Add(this.entry_IDLabel1);
            this.panel_footer.Controls.Add(entry_IDLabel);
            this.panel_footer.Controls.Add(managerLabel);
            this.panel_footer.Controls.Add(entry_DateLabel);
            this.panel_footer.Location = new System.Drawing.Point(1, 553);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(550, 33);
            this.panel_footer.TabIndex = 31;
            // 
            // managerLabel1
            // 
            this.managerLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returns_TableBindingSource, "Manager", true));
            this.managerLabel1.Location = new System.Drawing.Point(107, 6);
            this.managerLabel1.Name = "managerLabel1";
            this.managerLabel1.Size = new System.Drawing.Size(103, 23);
            this.managerLabel1.TabIndex = 26;
            this.managerLabel1.Text = "label1";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Returns_TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Nutrisnacks_Returns_Version_Two.Dataset.current_record_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // manager_SignaturePictureBox
            // 
            this.manager_SignaturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.returns_TableBindingSource, "Manager_Signature", true));
            this.manager_SignaturePictureBox.Location = new System.Drawing.Point(1172, 12);
            this.manager_SignaturePictureBox.Name = "manager_SignaturePictureBox";
            this.manager_SignaturePictureBox.Size = new System.Drawing.Size(100, 50);
            this.manager_SignaturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.manager_SignaturePictureBox.TabIndex = 37;
            this.manager_SignaturePictureBox.TabStop = false;
            // 
            // users_TableBindingSource
            // 
            this.users_TableBindingSource.DataMember = "Users_Table";
            this.users_TableBindingSource.DataSource = this.add_entry_ds;
            // 
            // users_TableTableAdapter
            // 
            this.users_TableTableAdapter.ClearBeforeFill = true;
            // 
            // user_signaturePictureBox
            // 
            this.user_signaturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.users_TableBindingSource, "user_signature", true));
            this.user_signaturePictureBox.Location = new System.Drawing.Point(1372, 12);
            this.user_signaturePictureBox.Name = "user_signaturePictureBox";
            this.user_signaturePictureBox.Size = new System.Drawing.Size(100, 50);
            this.user_signaturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_signaturePictureBox.TabIndex = 38;
            this.user_signaturePictureBox.TabStop = false;
            // 
            // users_TableDataGridView
            // 
            this.users_TableDataGridView.AllowUserToAddRows = false;
            this.users_TableDataGridView.AllowUserToDeleteRows = false;
            this.users_TableDataGridView.AutoGenerateColumns = false;
            this.users_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewImageColumn1});
            this.users_TableDataGridView.DataSource = this.users_TableBindingSource;
            this.users_TableDataGridView.Enabled = false;
            this.users_TableDataGridView.Location = new System.Drawing.Point(1031, 271);
            this.users_TableDataGridView.Name = "users_TableDataGridView";
            this.users_TableDataGridView.ReadOnly = true;
            this.users_TableDataGridView.Size = new System.Drawing.Size(241, 72);
            this.users_TableDataGridView.TabIndex = 38;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "User_Id";
            this.dataGridViewTextBoxColumn17.HeaderText = "User_Id";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "user_signature";
            this.dataGridViewImageColumn1.HeaderText = "user_signature";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(f_fault_idLabel);
            this.groupBox1.Controls.Add(this.f_fault_idTextBox);
            this.groupBox1.Controls.Add(f_rep_idLabel);
            this.groupBox1.Controls.Add(this.f_rep_idTextBox);
            this.groupBox1.Controls.Add(f_prod_idLabel);
            this.groupBox1.Controls.Add(this.f_prod_idTextBox);
            this.groupBox1.Controls.Add(f_cust_idLabel);
            this.groupBox1.Controls.Add(this.f_cust_idTextBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(777, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 196);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Returns Entry";
            // 
            // f_fault_idTextBox
            // 
            this.f_fault_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returns_TableBindingSource, "F_fault_id", true));
            this.f_fault_idTextBox.Location = new System.Drawing.Point(93, 155);
            this.f_fault_idTextBox.Name = "f_fault_idTextBox";
            this.f_fault_idTextBox.Size = new System.Drawing.Size(100, 21);
            this.f_fault_idTextBox.TabIndex = 7;
            // 
            // f_rep_idTextBox
            // 
            this.f_rep_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returns_TableBindingSource, "F_rep_id", true));
            this.f_rep_idTextBox.Location = new System.Drawing.Point(93, 112);
            this.f_rep_idTextBox.Name = "f_rep_idTextBox";
            this.f_rep_idTextBox.Size = new System.Drawing.Size(100, 21);
            this.f_rep_idTextBox.TabIndex = 5;
            // 
            // f_prod_idTextBox
            // 
            this.f_prod_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returns_TableBindingSource, "F_prod_id", true));
            this.f_prod_idTextBox.Location = new System.Drawing.Point(93, 73);
            this.f_prod_idTextBox.Name = "f_prod_idTextBox";
            this.f_prod_idTextBox.Size = new System.Drawing.Size(100, 21);
            this.f_prod_idTextBox.TabIndex = 3;
            // 
            // f_cust_idTextBox
            // 
            this.f_cust_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returns_TableBindingSource, "F_cust_id", true));
            this.f_cust_idTextBox.Location = new System.Drawing.Point(93, 35);
            this.f_cust_idTextBox.Name = "f_cust_idTextBox";
            this.f_cust_idTextBox.Size = new System.Drawing.Size(100, 21);
            this.f_cust_idTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(rep_IdLabel);
            this.groupBox2.Controls.Add(this.rep_IdLabel1);
            this.groupBox2.Controls.Add(fault_IdLabel);
            this.groupBox2.Controls.Add(this.fault_IdLabel1);
            this.groupBox2.Controls.Add(product_IdLabel);
            this.groupBox2.Controls.Add(this.product_IdLabel1);
            this.groupBox2.Controls.Add(customer_IdLabel);
            this.groupBox2.Controls.Add(this.customer_IdLabel1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(777, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 155);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "External Ds";
            // 
            // rep_IdLabel1
            // 
            this.rep_IdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reps_TableBindingSource, "Rep_Id", true));
            this.rep_IdLabel1.Location = new System.Drawing.Point(96, 84);
            this.rep_IdLabel1.Name = "rep_IdLabel1";
            this.rep_IdLabel1.Size = new System.Drawing.Size(100, 23);
            this.rep_IdLabel1.TabIndex = 8;
            this.rep_IdLabel1.Text = "label2";
            // 
            // fault_IdLabel1
            // 
            this.fault_IdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.faultsTableBindingSource, "Fault_Id", true));
            this.fault_IdLabel1.Location = new System.Drawing.Point(100, 112);
            this.fault_IdLabel1.Name = "fault_IdLabel1";
            this.fault_IdLabel1.Size = new System.Drawing.Size(100, 23);
            this.fault_IdLabel1.TabIndex = 7;
            this.fault_IdLabel1.Text = "label2";
            // 
            // product_IdLabel1
            // 
            this.product_IdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productTableBindingSource, "Product_Id", true));
            this.product_IdLabel1.Location = new System.Drawing.Point(100, 56);
            this.product_IdLabel1.Name = "product_IdLabel1";
            this.product_IdLabel1.Size = new System.Drawing.Size(100, 23);
            this.product_IdLabel1.TabIndex = 3;
            this.product_IdLabel1.Text = "label2";
            // 
            // customer_IdLabel1
            // 
            this.customer_IdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersTableBindingSource, "Customer_Id", true));
            this.customer_IdLabel1.Location = new System.Drawing.Point(100, 25);
            this.customer_IdLabel1.Name = "customer_IdLabel1";
            this.customer_IdLabel1.Size = new System.Drawing.Size(100, 23);
            this.customer_IdLabel1.TabIndex = 1;
            this.customer_IdLabel1.Text = "label2";
            // 
            // product_TableDataGridView
            // 
            this.product_TableDataGridView.AllowUserToAddRows = false;
            this.product_TableDataGridView.AllowUserToDeleteRows = false;
            this.product_TableDataGridView.AutoGenerateColumns = false;
            this.product_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.product_TableDataGridView.DataSource = this.productTableBindingSource;
            this.product_TableDataGridView.Enabled = false;
            this.product_TableDataGridView.Location = new System.Drawing.Point(1041, 352);
            this.product_TableDataGridView.Name = "product_TableDataGridView";
            this.product_TableDataGridView.ReadOnly = true;
            this.product_TableDataGridView.Size = new System.Drawing.Size(300, 82);
            this.product_TableDataGridView.TabIndex = 44;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Product_Id";
            this.dataGridViewTextBoxColumn18.HeaderText = "Product_Id";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Product_Name";
            this.dataGridViewTextBoxColumn19.HeaderText = "Product_Name";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Product_Category";
            this.dataGridViewTextBoxColumn20.HeaderText = "Product_Category";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Product_Price_Ex_Vat";
            this.dataGridViewTextBoxColumn21.HeaderText = "Product_Price_Ex_Vat";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Product_Price_Inc_Vat";
            this.dataGridViewTextBoxColumn22.HeaderText = "Product_Price_Inc_Vat";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Product_Vat";
            this.dataGridViewTextBoxColumn23.HeaderText = "Product_Vat";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Vat_Percentage";
            this.dataGridViewTextBoxColumn24.HeaderText = "Vat_Percentage";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // faults_TableDataGridView
            // 
            this.faults_TableDataGridView.AllowUserToAddRows = false;
            this.faults_TableDataGridView.AllowUserToDeleteRows = false;
            this.faults_TableDataGridView.AutoGenerateColumns = false;
            this.faults_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.faults_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28});
            this.faults_TableDataGridView.DataSource = this.faultsTableBindingSource;
            this.faults_TableDataGridView.Enabled = false;
            this.faults_TableDataGridView.Location = new System.Drawing.Point(1041, 512);
            this.faults_TableDataGridView.Name = "faults_TableDataGridView";
            this.faults_TableDataGridView.ReadOnly = true;
            this.faults_TableDataGridView.Size = new System.Drawing.Size(300, 74);
            this.faults_TableDataGridView.TabIndex = 44;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Fault_Id";
            this.dataGridViewTextBoxColumn27.HeaderText = "Fault_Id";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Fault_Name";
            this.dataGridViewTextBoxColumn28.HeaderText = "Fault_Name";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            // 
            // reps_TableDataGridView
            // 
            this.reps_TableDataGridView.AllowUserToAddRows = false;
            this.reps_TableDataGridView.AllowUserToDeleteRows = false;
            this.reps_TableDataGridView.AutoGenerateColumns = false;
            this.reps_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reps_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26});
            this.reps_TableDataGridView.DataSource = this.repsTableBindingSource;
            this.reps_TableDataGridView.Enabled = false;
            this.reps_TableDataGridView.Location = new System.Drawing.Point(1041, 440);
            this.reps_TableDataGridView.Name = "reps_TableDataGridView";
            this.reps_TableDataGridView.ReadOnly = true;
            this.reps_TableDataGridView.Size = new System.Drawing.Size(300, 66);
            this.reps_TableDataGridView.TabIndex = 44;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Rep_Id";
            this.dataGridViewTextBoxColumn25.HeaderText = "Rep_Id";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Rep_Name";
            this.dataGridViewTextBoxColumn26.HeaderText = "Rep_Name";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // reps_TableDataGridView1
            // 
            this.reps_TableDataGridView1.AllowUserToAddRows = false;
            this.reps_TableDataGridView1.AllowUserToDeleteRows = false;
            this.reps_TableDataGridView1.AutoGenerateColumns = false;
            this.reps_TableDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reps_TableDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30});
            this.reps_TableDataGridView1.DataSource = this.reps_TableBindingSource;
            this.reps_TableDataGridView1.Enabled = false;
            this.reps_TableDataGridView1.Location = new System.Drawing.Point(735, 440);
            this.reps_TableDataGridView1.Name = "reps_TableDataGridView1";
            this.reps_TableDataGridView1.ReadOnly = true;
            this.reps_TableDataGridView1.Size = new System.Drawing.Size(300, 66);
            this.reps_TableDataGridView1.TabIndex = 44;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Rep_Id";
            this.dataGridViewTextBoxColumn29.HeaderText = "Rep_Id";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Rep_Name";
            this.dataGridViewTextBoxColumn30.HeaderText = "Rep_Name";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            // 
            // productTableBindingSource1
            // 
            this.productTableBindingSource1.DataMember = "Product_Table";
            this.productTableBindingSource1.DataSource = this.add_entry_ds;
            // 
            // batch_DateLabel3
            // 
            this.batch_DateLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returns_TableBindingSource, "Batch_Date", true));
            this.batch_DateLabel3.Location = new System.Drawing.Point(632, 223);
            this.batch_DateLabel3.Name = "batch_DateLabel3";
            this.batch_DateLabel3.Size = new System.Drawing.Size(100, 23);
            this.batch_DateLabel3.TabIndex = 46;
            this.batch_DateLabel3.Text = "label1";
            // 
            // label_current_state
            // 
            this.label_current_state.AutoSize = true;
            this.label_current_state.Location = new System.Drawing.Point(640, 131);
            this.label_current_state.Name = "label_current_state";
            this.label_current_state.Size = new System.Drawing.Size(41, 15);
            this.label_current_state.TabIndex = 47;
            this.label_current_state.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 48;
            this.label3.Text = "Current State:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(552, 588);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_current_state);
            this.Controls.Add(batch_DateLabel2);
            this.Controls.Add(this.batch_DateLabel3);
            this.Controls.Add(this.reps_TableDataGridView1);
            this.Controls.Add(this.reps_TableDataGridView);
            this.Controls.Add(this.faults_TableDataGridView);
            this.Controls.Add(this.product_TableDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.users_TableDataGridView);
            this.Controls.Add(user_signatureLabel);
            this.Controls.Add(this.user_signaturePictureBox);
            this.Controls.Add(manager_SignatureLabel);
            this.Controls.Add(this.manager_SignaturePictureBox);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.label_child_form);
            this.Controls.Add(this.customers_TableDataGridView);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add_new);
            this.Controls.Add(this.groupBox_info);
            this.Controls.Add(this.returns_TableDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Entry";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.current_record_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returns_TableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returns_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_entry_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_QtyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reps_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_entry_ds1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty_ReturnedNumericUpDown)).EndInit();
            this.groupBox_info.ResumeLayout(false);
            this.groupBox_info.PerformLayout();
            this.panel_add_new_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customers_TableDataGridView)).EndInit();
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manager_SignaturePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_signaturePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_TableDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_TableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faults_TableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reps_TableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reps_TableDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dataset.current_record_ds current_record_ds;
        private System.Windows.Forms.BindingSource returns_TableBindingSource;
        private Dataset.current_record_dsTableAdapters.Returns_TableTableAdapter returns_TableTableAdapter;
        private Dataset.current_record_dsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView returns_TableDataGridView;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.Label entry_IDLabel1;
        private System.Windows.Forms.DateTimePicker doc_DateDateTimePicker;
        private System.Windows.Forms.ComboBox product_NameComboBox;
        private System.Windows.Forms.NumericUpDown product_QtyNumericUpDown;
        private System.Windows.Forms.ComboBox customer_NameComboBox;
        private System.Windows.Forms.ComboBox user_RepComboBox;
        private System.Windows.Forms.ComboBox fault_DescriptionComboBox;
        private System.Windows.Forms.TextBox loyverse_Pastel_Doc_NumberTextBox;
        private System.Windows.Forms.NumericUpDown qty_ReturnedNumericUpDown;
        private System.Windows.Forms.ComboBox investigate_ResolvedComboBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.GroupBox groupBox_info;
        private System.Windows.Forms.Label entry_DateLabel1;
        private System.Windows.Forms.Button btn_add_new;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private Dataset.add_entry_ds add_entry_ds;
        private System.Windows.Forms.BindingSource productTableBindingSource;
        private Dataset.add_entry_dsTableAdapters.Product_TableTableAdapter product_TableTableAdapter;
        private System.Windows.Forms.BindingSource customersTableBindingSource;
        private Dataset.add_entry_dsTableAdapters.Customers_TableTableAdapter customers_TableTableAdapter;
        private System.Windows.Forms.BindingSource faultsTableBindingSource;
        private Dataset.add_entry_dsTableAdapters.Faults_TableTableAdapter faults_TableTableAdapter;
        private Dataset.add_entry_ds add_entry_ds1;
        private System.Windows.Forms.BindingSource repsTableBindingSource;
        private Dataset.add_entry_dsTableAdapters.Reps_TableTableAdapter reps_TableTableAdapter;
        private Dataset.add_entry_dsTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView customers_TableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        public System.Windows.Forms.Label label_child_form;
        private System.Windows.Forms.Button btn_add_new_customer;
        private System.Windows.Forms.Panel panel_add_new_data;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.Label managerLabel1;
        private System.Windows.Forms.PictureBox manager_SignaturePictureBox;
        private System.Windows.Forms.BindingSource users_TableBindingSource;
        private Dataset.add_entry_dsTableAdapters.Users_TableTableAdapter users_TableTableAdapter;
        private System.Windows.Forms.PictureBox user_signaturePictureBox;
        private System.Windows.Forms.DataGridView users_TableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label fault_IdLabel1;
        private System.Windows.Forms.BindingSource reps_TableBindingSource;
        private System.Windows.Forms.DataGridView product_TableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridView faults_TableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridView reps_TableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.TextBox f_fault_idTextBox;
        private System.Windows.Forms.TextBox f_rep_idTextBox;
        private System.Windows.Forms.TextBox f_prod_idTextBox;
        private System.Windows.Forms.TextBox f_cust_idTextBox;
        private System.Windows.Forms.Label product_IdLabel1;
        private System.Windows.Forms.Label customer_IdLabel1;
        private System.Windows.Forms.Button btn_add_new_product;
        private System.Windows.Forms.Button btn_add_new_fault_description;
        private System.Windows.Forms.Button btn_add_new_rep;
        private System.Windows.Forms.DataGridView reps_TableDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.Label rep_IdLabel1;
        private System.Windows.Forms.BindingSource productTableBindingSource1;
        private System.Windows.Forms.CheckBox checkBox_show_batch_dt_picker;
        private System.Windows.Forms.TextBox batch_DateTextBox;
        private System.Windows.Forms.Label batch_DateLabel3;
        private System.Windows.Forms.Label label_current_state;
        private System.Windows.Forms.Label label3;
    }
}

