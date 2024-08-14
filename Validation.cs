using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PRG262_BKV_8
{
    class Validation
    {
        
       public static bool ValidateUser(string username, string password)
        {
            bool UsernameLengthCheck = false;
            bool PasswordLengthCheck = false;   
            UsernameLengthCheck = ValidateUser(username);
            PasswordLengthCheck = ValidatePassword(password);
            // Every time ValidateUser gets called it is a login attempt
            LoginAttempt(username,password);
            // Length of password and username is correct? then actually check if the username
            // and password exists in the list
            if (UsernameLengthCheck == false)
            {
                MessageBox.Show("Username provided was too short");

            }

            if (PasswordLengthCheck == false)
            {
                MessageBox.Show("Password provided was too short");

            }
            if (UsernameLengthCheck && PasswordLengthCheck)
            {
              
            }
           return UsernameLengthCheck;
        }
        // Is the username a valid length and not an empty string
       public static bool ValidateUser(string username)
        {
            bool validUsernameLength = false;
            if (username != null)
            {
                if (username.Length >= 5 && username.Length <= 25) {
                   validUsernameLength = true;
                }
            }
            else
            {
                validUsernameLength = false;
            }

            return validUsernameLength;
        }

        public static bool ValidatePassword(string password)
        {
            bool validPasswordLength = false;
            if (password != null)
            {
                if (password.Length >= 5 && password.Length <= 25)
                {
                    validPasswordLength = true;
                }
            }
            else
            {
                validPasswordLength = false;
                MessageBox.Show("The password provided was too short.");
            }

            return validPasswordLength;
        }

        public static int attempts = 0;
        public static string UsernameAttempt = "";
        public static bool TooManyAttempts = false;
        public static bool LoginAttempt(string username, string password)
        {
            
            bool userNameFound = false;
            bool userPasswordFound = false;

            FileHandler handler = new FileHandler();
            List<User> currentUserList = new List<User>();
            currentUserList =  handler.ReadUsers();
            //Check username against each username in the User list
            foreach (User u in currentUserList)
            {
                if (u.Username == username)
                {
                    //username found in the list
                    userNameFound = true;
                    break;
                }
               
            }
            //Check password against each password in the User list
            foreach (User u in currentUserList)
            {
                if (u.Password == password)
                {
                    //username found in the list
                    userPasswordFound = true;
                    break;
                }

            }
            if (!userNameFound && !userPasswordFound)
            {
                MessageBox.Show("Username and password not found.");
            }

            if(userNameFound && !userPasswordFound)
            {
                MessageBox.Show("Password does not match.");
            }

            if(!userNameFound && userPasswordFound)
            {
                MessageBox.Show("Username not found");
            }
            //Both username and password maches
            if(userNameFound && userPasswordFound)
            {
                // Check to see if the user is an Admin
                List<User> adminUsersLocalList = new List<User>();
                adminUsersLocalList = PRG262_BKV_8.FileHandler.AdminUsers;

                foreach (User u in adminUsersLocalList)
                {
                    if(u.Username == username)
                    {
                        //user is an Admin
                        PRG262_BKV_8.FrmGymLogin.CurrentUserIsAdmin = true;
                    }
                }


                // log the user in
                GymManagementForm gymManagementForm = new GymManagementForm();
                gymManagementForm.Show();
            }


            if (UsernameAttempt == username)
            {
                attempts++;
            } else
            {
                //reset the amount of login attempts
                attempts = 0;
                TooManyAttempts = false;
            }

            if (attempts == 3) {
                TooManyAttempts = true;
                MessageBox.Show("Too many failed login attempts the system is now locked.");
                PRG262_BKV_8.FrmGymLogin.ApplicationLocked = true;


            }

            return TooManyAttempts;
        }

        public static void Unlock()
        {
            //Unlock the login form by entering a administrator username and password.
            frmAdminUnlock frmAdminUnlock = new frmAdminUnlock();
            frmAdminUnlock.Show();
            
            //Should stay locked if the username and password is not an admin account.
        }
    }
}
