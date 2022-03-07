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
    public partial class Reps : Form
    {
        public Reps()
        {
            InitializeComponent();
        }

        private void Reps_Load(object sender, EventArgs e)
        {
            this.reps_TableTableAdapter.Fill_ex_info_reps(this.add_entry_ds.Reps_Table);
        }

        private void btn_add_new_Click(object sender, EventArgs e)
        {
            disable_aed_buttons();
            this.reps_TableBindingSource.AddNew();
            this.panel_new_rep.Visible = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            disable_aed_buttons();
            this.label_current_state.Text = "Edit";
            //No record edit guard
            int rc;
            rc = this.add_entry_ds.Reps_Table.Rows.Count;
            if (rc == 0)
            {
                MessageBox.Show("Please select a rep to delete!");
                disable_sc_buttons();
                return;
            }
            //---------------------------------------------------------

            this.panel_new_rep.Visible = true;


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            disable_aed_buttons();
            enable_table_info();
            //No record delete guard
            int rc;
            rc = this.add_entry_ds.Reps_Table.Rows.Count;
            if (rc == 0)
            {
                MessageBox.Show("Please select a rep to delete!");
                disable_sc_buttons();
                return;
            }
            //---------------------------------------------------------
            //Permanently delete record
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this rep? NO UNDO!", "Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    disable_sc_buttons();
                    this.reps_TableBindingSource.RemoveCurrent();
                    this.reps_TableBindingSource.EndEdit();

                    try
                    {
                        this.reps_TableTableAdapter.Update(this.add_entry_ds.Reps_Table);
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


            //---------------------Check if rep has been added ----------------
            string rep_textbox = this.rep_nameTextBox.Text;
            if (rep_textbox == String.Empty)
            {
                MessageBox.Show("Please enter the name for the rep before saving!");
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
                    nn = this.rep_nameTextBox.Text;
                    on = this.rep_NameLabel2.Text;
                    this.reps_TableBindingSource.EndEdit();
                    this.reps_TableTableAdapter.UpdateQuery_Update_Rep_Name(nn, on);
                    this.reps_TableTableAdapter.Update(this.add_entry_ds.Reps_Table);
                }
                else
                {
                    this.reps_TableBindingSource.EndEdit();
                    this.reps_TableTableAdapter.Update(this.add_entry_ds.Reps_Table);
                }
                this.label_current_state.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //----------------------------------------------------------------------
            this.panel_new_rep.Visible = false;
            //---------------------Check if item was saved -------------------------
            Int64 rc;
            rc = this.add_entry_ds.Reps_Table.Rows.Count;
            if (rc <= 0)
            {
                MessageBox.Show("Unable to save the record!");
                this.panel_new_rep.Visible = false;
                return;
            }
            //----------------------------------------------------------------------

            //Loads reps again in sort mode
            try
            {
                this.reps_TableTableAdapter.Fill_ex_info_reps(this.add_entry_ds.Reps_Table);
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
            this.panel_new_rep.Visible = false;
            this.reps_TableBindingSource.CancelEdit();
            this.add_entry_ds.Reps_Table.RejectChanges();
            disable_sc_buttons();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string rep_name;
            rep_name = this.txt_rep_search.Text;

            try
            {
                this.reps_TableTableAdapter.FillBy_ex_info_rep_by_name(this.add_entry_ds.Reps_Table, "%" + rep_name + "%");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_rep_search_TextChanged(object sender, EventArgs e)
        {
            string rep_name;
            rep_name = this.txt_rep_search.Text;

            try
            {
                this.reps_TableTableAdapter.FillBy_ex_info_rep_by_name(this.add_entry_ds.Reps_Table, "%" + rep_name + "%");
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
            this.reps_TableDataGridView.Enabled = true;
            this.reps_TableDataGridView.Visible = true;
            this.reps_TableBindingNavigator.Enabled = true;
        }

        void disable_table_info()
        {
            this.reps_TableDataGridView.Enabled = false;
            this.reps_TableDataGridView.Visible = false;
            this.reps_TableBindingNavigator.Enabled = false;
        }





        void revert()
        {
            this.reps_TableBindingSource.CancelEdit();
            this.add_entry_ds.Reps_Table.RejectChanges();
        }
        #endregion
    }
}
