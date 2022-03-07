using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nutrisnacks_Returns_Version_Two
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'add_entry_ds.Users_Table' table. You can move, or remove it, as needed.
            this.users_TableTableAdapter.Fill_ex_info_users(this.add_entry_ds.Users_Table);
            // TODO: This line of code loads data into the 'add_entry_ds1.Reps_Table' table. You can move, or remove it, as needed.
            this.reps_TableTableAdapter.Fill_ex_info_reps(this.add_entry_ds1.Reps_Table);
            this.reps_TableTableAdapter.Fill_ex_info_reps(this.add_entry_ds.Reps_Table);
            // TODO: This line of code loads data into the 'add_entry_ds.Faults_Table' table. You can move, or remove it, as needed.
            this.faults_TableTableAdapter.Fill_ex_info_faults(this.add_entry_ds.Faults_Table);
            // TODO: This line of code loads data into the 'add_entry_ds.Customers_Table' table. You can move, or remove it, as needed.
            this.customers_TableTableAdapter.Fill_ex_info_customers(this.add_entry_ds.Customers_Table);
            // TODO: This line of code loads data into the 'add_entry_ds.Product_Table' table. You can move, or remove it, as needed.
            this.product_TableTableAdapter.Fill_ex_info_products(this.add_entry_ds.Product_Table);

            this.returns_TableTableAdapter.Fill_current_record(this.current_record_ds.Returns_Table);


            

            set_the_entry_date();

            


            //------------------------------- Load entry id of parent form or default table-----------------------------------
            if (this.label_child_form.Text == String.Empty)
            {
                this.returns_TableTableAdapter.FillBy_default_all(this.current_record_ds.Returns_Table);
            }
            else
            {
                long entry_id_arg;
                long.TryParse(this.label_child_form.Text, out entry_id_arg);
                this.returns_TableTableAdapter.Fill_current_record_by_entry_id(this.current_record_ds.Returns_Table, entry_id_arg);
            }
            
            //------------------------------------------------------------------------------------------------------------

            //------------------------------- Disable the groupbox, Save and Cancel buttons-------------------------------
            disable_groupbox_info();
            disable_sc_buttons();
            //------------------------------------------------------------------------------------------------------------
            string panel;
            panel = Nutrisnacks_Returns_Version_Two.Properties.Settings.Default.app_user_role;

            if (panel == "Viewer")
            {
                this.panel_add_new_data.Visible = false;

            }

            
        }








       

        private void btn_add_new_Click(object sender, EventArgs e)
        {
            this.label_current_state.Text = "Add New";
            disable_aed_buttons();

            //Focus on first entry box
            this.doc_DateDateTimePicker.Focus();

            //Limit date to date to today - ADDED ON 10 FEB 2022
            System.DateTime today = System.DateTime.Now;
            this.doc_DateDateTimePicker.MaxDate = today.AddDays(1);

            //Add new record
            this.panel_footer.Visible = false;
            this.returns_TableBindingSource.AddNew();

            //Reset the data in the boxes
            this.customer_NameComboBox.SelectedIndex = -1;
            this.fault_DescriptionComboBox.SelectedIndex = -1;
            this.investigate_ResolvedComboBox.SelectedIndex = -1;
            this.product_NameComboBox.SelectedIndex = -1;
            this.user_RepComboBox.SelectedIndex = -1;
            this.product_QtyNumericUpDown.Value = 0;
            this.qty_ReturnedNumericUpDown.Value = 0;
            this.batch_DateTextBox.Enabled = false;
            this.batch_DateTextBox.Text = "No Date";
            //

            this.checkBox_show_batch_dt_picker.Checked = true;


            set_the_dates();
            save_user_fname();
            //
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            //Set the current state
            this.label_current_state.Text = "Edit";
            //

            //Focus on first entry box
            this.doc_DateDateTimePicker.Focus();

            disable_aed_buttons();

            //---------------------- No row to edit guard --------------------------------
            int rc;
            rc = this.current_record_ds.Returns_Table.Rows.Count;
            if (rc == 0)
            {
                MessageBox.Show("Please select a record to edit!");
                disable_sc_buttons();
                return;
            }
            //----------------------------------------------------------------------------

            

            //Enable and disable No date textbox
            if (this.batch_DateLabel3.Text == "No Date")
            {
                this.batch_DateTextBox.Enabled = false;
                this.checkBox_show_batch_dt_picker.Checked = true;
            }
            else
            {
                this.batch_DateTextBox.Enabled = true;
                this.checkBox_show_batch_dt_picker.Checked = false;
            }

            //


            //save_user_fname();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            disable_aed_buttons();
            disable_groupbox_info();


            //No record delete guard
            int rc;
            rc = this.current_record_ds.Returns_Table.Rows.Count;
            if (rc == 0)
            {
                MessageBox.Show("Please select a record to delete!");
                disable_sc_buttons();
                return;
            }
            //---------------------------------------------------------

            //Permanently delete record
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record? NO UNDO!", "Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    disable_sc_buttons();
                    this.returns_TableBindingSource.RemoveCurrent();
                    this.returns_TableBindingSource.EndEdit();
                    this.returns_TableTableAdapter.Update(this.current_record_ds.Returns_Table);
                    this.Close();
                }
                else
                {
                    disable_sc_buttons();
                    revert();
                    return;
                }
            }
            //----------------------------------------------------------

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            disable_sc_buttons();

            

            //Save the id's
            this.f_cust_idTextBox.Text = this.customer_IdLabel1.Text;
            this.f_fault_idTextBox.Text = this.fault_IdLabel1.Text;
            this.f_prod_idTextBox.Text = this.product_IdLabel1.Text;
            this.f_rep_idTextBox.Text = this.rep_IdLabel1.Text;
            //

            //Save the values
            this.customer_NameComboBox.SelectedIndex = this.customer_NameComboBox.SelectedIndex;
            this.fault_DescriptionComboBox.SelectedIndex = this.fault_DescriptionComboBox.SelectedIndex;
            this.investigate_ResolvedComboBox.SelectedIndex = this.investigate_ResolvedComboBox.SelectedIndex;
            this.product_NameComboBox.SelectedIndex = this.product_NameComboBox.SelectedIndex;
            this.user_RepComboBox.SelectedIndex = this.user_RepComboBox.SelectedIndex;
            this.product_QtyNumericUpDown.Value = this.product_QtyNumericUpDown.Value;
            this.qty_ReturnedNumericUpDown.Value = this.qty_ReturnedNumericUpDown.Value;

            //

            



            string combobox = this.customer_NameComboBox.Text;
            //---------------------Check if customer has been added ----------------
            if (combobox == String.Empty)
            {
                MessageBox.Show("Please select a customer!");
                disable_aed_buttons();
                return;
            }
            //----------------------------------------------------------------------


            //Check if product has been added
            if (this.product_NameComboBox.Text == String.Empty)
            {
                MessageBox.Show("Please select a Product!");
                disable_aed_buttons();
                return;
            }


            //---------------------Check if batch date and invoice date are the same ------------------------
            //if (this.batch_DateDateTimePicker.Value == this.doc_DateDateTimePicker.Value)
            //{
            //    MessageBox.Show("Batch date and Invoice date can't be similar, please try again!");
            //    disable_aed_buttons();
            //    return;
            //}
            //----------------------------------------------------------------------

            //----------------------Check if batch date is checked or not-----------

            //----------------------------------------------------------------------






            //Check if date is in the correct format - ADDED ON 6 October 2021

            DateTime vd = new DateTime();

            bool iv;

            iv = DateTime.TryParse(this.batch_DateTextBox.Text, out vd);

            if (!iv && this.batch_DateTextBox.Text != "No Date")
            {
                MessageBox.Show("Invalid Batch Date!");
                this.batch_DateTextBox.Clear();
                disable_aed_buttons();
                this.batch_DateTextBox.Focus();
                return;
            }

            //Checks if batch date is more than 6 months - ADDED ON 10 Jan 2022
            DateTime inValidBatchDate;
            DateTime textDate;
            DateTime today = DateTime.Now;
            DateTime.TryParse(this.batch_DateTextBox.Text, out textDate);
            inValidBatchDate = today.AddMonths(6);


            var result = inValidBatchDate.Month - textDate.Month;
            


            if (this.batch_DateTextBox.Text != "No Date" && result < 0 )
            {
                DialogResult result1 = MessageBox.Show("Are you sure this is a valid batch date: " + this.batch_DateTextBox.Text, "Warning!", MessageBoxButtons.YesNo);

                if (result1 != DialogResult.Yes)
                {
                    disable_aed_buttons();
                    return;
                }
            }

            //----------------------------------------------------------------------
            //----------------------------------------------------------------------





            //---------------------Check if customer exists -------------------------
            string ec;
            ec = this.customer_NameComboBox.Text;

            Int64 contains;

            contains = this.customers_TableTableAdapter.Fill_ex_info_customers_by_name(this.add_entry_ds.Customers_Table, ec);

            if (contains <= 0)
            {
                MessageBox.Show("Customer does not exist!");
                this.customers_TableTableAdapter.Fill_ex_info_customers(this.add_entry_ds.Customers_Table);
                revert();
                disable_aed_buttons();
                return;
            }
            else
            {
                this.customers_TableTableAdapter.Fill_ex_info_customers(this.add_entry_ds.Customers_Table);
            }

            
            //----------------------------------------------------------------------


            //--------------------- Check if product exists ------------------------
            string ep;
            ep = this.product_NameComboBox.Text;

            Int64 contains_product;

            contains_product = this.product_TableTableAdapter.FillBy_ex_info_product_by_name(this.add_entry_ds.Product_Table, ep);

            if (contains_product <= 0)
            {
                MessageBox.Show("Product does not exist!");
                this.product_TableTableAdapter.Fill_ex_info_products(this.add_entry_ds.Product_Table);
                revert();
                disable_aed_buttons();
                return;
            }
            else
            {
                this.product_TableTableAdapter.Fill_ex_info_products(this.add_entry_ds.Product_Table);
            }
            //----------------------------------------------------------------------

            //save signature
            this.users_TableTableAdapter.FillBy_image(this.add_entry_ds.Users_Table, this.managerLabel1.Text);
            this.manager_SignaturePictureBox.Image = this.user_signaturePictureBox.Image;
            //


           

            //Save the data in the database
            save_user_fname();
            this.returns_TableBindingSource.EndEdit();
            this.returns_TableTableAdapter.Update(this.current_record_ds.Returns_Table);
            //----------------------------------------------------------------------

            //---------------------Check if item was saved -------------------------
            Int64 rc;
            rc = this.current_record_ds.Returns_Table.Rows.Count;
            if (rc <= 0)
            {
                MessageBox.Show("Unable to save the record!");
                return;
            }
            //----------------------------------------------------------------------
            this.panel_footer.Visible = true;

            this.label_current_state.Text = String.Empty;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.returns_TableBindingSource.CancelEdit();
            this.current_record_ds.Returns_Table.RejectChanges();
            disable_sc_buttons();
        }

        private void btn_add_new_customer_Click(object sender, EventArgs e)
        {
            Nutrisnacks_Returns_Version_Two.Child_Forms.Customers frm = new Child_Forms.Customers();
            frm.ShowDialog();
            this.customers_TableTableAdapter.Fill_ex_info_customers(this.add_entry_ds.Customers_Table);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nutrisnacks_Returns_Version_Two.Child_Forms.Products frm = new Child_Forms.Products();
            frm.ShowDialog();
            this.product_TableTableAdapter.Fill_ex_info_products(this.add_entry_ds.Product_Table);
        }

        private void btn_add_new_rep_Click(object sender, EventArgs e)
        {
            Nutrisnacks_Returns_Version_Two.Child_Forms.Reps frm = new Child_Forms.Reps();
            frm.ShowDialog();
            this.reps_TableTableAdapter.Fill_ex_info_reps(this.add_entry_ds.Reps_Table);
            
        }

        private void btn_add_new_fault_description_Click(object sender, EventArgs e)
        {
            Nutrisnacks_Returns_Version_Two.Child_Forms.Faults frm = new Child_Forms.Faults();
            frm.ShowDialog();
            this.faults_TableTableAdapter.Fill_ex_info_faults(this.add_entry_ds.Faults_Table);
        }






        #region Private Helpers
        void disable_aed_buttons()
        {
            this.btn_add_new.Enabled = false;
            this.btn_edit.Enabled = false;
            this.btn_delete.Enabled = false;
            enable_sc_buttons();
        }

        void disable_sc_buttons()
        {
            this.btn_save.Enabled = false;
            this.btn_cancel.Enabled = false;

            enable_aed_buttons();
        }

        void enable_aed_buttons()
        {
            this.btn_add_new.Enabled = true;
            this.btn_edit.Enabled = true;
            this.btn_delete.Enabled = true;

            disable_groupbox_info();
        }

        void enable_sc_buttons()
        {
            this.btn_save.Enabled = true;
            this.btn_cancel.Enabled = true;
            
            enable_groupbox_info();
        }










        void enable_groupbox_info()
        {
            this.groupBox_info.Enabled = true;
        }

        void disable_groupbox_info()
        {
            this.groupBox_info.Enabled = false;
        }





        void set_the_dates()
        {
            System.DateTime entry_date = new DateTime();
            entry_date = System.DateTime.Now;
            this.entry_DateLabel1.Text = entry_date.ToShortDateString();
            //this.batch_DateDateTimePicker.Value = entry_date;
            this.doc_DateDateTimePicker.Value = entry_date;
        }

        void set_the_entry_date()
        {
            System.DateTime entry_date = new DateTime();
            entry_date = System.DateTime.Now;
            this.entry_DateLabel1.Text = entry_date.ToShortDateString();
        }


        void revert()
        {
            //this.returns_TableBindingSource.CancelEdit();
            this.current_record_ds.Returns_Table.RejectChanges();
        }

        void save_user_fname()
        {
            this.managerLabel1.Text = Nutrisnacks_Returns_Version_Two.Properties.Settings.Default.app_user_f_name;
        }





        #endregion

        private void checkBox_show_batch_dt_picker_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_show_batch_dt_picker.Checked == false)
            {

                
                if (this.label_current_state.Text == "Edit")
                {
                    this.batch_DateTextBox.Enabled = true;
                    this.batch_DateTextBox.Text = this.batch_DateLabel3.Text;

                    if (this.batch_DateLabel3.Text == "No Date")
                    {
                        this.batch_DateTextBox.Enabled = true;
                        this.batch_DateTextBox.Text = String.Empty;
                    }



                }
                if ( this.label_current_state.Text == "Add New" || this.batch_DateLabel3.Text == String.Empty)
                {
                    
                   
                        this.batch_DateTextBox.Enabled = true;
                        this.batch_DateTextBox.Text = String.Empty;
                   
                    
                }

     

            }
            if (this.checkBox_show_batch_dt_picker.Checked == true)
            {
                this.batch_DateTextBox.Enabled = false;
                this.batch_DateTextBox.Text = "No Date";
            }

        }

        private void batch_DateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //this.batch_DateDateTimePicker.Format = DateTimePickerFormat.Short;
            //this.batch_DateTextBox.Text = this.batch_DateDateTimePicker.Value.ToString();
        }

        private void batch_DateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool handled = false;
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case '/':
                case 'N':
                case 'o':
                case ' ':
                case 'D':
                case 'a':
                case 't':
                case 'e':
                case (char)Keys.Back:
                case (char)Keys.Delete:
                    break;
                default:
                    handled = true;
                    break;
            }

            if (!handled)
            {
                base.OnKeyPress(e);
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
