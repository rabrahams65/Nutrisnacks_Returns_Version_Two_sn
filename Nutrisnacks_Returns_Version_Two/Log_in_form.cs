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
    public partial class Log_in_form : Form
    {
        public Log_in_form()
        {
            InitializeComponent();
        }

        private void Log_in_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'current_record_ds.Returns_Table' table. You can move, or remove it, as needed.
            this.returns_TableTableAdapter.Fill_current_record(this.current_record_ds.Returns_Table);
            this.users_TableTableAdapter.FillBy_login_user(this.add_entry_ds.Users_Table);
            //this.usernameComboBox.SelectedIndex = -1;
            this.user_passwordTextBox.Clear();
            this.txt_username.Clear();
            this.txt_username.Select();
            
            
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private void btn_log_in_Click(object sender, EventArgs e)
        {
            //--------------------- Check if user exists ------------------------
            string ep;
            ep = this.txt_username.Text;

            Int64 contains_user;

            contains_user = this.users_TableTableAdapter.FillBy_username(this.add_entry_ds.Users_Table, ep);
           
            if (contains_user <= 0)
            {
                MessageBox.Show("This username is not valid!");
                this.users_TableTableAdapter.FillBy_login_user(this.add_entry_ds.Users_Table);
                //revert();
                //disable_aed_buttons();
                this.user_passwordTextBox.Clear();
                //this.txt_username.Clear();
                this.txt_username.Select();
                return;
            }
            else
            {
                this.users_TableTableAdapter.FillBy_username(this.add_entry_ds.Users_Table, ep);
            }
            //----------------------------------------------------------------------

            //Checks if password is correct
            if (this.user_passwordTextBox.Text == this.user_passwordLabel1.Text)
            {
                long id;
                long.TryParse(this.user_IdLabel1.Text, out id);
                Nutrisnacks_Returns_Version_Two.Properties.Settings.Default.app_user_id = id;
                Nutrisnacks_Returns_Version_Two.Properties.Settings.Default.app_user_name = this.usernameLabel1.Text;
                Nutrisnacks_Returns_Version_Two.Properties.Settings.Default.app_user_f_name = this.user_fnameLabel1.Text;
                Nutrisnacks_Returns_Version_Two.Properties.Settings.Default.app_user_l_name = this.user_lnameLabel1.Text;
                Nutrisnacks_Returns_Version_Two.Properties.Settings.Default.app_user_role = this.user_roleLabel1.Text;

                ////Convert image
                //byte[] img;
                //img = System.IO.File.ReadAllBytes()
                ////
                Nutrisnacks_Returns_Version_Two.Properties.Settings.Default.Save();

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Password is incorrect! Try again");
                this.users_TableTableAdapter.FillBy_login_user(this.add_entry_ds.Users_Table);
                this.user_passwordTextBox.Clear();
                this.user_passwordTextBox.Focus();
                return;
            }
            //
        }

        //private void usernameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    this.users_TableTableAdapter.FillBy_login_user(this.add_entry_ds.Users_Table);
        //    long id;
        //    long.TryParse(this.user_IdLabel1.Text, out id);
        //    this.users_TableTableAdapter.FillBy_ex_info_users_id(this.add_entry_ds.Users_Table, id);
        //}

        //private void usernameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    this.usernameComboBox.Refresh();
        //}
    }
}
