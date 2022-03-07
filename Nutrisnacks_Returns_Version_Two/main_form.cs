using Stimulsoft.Report.Dictionary;
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

    // Update 28/06/2021
    // *From date of search bars we're updated to include only .date instead of .date.day. 
    //  The previous version couldn't load a day later of the previous month.
    // *Removed lines in table
    // *Updated the users section: Password rechecked when user role was updated. It is changed now.
    // * Updated the from dates for documents to limit to only today. Batch date dates are unlimited.
    // Added shortcuts on keyboard for faster capturing. 
    // Focus was added to the doc date as soon as a new entry is added and an entry is edited.
    //
    


    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();

            string fn;

            fn = Application.StartupPath;
            fn += "\\Data\\Rep\\license.key";

            Stimulsoft.Base.StiLicense.LoadFromFile(fn);
            
        }
        private void main_form_Load(object sender, EventArgs e)
        {
            
            
            Nutrisnacks_Returns_Version_Two.Log_in_form frm = new Log_in_form();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.Cancel)
            {
                this.Close();
            }
            if (frm.DialogResult == DialogResult.OK)
            {
                this.logged_in_user_label.Text = Nutrisnacks_Returns_Version_Two.Properties.Settings.Default.app_user_f_name;
                this.label_current_role.Text = Nutrisnacks_Returns_Version_Two.Properties.Settings.Default.app_user_role;

                //Checks user role
                String ur;
                ur = Nutrisnacks_Returns_Version_Two.Properties.Settings.Default.app_user_role;
                if (ur == "Viewer")
                {
                    this.panel_main.Enabled = false;
                }
                if (ur == "Editor")
                {
                    this.btn_users.Enabled = false;
                }
            }
            frm.Dispose();

            this.origin_date_combobox.SelectedIndex = 0;

            //Fill startup returns and basic view
            System.DateTime from_date = new DateTime();
            System.DateTime to_date = new DateTime();
            from_date = this.from_dateTimePicker.Value;
            to_date = this.to_dateTimePicker.Value;

            string fd;
            string td;
            fd = from_date.ToShortDateString();
            td = to_date.ToShortDateString();


            this.returns_TableTableAdapter.FillBy_dates(this.current_record_ds.Returns_Table, fd, td);
            this.basic_ViewTableAdapter.FillBy_dates_basic_view(this.current_record_ds.Basic_View, fd, td);












            //--------------------------Limit date to date to today----------------
            System.DateTime today = System.DateTime.Now;
            this.from_dateTimePicker.MaxDate = today;
            this.to_dateTimePicker.MaxDate = today;
            //---------------------------------------------------------------------
        }

        //private void btn_add_new_Click(object sender, EventArgs e)
        //{
        //    //Nutrisnacks_Returns_Version_Two.Form1 frm = new Form1();
        //    //frm.label_child_form.Text = this.entry_IDLabel1.Text;
        //    //frm.ShowDialog();
        //    //this.returns_TableTableAdapter.Fill_current_record(this.current_record_ds.Returns_Table);
        //    //Nutrisnacks_Returns_Version_1._0.Properties.Settings.Default.manager_f_name = 

        //}

        private void btn_load_all_Click(object sender, EventArgs e)
        {
            this.btn_export_to_trend_analysis.Enabled = false;



            this.returns_TableTableAdapter.Fill_current_record(this.current_record_ds.Returns_Table);
            this.basic_ViewTableAdapter.Fill_by_basic_view(this.current_record_ds.Basic_View);
        }

        private void btn_not_returned_Click(object sender, EventArgs e)
        {
            this.btn_export_to_trend_analysis.Enabled = false;

            this.txt_cust_or_prod_name.Text = String.Empty; 

            System.DateTime from_date = new DateTime();
            System.DateTime to_date = new DateTime();
            from_date = this.from_dateTimePicker.Value;
            to_date = this.to_dateTimePicker.Value;

            if (from_date.Date > to_date.Date)
            {
                MessageBox.Show("From date can't be greater than to date!");
                from_date = to_date;
                return;
            }


            string fd;
            string td;
            fd = from_date.ToShortDateString();
            td = to_date.ToShortDateString();

            //Load data by Comboboxes Returns Table Adapter
            if (this.origin_date_combobox.SelectedIndex == 0)
            {
                this.returns_TableTableAdapter.FillBy_not_returned(this.current_record_ds.Returns_Table, fd, td);
            }
            if (this.origin_date_combobox.SelectedIndex == 1)
            {
                if (this.checkBox_no_date.Checked == true)
                {
                    this.returns_TableTableAdapter.FillBy_No_Batch_Date_Not_Returned(this.current_record_ds.Returns_Table, fd, td);
                }
                else
                {
                    this.returns_TableTableAdapter.FillBy_batch_date_not_returned(this.current_record_ds.Returns_Table, fd, td);
                }
                
            }

            //Load data by Comboboxes Basic View Table Adapter
            if (this.origin_date_combobox.SelectedIndex == 0)
            {
                this.basic_ViewTableAdapter.FillBy_not_returned_basic_view(this.current_record_ds.Basic_View, fd, td);
            }
            if (this.origin_date_combobox.SelectedIndex == 1)
            {
                //this.basic_ViewTableAdapter.FillBy_batch_date_not_returned_basic_view(this.current_record_ds.Basic_View, fd, td);
            }

            DynamicDateChanger();



        }

        private void btn_customers_Click(object sender, EventArgs e)
        {

            this.btn_export_to_trend_analysis.Enabled = false;
            Nutrisnacks_Returns_Version_Two.Child_Forms.Customers frm = new Child_Forms.Customers();
            frm.ShowDialog();

            //fill_by_dates();REMOVED ON 05 October 2021- Enable again if necessary

        }

        //private void returns_TableDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{

        //    this.btn_export_to_trend_analysis.Enabled = false;
        //    String ur;
        //    ur = Nutrisnacks_Returns_Version_Two.Properties.Settings.Default.app_user_role;

        //    if (ur == "Viewer")
        //    {
        //        return;
        //    }
        //    Nutrisnacks_Returns_Version_Two.Form1 frm = new Form1();
        //    frm.label_child_form.Text = this.entry_IDLabel1.Text;
        //    frm.ShowDialog();
        //    this.returns_TableTableAdapter.Fill_current_record(this.current_record_ds.Returns_Table);
        //    this.basic_ViewTableAdapter.Fill_by_basic_view(this.current_record_ds.Basic_View);

        //}

        private void btn_add_new_Click_1(object sender, EventArgs e)
        {
            this.btn_export_to_trend_analysis.Enabled = false;
            Nutrisnacks_Returns_Version_Two.Form1 frm = new Form1();
            frm.label_child_form.Text = this.entry_IDLabel1.Text;
            
            frm.ShowDialog();
            //fill_by_dates(); REMOVED ON 05 October 2021- Enable again if necessary
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            this.btn_export_to_trend_analysis.Enabled = false;
            Nutrisnacks_Returns_Version_Two.Child_Forms.Products frm = new Child_Forms.Products();
            frm.ShowDialog();
            //fill_by_dates();REMOVED ON 05 October 2021- Enable again if necessary
        }

        private void btn_reps_Click(object sender, EventArgs e)
        {
            this.btn_export_to_trend_analysis.Enabled = false;
            Nutrisnacks_Returns_Version_Two.Child_Forms.Reps frm = new Child_Forms.Reps();
            frm.ShowDialog();
            //fill_by_dates();REMOVED ON 05 October 2021- Enable again if necessary
        }

        private void btn_faults_Click(object sender, EventArgs e)
        {
            this.btn_export_to_trend_analysis.Enabled = false;
            Nutrisnacks_Returns_Version_Two.Child_Forms.Faults frm = new Child_Forms.Faults();
            frm.ShowDialog();
            //fill_by_dates();REMOVED ON 05 October 2021- Enable again if necessary
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            this.btn_export_to_trend_analysis.Enabled = false;
            Nutrisnacks_Returns_Version_Two.Child_Forms.Users frm = new Child_Forms.Users();
            frm.ShowDialog();
            //fill_by_dates();REMOVED ON 05 October 2021- Enable again if necessary
        }

        //private void to_dateTimePicker_ValueChanged(object sender, EventArgs e)
        //{
        //    //System.DateTime from_date = new DateTime();
        //    //System.DateTime to_date = new DateTime();
        //    //from_date = this.from_dateTimePicker.Value;
        //    //to_date = this.to_dateTimePicker.Value;

        //    //if (from_date > to_date)
        //    //{
        //    //    MessageBox.Show("From date can't be greater than to date!");
        //    //    from_date = to_date;
        //    //    return;
        //    //}


        //    //string fd;
        //    //string td;
        //    //fd = from_date.ToShortDateString();
        //    //td = to_date.ToShortDateString();
        //    //returns_TableTableAdapter.FillBy_dates(this.current_record_ds.Returns_Table, fd, td);


        //    //string fd;
        //    //string td;
        //    //fd = from_date.ToShortDateString();
        //    //td = to_date.ToShortDateString();
        //    //returns_TableTableAdapter.FillBy_dates(this.current_record_ds.Returns_Table,from_date.ToString(), to_date.ToString());

        //}

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.btn_export_to_trend_analysis.Enabled = false;

            System.DateTime from_date = new DateTime();
            System.DateTime to_date = new DateTime();
            from_date = this.from_dateTimePicker.Value;
            to_date = this.to_dateTimePicker.Value;

            if (from_date.Date > to_date.Date)
            {
                MessageBox.Show("From date can't be greater than to date!");
                from_date = to_date;
                return;
            }

            string fd;
            string td;

            fd = from_date.ToShortDateString();
            td = to_date.ToShortDateString();











            //Load data by Comboboxes
            if (this.txt_cust_or_prod_name.Text == String.Empty)
            {
                if (this.origin_date_combobox.SelectedIndex == 0)
                {
                    returns_TableTableAdapter.FillBy_dates(this.current_record_ds.Returns_Table, fd, td);
                    //summaryTableAdapter.Fill_by_max_returns_by_store(this.current_record_ds.Summary, fd, td);
              
                }
                if (this.origin_date_combobox.SelectedIndex == 1)
                {
                    if (this.checkBox_no_date.Checked == true)
                    {
                        this.returns_TableTableAdapter.FillBy_No_Batch_Date(this.current_record_ds.Returns_Table,fd,td);
                    }
                    else
                    {
                        returns_TableTableAdapter.FillBy_batch_date_only(this.current_record_ds.Returns_Table, fd, td);
                    }
                    
                }
            }
            //Load data by Comboboxes basic view
            if (this.txt_cust_or_prod_name.Text == String.Empty)
            {
                if (this.origin_date_combobox.SelectedIndex == 0)
                {
                    this.basic_ViewTableAdapter.FillBy_dates_basic_view(this.current_record_ds.Basic_View, fd, td);
                }
                if (this.origin_date_combobox.SelectedIndex == 1)
                {
                    
                    ////////this.basic_ViewTableAdapter.FillBy_batch_date_only_basic_view(this.current_record_ds.Basic_View, fd, td);
                }
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////






















            //load by cust or prod by doc date or batch date
            if (txt_cust_or_prod_name.Text != String.Empty)
            {

                if (this.origin_date_combobox.SelectedIndex == 0 )
                {
                    this.returns_TableTableAdapter.FillBy_cust_and_prod_name(this.current_record_ds.Returns_Table, fd, td,
                                                                         "%" + this.txt_cust_or_prod_name.Text + "%",
                                                                         "%" + this.txt_cust_or_prod_name.Text + "%",
                                                                         "%" + this.txt_cust_or_prod_name.Text + "%",
                                                                         "%" + this.txt_cust_or_prod_name.Text + "%");
                }
                if (this.origin_date_combobox.SelectedIndex == 1)
                {
                    if (this.checkBox_no_date.Checked == true)
                    {
                        this.returns_TableTableAdapter.FillBy_No_Batch_Date_By_Cust_and_Prod_Name(this.current_record_ds.Returns_Table, fd, td,
                                                                        "%" + this.txt_cust_or_prod_name.Text + "%",
                                                                        "%" + this.txt_cust_or_prod_name.Text + "%");
                    }
                    else
                    {
                        this.returns_TableTableAdapter.FillBy_cust_and_prod_name_by_batch_date(this.current_record_ds.Returns_Table, fd, td,
                                                                        "%" + this.txt_cust_or_prod_name.Text + "%",
                                                                        "%" + this.txt_cust_or_prod_name.Text + "%");
                    }
                    
                }
                
            }

            //load by cust or prod by doc date or batch date basic view only
            if (txt_cust_or_prod_name.Text != String.Empty)
            {

                if (this.origin_date_combobox.SelectedIndex == 0)
                {
                    this.basic_ViewTableAdapter.FillBy_cust_and_prod_name_basic_view(this.current_record_ds.Basic_View, fd, td,
                                                                         "%" + this.txt_cust_or_prod_name.Text + "%",
                                                                         "%" + this.txt_cust_or_prod_name.Text + "%",
                                                                         "%" + this.txt_cust_or_prod_name.Text + "%",
                                                                         "%" + this.txt_cust_or_prod_name.Text + "%");
                }
                if (this.origin_date_combobox.SelectedIndex == 1)
                {
                    ////////this.basic_ViewTableAdapter.FillBy_cust_and_prod_name_by_batch_date_basic_view(this.current_record_ds.Basic_View, fd, td,
                    ////////                                                     "%" + this.txt_cust_or_prod_name.Text + "%",
                    ////////                                                    "%" + this.txt_cust_or_prod_name.Text + "%");
                }

            }

            //



            //bool contains;

            //contains = this.current_record_ds.Returns_Table.Columns.Contains(this.txt_search.Text);

            //if (contains)
            //{
            //    returns_TableTableAdapter.Fi
            //}


            DynamicDateChanger();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            this.btn_export_to_trend_analysis.Enabled = false; 

            string fn;
            fn = Application.StartupPath;
            fn += "\\Data\\Rep\\Returns_Register_Record.mrt";

            //Register Dataset
            this.stiReport1.RegData(this.current_record_ds.Returns_Table);
            //
            this.stiReport1.Load(fn);
            
            this.stiReport1.Show();
        }

        private void btn_export_to_trend_analysis_Click(object sender, EventArgs e)
        {
          
            string fn;
            fn = Application.StartupPath;
            fn += "\\Data\\Rep\\Trend_Analysis.mrt";

            //Register Dataset
            this.stiReport3.RegData(this.current_record_ds.Basic_View);
            //
            
            this.stiReport3.Load(fn);

            //this.stiReport3.Dictionary.Databases.Clear();
            //this.stiReport3.Dictionary.Databases.Add(new StiSqlDatabase("connection string", "Data Source=192.168.0.200,1433;Initial Catalog=Nutrisnacks_Returns_DB_Version_1;Persist Security Info=True;User ID=sa;Password=Nut7193"));
            this.stiReport3.Show();
          

        }

        private void origin_date_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (origin_date_combobox.SelectedIndex == 0)
            {
                this.checkBox_no_date.Checked = false;
                this.checkBox_no_date.Visible = false;

                //--------------------------Limit date to date to today----------------
                System.DateTime today = System.DateTime.Now;
                this.from_dateTimePicker.MaxDate = today;
                this.to_dateTimePicker.MaxDate = today;
                //---------------------------------------------------------------------

                //this.btn_export_to_trend_analysis.Enabled = true;
            }

            if (origin_date_combobox.SelectedIndex == 1)
            {
                this.checkBox_no_date.Checked = false;
                this.checkBox_no_date.Visible = true;

                //---------------Remove limitation of date to more days----------------
                this.from_dateTimePicker.MaxDate = DateTimePicker.MaximumDateTime;
                this.to_dateTimePicker.MaxDate = DateTimePicker.MaximumDateTime;
                //---------------------------------------------------------------------

                //this.btn_export_to_trend_analysis.Enabled = false;
            }

        }

        private void checkBox_no_date_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_no_date.Checked == true)
            {
                //this.from_dateTimePicker.Enabled = false;
                //this.to_dateTimePicker.Enabled = false;
                this.label_Doc_date.Visible = true;
            }

            if (this.checkBox_no_date.Checked == false)
            {
                //this.from_dateTimePicker.Enabled = true;
                //this.to_dateTimePicker.Enabled = true;
                this.label_Doc_date.Visible = false;
            }
        }

        private void btn_prepare_trend_analysis_Click(object sender, EventArgs e)
        {
            System.DateTime from_date = new DateTime();
            System.DateTime to_date = new DateTime();
            from_date = this.from_dateTimePicker.Value;
            to_date = this.to_dateTimePicker.Value;

            if (from_date.Date > to_date.Date)
            {
                MessageBox.Show("From date can't be greater than to date!");
                from_date = to_date;
                return;
            }

            string fd;
            string td;

            fd = from_date.ToShortDateString();
            td = to_date.ToShortDateString();

            int t,tt;
            t = returns_TableTableAdapter.FillBy_dates(this.current_record_ds.Returns_Table, fd, td);

            tt = this.basic_ViewTableAdapter.FillBy_dates_basic_view(this.current_record_ds.Basic_View, fd, td);

            if (tt <= 0 && t <=0)
            {
                MessageBox.Show("No records selected to export!");
                this.btn_export_to_trend_analysis.Enabled = false;
                return;
            }

            int p;
            p = this.returns_TableTableAdapter.FillBy_prepare_for_trend_analysis(this.current_record_ds.Returns_Table, fd, td);
            if (p > 0)
            {
                MessageBox.Show("Trend analysis will export, but will be faulty. Update the displayed records and dates then try again!");
                this.returns_TableTableAdapter.FillBy_prepare_for_trend_analysis(this.current_record_ds.Returns_Table, fd, td);
                this.btn_export_to_trend_analysis.Enabled = false;
            }
            else
            {
                MessageBox.Show("The trend analysis is ready to prepare for the specified dates.");
                this.btn_export_to_trend_analysis.Enabled = true;
                returns_TableTableAdapter.FillBy_dates(this.current_record_ds.Returns_Table, fd, td);
                this.basic_ViewTableAdapter.FillBy_dates_basic_view(this.current_record_ds.Basic_View, fd, td);
                
            }
        }





        //private void from_dateTimePicker_ValueChanged(object sender, EventArgs e)
        //{
        //    //System.DateTime from_date = new DateTime();
        //    //System.DateTime to_date = new DateTime();
        //    //from_date = this.from_dateTimePicker.Value;
        //    //to_date = this.to_dateTimePicker.Value;

        //    //if (from_date > to_date)
        //    //{
        //    //    MessageBox.Show("From date can't be greater than to date!");
        //    //    from_date = to_date;
        //    //    return;
        //    //}


        //    //string fd;
        //    //string td;
        //    //fd = from_date.ToShortDateString();
        //    //td = to_date.ToShortDateString();
        //    //returns_TableTableAdapter.FillBy_dates(this.current_record_ds.Returns_Table, fd, td);

        //}

        //private void btn_log_out_Click(object sender, EventArgs e)
        //{
        //    Nutrisnacks_Returns_Version_Two.Log_in_form frm = new Log_in_form();
        //    frm.ShowDialog();

        //    if (frm.DialogResult == DialogResult.Cancel)
        //    {
        //        this.Close();
        //    }
        //    if (frm.DialogResult == DialogResult.OK)
        //    {
        //        this.logged_in_user_label.Text = Nutrisnacks_Returns_Version_Two.Properties.Settings.Default.app_user_f_name;
        //        this.label_current_role.Text = Nutrisnacks_Returns_Version_Two.Properties.Settings.Default.app_user_role;

        //        //Checks user role
        //        String ur;
        //        ur = Nutrisnacks_Returns_Version_Two.Properties.Settings.Default.app_user_role;
        //        if (ur == "Viewer")
        //        {
        //            this.panel_main.Enabled = false;
        //        }
        //        if (ur == "Editor")
        //        {
        //            this.btn_users.Enabled = false;
        //            this.btn_customers.Enabled = false;
        //            this.btn_products.Enabled = false;
        //            this.btn_reps.Enabled = false;
        //            this.btn_faults.Enabled = false;
        //            this.btn_add_new.Enabled = true;
        //        }
        //    }
        //    frm.Dispose();


        //    this.returns_TableTableAdapter.Fill_current_record(this.current_record_ds.Returns_Table);
        //    this.origin_date_combobox.SelectedIndex = 0;
        //}

        //private void btn_log_out_Click(object sender, EventArgs e)
        //{
        //    this.DialogResult = DialogResult.Cancel;

        //}

        //private void origin_date_combobox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (this.origin_date_combobox.SelectedIndex == 0)
        //    {
        //        returns_TableTableAdapter.FillBy_dates(current_record_ds.Returns_Table)
        //    }
        //}

        #region Private Helpers

        void DynamicDateChanger()
        {

            //ADDED ON 11 FEB 2022
            



            //---------------------- No row to edit guard --------------------------------
            int rc;
            rc = this.current_record_ds.Returns_Table.Rows.Count;
            if (rc == 0)
            {
                return;
            }
            //----------------------------------------------------------------------------

            // Change Dates Dynamically as search progresses - ADDED ON 11 FEB 2022
            var firstDate = this.returns_TableDataGridView.Rows[0].Cells[0].Value.ToString();

            var parsedDate = DateTime.Parse(firstDate);

            this.from_dateTimePicker.Value = parsedDate;
        }

        void fill_by_dates()
        {
            System.DateTime from_date = new DateTime();
            System.DateTime to_date = new DateTime();
            from_date = this.from_dateTimePicker.Value;
            to_date = this.to_dateTimePicker.Value;

            string fd;
            string td;

            fd = from_date.ToShortDateString();
            td = to_date.ToShortDateString();

            returns_TableTableAdapter.FillBy_dates(this.current_record_ds.Returns_Table, fd, td);

            this.basic_ViewTableAdapter.FillBy_dates_basic_view(this.current_record_ds.Basic_View, fd, td);
        }

        #endregion

        //private void btnQuickPrint_Click(object sender, EventArgs e)
        //{
        //    this.btn_export_to_trend_analysis.Enabled = false;

        //    string fn;
        //    fn = Application.StartupPath;
        //    fn += "\\Data\\Rep\\Returns_Register_Record.mrt";

        //    //Register Dataset
        //    this.stiReport1.RegData(this.current_record_ds.Returns_Table);
        //    //
        //    this.stiReport1.Load(fn);

        //    this.stiReport1.Print(true);
        //}
    }
}
