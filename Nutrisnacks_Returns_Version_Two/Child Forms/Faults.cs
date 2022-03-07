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
    public partial class Faults : Form
    {
        public Faults()
        {
            InitializeComponent();
        }

        private void Faults_Load(object sender, EventArgs e)
        {
            this.faults_TableTableAdapter.Fill_ex_info_faults(this.add_entry_ds.Faults_Table);
        }

        private void btn_add_new_Click(object sender, EventArgs e)
        {
            disable_aed_buttons();
            this.faults_TableBindingSource.AddNew();
            this.panel_new_fault.Visible = true;



        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            disable_aed_buttons();
            this.label_current_state.Text = "Edit";
            //No record edit guard
            int rc;
            rc = this.add_entry_ds.Faults_Table.Rows.Count;
            if (rc == 0)
            {
                MessageBox.Show("Please select a fault to delete!");
                disable_sc_buttons();
                return;
            }
            //---------------------------------------------------------

            this.panel_new_fault.Visible = true;


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            disable_aed_buttons();
            enable_table_info();
            //No record delete guard
            int rc;
            rc = this.add_entry_ds.Faults_Table.Rows.Count;
            if (rc == 0)
            {
                MessageBox.Show("Please select a fault to delete!");
                disable_sc_buttons();
                return;
            }
            //---------------------------------------------------------
            //Permanently delete record
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this fault? NO UNDO!", "Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    disable_sc_buttons();
                    this.faults_TableBindingSource.RemoveCurrent();
                    this.faults_TableBindingSource.EndEdit();

                    try
                    {
                        this.faults_TableTableAdapter.Update(this.add_entry_ds.Faults_Table);
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
            

            //---------------------Check if fault has been added ----------------
            string fault_textbox = this.fault_nameTextBox.Text;
            if (fault_textbox == String.Empty)
            {
                MessageBox.Show("Please enter the name for the fault before saving!");
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
                    nn = this.fault_nameTextBox.Text;
                    on = this.fault_NameLabel1.Text;
                    this.faults_TableBindingSource.EndEdit();
                    this.faults_TableTableAdapter.UpdateQuery_Update_Fault_Name(nn, on);
                    this.faults_TableTableAdapter.Update(this.add_entry_ds.Faults_Table);
                }
                else
                {
                    this.faults_TableBindingSource.EndEdit();
                    this.faults_TableTableAdapter.Update(this.add_entry_ds.Faults_Table);
                }
                this.label_current_state.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //----------------------------------------------------------------------
            this.panel_new_fault.Visible = false;
            //---------------------Check if item was saved -------------------------
            Int64 rc;
            rc = this.add_entry_ds.Faults_Table.Rows.Count;
            if (rc <= 0)
            {
                MessageBox.Show("Unable to save the record!");
                this.panel_new_fault.Visible = false;
                return;
            }
            //----------------------------------------------------------------------

            //Loads faults again in sort mode
            try
            {
                this.faults_TableTableAdapter.Fill_ex_info_faults(this.add_entry_ds.Faults_Table);
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
            this.panel_new_fault.Visible = false;
            this.faults_TableBindingSource.CancelEdit();
            this.add_entry_ds.Faults_Table.RejectChanges();
            disable_sc_buttons();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string fault_name;
            fault_name = this.txt_fault_search.Text;

            try
            {
                this.faults_TableTableAdapter.FillBy_ex_info_fault_by_name(this.add_entry_ds.Faults_Table, "%" + fault_name + "%");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_fault_search_TextChanged(object sender, EventArgs e)
        {
            string fault_name;
            fault_name = this.txt_fault_search.Text;

            try
            {
                this.faults_TableTableAdapter.FillBy_ex_info_fault_by_name(this.add_entry_ds.Faults_Table, "%" + fault_name + "%");
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
            this.faults_TableDataGridView.Enabled = true;
            this.faults_TableDataGridView.Visible = true;
            this.faults_TableBindingNavigator.Enabled = true;
        }

        void disable_table_info()
        {
            this.faults_TableDataGridView.Enabled = false;
            this.faults_TableDataGridView.Visible = false;
            this.faults_TableBindingNavigator.Enabled = false;
        }





        void revert()
        {
            this.faults_TableBindingSource.CancelEdit();
            this.add_entry_ds.Faults_Table.RejectChanges();
        }
        #endregion
    }
}
