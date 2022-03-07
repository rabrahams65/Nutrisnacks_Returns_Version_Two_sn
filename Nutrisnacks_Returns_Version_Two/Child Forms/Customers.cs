using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nutrisnacks_Returns_Version_Two.Child_Forms
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'add_entry_ds.Returns_Table' table. You can move, or remove it, as needed.
            this.returns_TableTableAdapter.Fill_nothing(this.add_entry_ds.Returns_Table);

            try
            {
                this.customers_TableTableAdapter.Fill_ex_info_customers(this.add_entry_ds.Customers_Table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cust_name;
            cust_name = this.txt_cust_search.Text;

            try
            {
                this.customers_TableTableAdapter.Fill_ex_info_customers_by_name(this.add_entry_ds.Customers_Table, "%" + cust_name + "%");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txt_cust_search_TextChanged(object sender, EventArgs e)
        {
            string cust_name;
            cust_name = this.txt_cust_search.Text;

            try
            {
                this.customers_TableTableAdapter.Fill_ex_info_customers_by_name(this.add_entry_ds.Customers_Table, "%" + cust_name + "%");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_add_new_Click(object sender, EventArgs e)
        {
            //this.customer_nameTextBox.Select();
            disable_aed_buttons();
            
            this.customers_TableBindingSource.AddNew();
            this.panel_new_cust.Visible = true;


         
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            disable_sc_buttons();
            this.label_current_state.Text = String.Empty;
            this.panel_new_cust.Visible = false;
            this.customers_TableBindingSource.CancelEdit();
            this.add_entry_ds.Customers_Table.RejectChanges();
            disable_sc_buttons();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            disable_aed_buttons();
            this.label_current_state.Text = "Edit";
            //No record edit guard
            int rc;
            rc = this.add_entry_ds.Customers_Table.Rows.Count;
            if (rc == 0)
            {
                MessageBox.Show("Please select a customer to delete!");
                disable_sc_buttons();
                return;
            }
            //---------------------------------------------------------
            //this.customer_nameTextBox.Select();
            this.panel_new_cust.Visible = true;


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            disable_aed_buttons();
            enable_table_info();
            //No record delete guard
            int rc;
            rc = this.add_entry_ds.Customers_Table.Rows.Count;
            if (rc == 0)
            {
                MessageBox.Show("Please select a customer to delete!");
                disable_sc_buttons();
                return;
            }
            //---------------------------------------------------------
            //Permanently delete record
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this customer? NO UNDO!", "Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    disable_sc_buttons();
                    this.customers_TableBindingSource.RemoveCurrent();
                    this.customers_TableBindingSource.EndEdit();

                    try
                    {
                        this.customers_TableTableAdapter.Update(this.add_entry_ds.Customers_Table);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                    //this.Close();
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


            //---------------------Check if customer has been added ----------------
            string cust_textbox = this.customer_nameTextBox.Text;
            if (cust_textbox == String.Empty)
            {
                MessageBox.Show("Please enter the name for the customer before saving!");
                disable_aed_buttons();
                return;
            }
            //----------------------------------------------------------------------

            //Save the data in the database
            

            try
            {
                if (this.label_current_state.Text == "Edit")
                {
                    string nn;
                    string on;
                    nn = this.customer_nameTextBox.Text;
                    on = this.customer_nameLabel2.Text;
                    this.customers_TableBindingSource.EndEdit();
                    this.returns_TableTableAdapter.UpdateQuery_Update_Cust_Name(nn, on);
                    this.customers_TableTableAdapter.Update(this.add_entry_ds.Customers_Table);
                }
                else
                {
                    this.customers_TableBindingSource.EndEdit();
                    this.customers_TableTableAdapter.Update(this.add_entry_ds.Customers_Table);
                }
                this.label_current_state.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            //----------------------------------------------------------------------
            this.panel_new_cust.Visible = false;
            //---------------------Check if item was saved -------------------------
            Int64 rc;
            rc = this.add_entry_ds.Customers_Table.Rows.Count;
            if (rc <= 0)
            {
                MessageBox.Show("Unable to save the record!");
                this.panel_new_cust.Visible = false;
                return;
            }
            //----------------------------------------------------------------------

            //Loads customers again in sort mode
            try
            {
                this.customers_TableTableAdapter.Fill_ex_info_customers(this.add_entry_ds.Customers_Table);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

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

            enable_table_info();
        }

        void enable_sc_buttons()
        {
            this.btn_save.Enabled = true;
            this.btn_cancel.Enabled = true;

           disable_table_info();
        }


        void enable_table_info()
        {
            this.customers_TableDataGridView.Enabled = true;
            this.customers_TableDataGridView.Visible = true;
            this.customers_TableBindingNavigator.Enabled = true;
        }

        void disable_table_info()
        {
            this.customers_TableDataGridView.Enabled = false;
            this.customers_TableDataGridView.Visible = false;
            this.customers_TableBindingNavigator.Enabled = false;
        }





        void revert()
        {
            this.customers_TableBindingSource.CancelEdit();
            this.add_entry_ds.Customers_Table.RejectChanges();
        }
        #endregion

    }
}
