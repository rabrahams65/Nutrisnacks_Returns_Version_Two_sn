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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void users_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.users_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.add_entry_ds);

        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'add_entry_ds.Users_Table' table. You can move, or remove it, as needed.
            this.users_TableTableAdapter.Fill_ex_info_users(this.add_entry_ds.Users_Table);

        }

        private void btn_add_new_Click(object sender, EventArgs e)
        {
            disable_aed_buttons();
            this.add_new_cond_label.Text = "Add New";
            this.users_TableBindingSource.AddNew();
            this.panel_new_user.Visible = true;


        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            disable_aed_buttons();
            this.label_current_state.Text = "Edit";
            //No record edit guard
            int rc;
            rc = this.add_entry_ds.Users_Table.Rows.Count;
            if (rc == 0)
            {
                MessageBox.Show("Please select a user to edit!");
                disable_sc_buttons();
                return;
            }
            //---------------------------------------------------------

            this.panel_new_user.Visible = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            disable_aed_buttons();
            enable_table_info();
            //No record delete guard
            int rc;
            rc = this.add_entry_ds.Users_Table.Rows.Count;
            if (rc == 0)
            {
                MessageBox.Show("Please select a user to delete!");
                disable_sc_buttons();
                return;
            }
            //---------------------------------------------------------


            //Prevent from deleting an admin
            if (this.user_roleLabel2.Text == "Admin")
            {
                MessageBox.Show("Can't delete Admin!");
                disable_sc_buttons();
                return;
            }
            //


            //Prevent users from deleting the last user available
            if (rc == 1)
            {
                MessageBox.Show("Cannot delete the last user available, add a new user and then delete this one!");
                disable_sc_buttons();
                return;
            }
            //
            //Permanently delete record
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this user? NO UNDO!", "Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    disable_sc_buttons();
                    this.users_TableBindingSource.RemoveCurrent();
                    this.users_TableBindingSource.EndEdit();

                    try
                    {
                        this.users_TableTableAdapter.Update(this.add_entry_ds.Users_Table);
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

            

            //---------------------Check if user has been added ----------------
            string user_textbox = this.usernameTextBox.Text;
            if (user_textbox == String.Empty)
            {
                MessageBox.Show("Please enter the name for the user before saving!");
                disable_aed_buttons();
                return;
            }
            //----------------------------------------------------------------------

            

            //
            //Check if passwords are the same

            string pass;
            string rpt_pass;
            pass = this.user_passwordTextBox.Text;
            rpt_pass = this.txt_rpt_pass.Text;
            if (pass != rpt_pass)
            {
                MessageBox.Show("Passwords do not match, try again!");
                disable_aed_buttons();
                return;
            }

            if (pass == string.Empty)
            {
                MessageBox.Show("Password can't be empty, try again!");
                disable_aed_buttons();
                return;
            }

            if (user_roleComboBox.Text == string.Empty)
            {
                MessageBox.Show("Please select a user role and try again!");
                disable_aed_buttons();
                return;
            }


            bool contains_at;
            bool contains_fs;
            contains_at = user_emailTextBox.Text.Contains("@");
            contains_fs = user_emailTextBox.Text.Contains(".");

            if (!contains_at || !contains_fs)
            {
                MessageBox.Show("Email address provided is not valid.Please try again!");
                disable_aed_buttons();
                return;
            }
            //



            if ( this.user_roleComboBox.Text == user_roleLabel2.Text)
            {
                //--- Check old password-------------------------------------------
                if (this.add_new_cond_label.Text != "Add New")
                {
                    Nutrisnacks_Returns_Version_Two.Child_Forms.confirm_password frm = new confirm_password();
                    frm.label_child_id.Text = this.user_IdLabel_main.Text;
                    frm.ShowDialog();


                    if (frm.DialogResult == DialogResult.OK)
                    {
                        //Save the data in the database
                        this.users_TableBindingSource.EndEdit();

                        try
                        {
                            this.users_TableTableAdapter.Update(this.add_entry_ds.Users_Table);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        //----------------------------------------------------------------------
                        this.panel_new_user.Visible = false;
                        //---------------------Check if item was saved -------------------------
                        Int64 rc;
                        rc = this.add_entry_ds.Users_Table.Rows.Count;
                        if (rc <= 0)
                        {
                            MessageBox.Show("Unable to save the record!");
                            this.panel_new_user.Visible = false;
                            return;
                        }
                        //----------------------------------------------------------------------
                    }
                    if (frm.DialogResult == DialogResult.Cancel)
                    {
                        disable_aed_buttons();
                        return;
                    }
                    //-----------------------------------------------------------------
                }


            }
            else
            {
                //Save the data in the database
                

                try
                {
                    if (this.label_current_state.Text == "Edit")
                    {
                        string nn;
                        string on;
                        nn = this.user_fnameTextBox.Text;
                        on = this.user_fnameLabel2.Text;
                        this.users_TableBindingSource.EndEdit();
                        this.users_TableTableAdapter.UpdateQuery_Update_Manager_Name(nn, on);
                        this.users_TableTableAdapter.Update(this.add_entry_ds.Users_Table);
                    }
                    else
                    {
                        this.users_TableBindingSource.EndEdit();
                        this.users_TableTableAdapter.Update(this.add_entry_ds.Users_Table);
                    }
                    this.label_current_state.Text = String.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //----------------------------------------------------------------------
                this.panel_new_user.Visible = false;
                //---------------------Check if item was saved -------------------------
                Int64 rc;
                rc = this.add_entry_ds.Users_Table.Rows.Count;
                if (rc <= 0)
                {
                    MessageBox.Show("Unable to save the record!");
                    this.panel_new_user.Visible = false;
                    return;
                }
                //----------------------------------------------------------------------
            }

            //----- Checks if password has been changed or not
            if (this.user_passwordTextBox.Text == this.user_passwordLabel2.Text)
            {
                //Save the data in the database
                this.users_TableBindingSource.EndEdit();

                try
                {
                    this.users_TableTableAdapter.Update(this.add_entry_ds.Users_Table);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //----------------------------------------------------------------------
                this.panel_new_user.Visible = false;
                //---------------------Check if item was saved -------------------------
                Int64 rc;
                rc = this.add_entry_ds.Users_Table.Rows.Count;
                if (rc <= 0)
                {
                    MessageBox.Show("Unable to save the record!");
                    this.panel_new_user.Visible = false;
                    return;
                }
                //----------------------------------------------------------------------
            }




            //Loads user again in sort mode
            try
            {
                this.users_TableTableAdapter.Fill_ex_info_users(this.add_entry_ds.Users_Table);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            disable_sc_buttons();
            this.label_current_state.Text = String.Empty;
            this.panel_new_user.Visible = false;
            this.users_TableBindingSource.CancelEdit();
            this.add_entry_ds.Users_Table.RejectChanges();
            disable_sc_buttons();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string user_name;
            user_name = this.txt_user_search.Text;

            try
            {
                this.users_TableTableAdapter.FillBy_ex_info_users_by_name(this.add_entry_ds.Users_Table, "%" + user_name + "%");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_cust_search_TextChanged(object sender, EventArgs e)
        {
            string user_name;
            user_name = this.txt_user_search.Text;

            try
            {
                this.users_TableTableAdapter.FillBy_ex_info_users_by_name(this.add_entry_ds.Users_Table, "%" + user_name + "%");
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
            this.users_TableDataGridView.Enabled = true;
            this.users_TableDataGridView.Visible = true;
            this.users_TableBindingNavigator.Enabled = true;
        }

        void disable_table_info()
        {
            this.users_TableDataGridView.Enabled = false;
            this.users_TableDataGridView.Visible = false;
            this.users_TableBindingNavigator.Enabled = false;
        }





        void revert()
        {
            this.users_TableBindingSource.CancelEdit();
            this.add_entry_ds.Users_Table.RejectChanges();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            string fn;
            this.openFileDialog1.ShowDialog();
            fn = this.openFileDialog1.FileName;
            if (fn == String.Empty)
            {
                return;
            }
            this.pictureBox_signature.Image = Image.FromFile(fn);
        }
    }
}
