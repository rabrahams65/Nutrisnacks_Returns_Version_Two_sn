
namespace Nutrisnacks_Returns_Version_Two.Child_Forms
{
    partial class confirm_password
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
            System.Windows.Forms.Label user_passwordLabel;
            System.Windows.Forms.Label user_passwordLabel1;
            this.add_entry_ds = new Nutrisnacks_Returns_Version_Two.Dataset.add_entry_ds();
            this.users_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.users_TableTableAdapter = new Nutrisnacks_Returns_Version_Two.Dataset.add_entry_dsTableAdapters.Users_TableTableAdapter();
            this.tableAdapterManager = new Nutrisnacks_Returns_Version_Two.Dataset.add_entry_dsTableAdapters.TableAdapterManager();
            this.user_passwordTextBox = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.label_child_id = new System.Windows.Forms.Label();
            this.user_passwordLabel2 = new System.Windows.Forms.Label();
            user_passwordLabel = new System.Windows.Forms.Label();
            user_passwordLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.add_entry_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_TableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // user_passwordLabel
            // 
            user_passwordLabel.AutoSize = true;
            user_passwordLabel.Location = new System.Drawing.Point(30, 59);
            user_passwordLabel.Name = "user_passwordLabel";
            user_passwordLabel.Size = new System.Drawing.Size(132, 15);
            user_passwordLabel.TabIndex = 1;
            user_passwordLabel.Text = "Confirm Old Password:";
            // 
            // user_passwordLabel1
            // 
            user_passwordLabel1.AutoSize = true;
            user_passwordLabel1.Location = new System.Drawing.Point(589, 21);
            user_passwordLabel1.Name = "user_passwordLabel1";
            user_passwordLabel1.Size = new System.Drawing.Size(90, 15);
            user_passwordLabel1.TabIndex = 5;
            user_passwordLabel1.Text = "user password:";
            // 
            // add_entry_ds
            // 
            this.add_entry_ds.DataSetName = "add_entry_ds";
            this.add_entry_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Categories_TableTableAdapter = null;
            this.tableAdapterManager.Customers_TableTableAdapter = null;
            this.tableAdapterManager.Faults_TableTableAdapter = null;
            this.tableAdapterManager.Product_TableTableAdapter = null;
            this.tableAdapterManager.Reps_TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Nutrisnacks_Returns_Version_Two.Dataset.add_entry_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Users_TableTableAdapter = this.users_TableTableAdapter;
            // 
            // user_passwordTextBox
            // 
            this.user_passwordTextBox.Location = new System.Drawing.Point(168, 56);
            this.user_passwordTextBox.Name = "user_passwordTextBox";
            this.user_passwordTextBox.PasswordChar = '*';
            this.user_passwordTextBox.Size = new System.Drawing.Size(161, 21);
            this.user_passwordTextBox.TabIndex = 2;
            this.user_passwordTextBox.TextChanged += new System.EventHandler(this.user_passwordTextBox_TextChanged);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(212, 83);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 3;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // label_child_id
            // 
            this.label_child_id.AutoSize = true;
            this.label_child_id.Location = new System.Drawing.Point(619, 62);
            this.label_child_id.Name = "label_child_id";
            this.label_child_id.Size = new System.Drawing.Size(11, 15);
            this.label_child_id.TabIndex = 5;
            this.label_child_id.Text = "-";
            // 
            // user_passwordLabel2
            // 
            this.user_passwordLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.users_TableBindingSource, "user_password", true));
            this.user_passwordLabel2.Location = new System.Drawing.Point(685, 21);
            this.user_passwordLabel2.Name = "user_passwordLabel2";
            this.user_passwordLabel2.Size = new System.Drawing.Size(100, 23);
            this.user_passwordLabel2.TabIndex = 6;
            this.user_passwordLabel2.Text = "label1";
            // 
            // confirm_password
            // 
            this.AcceptButton = this.btn_confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 150);
            this.Controls.Add(user_passwordLabel1);
            this.Controls.Add(this.user_passwordLabel2);
            this.Controls.Add(this.label_child_id);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(user_passwordLabel);
            this.Controls.Add(this.user_passwordTextBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "confirm_password";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm Old Password";
            this.Load += new System.EventHandler(this.confirm_password_Load);
            ((System.ComponentModel.ISupportInitialize)(this.add_entry_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_TableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dataset.add_entry_ds add_entry_ds;
        private System.Windows.Forms.BindingSource users_TableBindingSource;
        private Dataset.add_entry_dsTableAdapters.Users_TableTableAdapter users_TableTableAdapter;
        private Dataset.add_entry_dsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox user_passwordTextBox;
        private System.Windows.Forms.Button btn_confirm;
        public System.Windows.Forms.Label label_child_id;
        private System.Windows.Forms.Label user_passwordLabel2;
    }
}