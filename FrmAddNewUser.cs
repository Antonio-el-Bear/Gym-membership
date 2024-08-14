using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG262_BKV_8
{
    public partial class FrmAddNewUser : Form
    {
        public FrmAddNewUser()
        {
            InitializeComponent();
        }

        private void BtnRegisterNewUser_Click(object sender, EventArgs e)
        {
            string userLevelType="";
            bool passwordFiveOrMore = true;

            if (rbAdmin.Checked)
            {
                userLevelType = "admin";
            }
            else if (rbUser.Checked) 
            {
                userLevelType= "user";
            }
            if (txtNewUserPassword.TextLength >= 5)
            {
                passwordFiveOrMore = true;
            }
            if (txtNewUserPassword.TextLength < 5)
            {
                passwordFiveOrMore = false;
                MessageBox.Show("Sorry the password needs to be more than 5 characters long, try again.");
            }
            if (passwordFiveOrMore == true)
            {
                FileHandler handler = new FileHandler();
                handler.InsertNewUser(txtNewUserName.Text, txtNewUserPassword.Text, userLevelType);
                MessageBox.Show("Username: " + txtNewUserName.Text + " has been added to the system.");
            }
        }

        private void btnRegisterNewUserCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
