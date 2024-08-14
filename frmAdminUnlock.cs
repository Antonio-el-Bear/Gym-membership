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
    public partial class frmAdminUnlock : Form
    {
        public frmAdminUnlock()
        {
            InitializeComponent();
        }

        private void btnAdminUnlock_Click(object sender, EventArgs e)
        {
            //Get the Admin username and password from the form
           string AdminUsername = txtAdminUnlockUser.Text;
            string AdminPassword = txtAdminUnlockPass.Text;
            bool usernameYes = false;
            bool passwordYes = false;
            //Check if the admin username and password is on the system as an admin
            //access the AdminUsers list in the FileHandler class
            //namespace.class.list to check
            try
            {
                foreach (var item in PRG262_BKV_8.FileHandler.AdminUsers)
                {
                    if (item.Username == AdminUsername)
                    {
                        //the username matches
                        usernameYes = true;
                    }
                    if (item.Password == AdminPassword)
                    {
                        //the password matches
                        passwordYes = true;
                    }
                    if (usernameYes && passwordYes)
                    {
                        //if it matches unlock the system
                        //set the application lock status to false
                        FrmGymLogin.ApplicationLocked = false;
                        //change the locked status in the textfile
                        //make the unlock button not visible
                        FileHandler handler = new FileHandler();
                        handler.ChangeTextAppStatusFalse();
                        break;
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                FrmGymLogin.ApplicationLocked=false;
                frmAdminUnlock.ActiveForm.Close();
                //show the user a message
                MessageBox.Show("The system has been unlocked");
                FrmGymLogin frmGymLogin2 = new FrmGymLogin();
                frmGymLogin2.Show();
            }         
            

        }
    }
}
