/*
 BK-240513-PRG262-V, PRG262-BKV 8
 Group members:
 Andries van der Westhuizen
 Shweta Bharath
 Tony Zambuko
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace PRG262_BKV_8
{
    
    public partial class FrmGymLogin : Form
    {
        private static bool applicationLocked = false;
        private static bool currentUserIsAdmin = false;

        public static bool ApplicationLocked { get => applicationLocked; set => applicationLocked = value; }
        public static bool CurrentUserIsAdmin { get => currentUserIsAdmin; set => currentUserIsAdmin = value; }

        public FrmGymLogin()
        {
            InitializeComponent();
        }
        
        public static void ShowUnlockButton() 
        {
            //change FrmGymLogin.btnUnlockApp.visible = true;

        }

        public static void HideUnlockButton()
        {
            //change FrmGymLogin.btnUnlockApp.visible = false;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // use the Validation class the group created to check the username and password for errors
            string username = txtUsername.Text;
            string password = txtPassword.Text; 
            if(ApplicationLocked == false)
            {
                Validation.ValidateUser(username, password);
            }else if (ApplicationLocked == true)
            {
                btnUnlockApp.Visible = true;
                MessageBox.Show("Sorry the application is locked, please unlock it with the unlock button.");

            }
           
        }
        public void DisplayLockedButton()
        {
           btnLogin.Visible = true;
            
        }

        private void FrmGymLogin_Load(object sender, EventArgs e)
        {
            //Application should be unlocked by default unless the text file says it is locked.
            ApplicationLocked = false;
            //A method that will be called once the Form is shown on the screen
            this.Shown += new EventHandler(FrmGymLogin_Shown);
            
        }

        private void FrmGymLogin_Shown(object sender, EventArgs e)
        {
            try
            {
                FileHandler handler = new FileHandler();
                handler.ReadUsers();
               
            }
            catch (Exception ex)
            {
                // Handle exceptions (log, display error message, etc.)
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnUnlockApp_Click(object sender, EventArgs e)
        {
            //Show the unlock form
            frmAdminUnlock frmUnlock = new frmAdminUnlock();
            frmUnlock.Show();
        }

        private void tmrCheckLocked_Tick(object sender, EventArgs e)
        {
            //A timer that checks every 1 second if the Application is locked
            if (ApplicationLocked) { 
            btnUnlockApp.Visible = true;   
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit the application
            Application.Exit();
        }
    }
}
