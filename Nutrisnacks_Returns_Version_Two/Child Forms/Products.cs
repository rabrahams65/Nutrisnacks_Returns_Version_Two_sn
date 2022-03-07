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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'add_entry_ds.Product_Table' table. You can move, or remove it, as needed.
            this.product_TableTableAdapter.Fill_ex_info_products(this.add_entry_ds.Product_Table);

        }

        private void btn_add_new_Click_1(object sender, EventArgs e)
        {
            disable_aed_buttons();
            this.product_TableBindingSource.AddNew();
            this.panel_new_prod.Visible = true;



        }

        private void btn_edit_Click_1(object sender, EventArgs e)
        {
            disable_aed_buttons();
            this.label_current_state.Text = "Edit";

            //load product by id (to edit prices etc)...
            long prod_id;
            long.TryParse(this.product_IdLabel1.Text, out prod_id);
            this.product_TableTableAdapter.FillBy_prod_id(this.add_entry_ds.Product_Table, prod_id);
            //
            //No record edit guard
            int rc;
            rc = this.add_entry_ds.Product_Table.Rows.Count;
            if (rc == 0)
            {
                MessageBox.Show("Please select a product to delete!");
                disable_sc_buttons();
                return;
            }
            //---------------------------------------------------------

            this.panel_new_prod.Visible = true;


        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            disable_aed_buttons();
            enable_table_info();
            //No record delete guard
            int rc;
            rc = this.add_entry_ds.Product_Table.Rows.Count;
            if (rc == 0)
            {
                MessageBox.Show("Please select a product to delete!");
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
                    this.product_TableBindingSource.RemoveCurrent();
                    this.product_TableBindingSource.EndEdit();

                    try
                    {
                        this.product_TableTableAdapter.Update(this.add_entry_ds.Product_Table);
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

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            disable_sc_buttons();


            //---------------------Check if product has been added ----------------
            string cust_textbox = this.product_nameTextBox.Text;
            if (cust_textbox == String.Empty)
            {
                MessageBox.Show("Please enter the name of the product before saving!");
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
                    nn = this.product_nameTextBox.Text;
                    on = this.product_NameLabel2.Text;
                    this.product_TableBindingSource.EndEdit();
                    this.product_TableTableAdapter.UpdateQuery_Update_Prod_Name(nn, on);
                    this.product_TableTableAdapter.Update(this.add_entry_ds.Product_Table);
                }
                else
                {
                    this.product_TableBindingSource.EndEdit();
                    this.product_TableTableAdapter.Update(this.add_entry_ds.Product_Table);
                }
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //----------------------------------------------------------------------
            this.panel_new_prod.Visible = false;
            //---------------------Check if item was saved -------------------------
            Int64 rc;
            rc = this.add_entry_ds.Product_Table.Rows.Count;
            if (rc <= 0)
            {
                MessageBox.Show("Unable to save the record!");
                this.panel_new_prod.Visible = false;
                return;
            }
            //----------------------------------------------------------------------

            //Loads customers again in sort mode
            try
            {
                this.product_TableTableAdapter.Fill_ex_info_products(this.add_entry_ds.Product_Table);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            disable_sc_buttons();
            this.label_current_state.Text = String.Empty;
            this.panel_new_prod.Visible = false;
            this.product_TableBindingSource.CancelEdit();
            this.add_entry_ds.Product_Table.RejectChanges();
            disable_sc_buttons();
            this.product_TableTableAdapter.Fill_ex_info_products(this.add_entry_ds.Product_Table);
        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            string prod_name;
            prod_name = this.txt_prod_search.Text;

            try
            {
                this.product_TableTableAdapter.FillBy_ex_info_product_by_name(this.add_entry_ds.Product_Table, "%" + prod_name + "%");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_prod_search_TextChanged_1(object sender, EventArgs e)
        {
            string prod_name;
            prod_name = this.txt_prod_search.Text;

            try
            {
                this.product_TableTableAdapter.FillBy_ex_info_product_by_name(this.add_entry_ds.Product_Table, "%" + prod_name + "%");
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
            this.products_TableDataGridView.Enabled = true;
            this.products_TableDataGridView.Visible = true;
            this.product_TableBindingNavigator.Enabled = true;
        }

        void disable_table_info()
        {
            this.products_TableDataGridView.Enabled = false;
            this.products_TableDataGridView.Visible = false;
            this.product_TableBindingNavigator.Enabled = false;
        }





        void revert()
        {
            this.product_TableBindingSource.CancelEdit();
            this.add_entry_ds.Product_Table.RejectChanges();
        }

        #endregion


    }
}
