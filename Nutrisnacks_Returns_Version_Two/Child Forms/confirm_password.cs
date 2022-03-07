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
    public partial class confirm_password : Form
    {
        public confirm_password()
        {
            InitializeComponent();
        }

        private void confirm_password_Load(object sender, EventArgs e)
        {
            //Nutrisnacks_Returns_Version_Two.Child_Forms
            long ci;
            long.TryParse(this.label_child_id.Text, out ci);
            this.users_TableTableAdapter.FillBy_ex_info_users_id(this.add_entry_ds.Users_Table, ci);

            //this.

        }

        private void user_passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (user_passwordTextBox.Text == user_passwordLabel2.Text)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Password does not match the old password! Try again");
                return;
            }
        }
    }
}
