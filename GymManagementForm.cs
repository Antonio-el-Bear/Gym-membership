using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PRG262_BKV_8
{
    public partial class GymManagementForm : Form
    {
        public GymManagementForm()
        {
            InitializeComponent();
        }

       
        private void GymManagementForm_Load(object sender, EventArgs e)
        {
            //If the current user is not admin some things should not display
            if (FrmGymLogin.CurrentUserIsAdmin == false)
            {
                //disable display users button
                 btnDisplayUsers.Enabled = false;
                 tabControl1.Enabled = false;
            }

        }

        private void btnDisplayMembers_Click(object sender, EventArgs e)
        {
            DataHandler handler = new DataHandler();
            dgMembers.DataSource = handler.Read();
        }

        private void btnManageClasses_Click(object sender, EventArgs e)
        {
          
        }

        private void dgMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Display the selected row of the datagridview in the textboxes that match each column for that row.
                int indexRow;
                indexRow = e.RowIndex;

                DataGridViewRow row = dgMembers.Rows[indexRow];
                // The data table of the classes or training programs are 7 columns in total
                if (dgMembers.Columns.Count == 7)
                {
                    txtClassID.Text = row.Cells[0].Value.ToString();
                    txtClassName.Text = row.Cells[1].Value.ToString();
                    txtClassDescription.Text = row.Cells[2].Value.ToString();
                    txtClassInstructor.Text = row.Cells[3].Value.ToString();
                    txtInstructorToSearch.Text = row.Cells[3].Value.ToString();
                    txtClassSchedule.Text = row.Cells[4].Value.ToString();
                    txtClassCapacity.Text = row.Cells[5].Value.ToString();
                    txtClassDuration.Text = row.Cells[6].Value.ToString();
                }
                // The data table of the gym members is 10 Columns in total
                if (dgMembers.Columns.Count == 10)
                {
                    txtMemberID.Text = row.Cells[0].Value.ToString();
                    txtMemberFirstName.Text = row.Cells[1].Value.ToString();
                    txtMemberLastName.Text = row.Cells[2].Value.ToString();
                    dtpMemberDOB.Value = Convert.ToDateTime(row.Cells[3].Value);
                    cmbMemberGender.Text = row.Cells[4].Value.ToString();
                    txtMemberPhoneNumber.Text = row.Cells[5].Value.ToString();
                    txtMemberAddress.Text = row.Cells[6].Value.ToString();
                    txtMemberTrainingProgram.Text = row.Cells[7].Value.ToString();
                    dtpMemberStartDate.Value = Convert.ToDateTime(row.Cells[8].Value);
                    dtpMemberEndDate.Value = Convert.ToDateTime(row.Cells[9].Value);
                }
                // The datatable of the users is 3 Columns in total
                if (dgMembers.Columns.Count == 4)
                {
                    //txtManageUsername.Text = row.Cells[0].Value.ToString();
                    //txtManagePassword.Text = row.Cells[1].Value.ToString();
                    //txtManageUserType.Text = row.Cells[3].Value.ToString();
                    //txtManageUserID.Text = row.Cells[2].Value.ToString();
                }
            }catch (Exception)
            {
                MessageBox.Show("Please do not click on the column names, rather on the rows.");
            }
        }

        private void btnInsertClass_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "Server =.\\SQLExpress; Database =GymMembersDB; Integrated Security = SSPI";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = "INSERT INTO tblClasses ([Class\\ProgramID], [Class\\ProgramName], [ClassDescription], [Instructor], [Schedule], [Capacity], [Duration]) " +
                                   "VALUES (@ProgramID, @ProgramName, @Description, @Instructor, @Schedule, @Capacity, @Duration)";
                    // Create a SQL Command to add the program or class using textbox text values
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProgramID", txtClassID.Text);
                        cmd.Parameters.AddWithValue("@ProgramName", txtClassName.Text);
                        cmd.Parameters.AddWithValue("@Description", txtClassDescription.Text);
                        cmd.Parameters.AddWithValue("@Instructor", txtClassInstructor.Text);
                        cmd.Parameters.AddWithValue("@Schedule", txtClassSchedule.Text);
                        cmd.Parameters.AddWithValue("@Capacity", txtClassCapacity.Text);
                        cmd.Parameters.AddWithValue("@Duration", txtClassDuration.Text);

                        cmd.ExecuteNonQuery();
                    }

                    DataHandler handler = new DataHandler();
                    dgMembers.DataSource = handler.ReadClasses();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                // If the database is not available, show a message to the user
                MessageBox.Show($"Error: {ex.Message}", "A database related error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisplayClasses_Click(object sender, EventArgs e)
        {
            DataHandler handler = new DataHandler();
            dgMembers.DataSource = handler.ReadClasses();
        }

        private void btnManageMembers_Click(object sender, EventArgs e)
        {
           
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            //store the recieved users in a list 
            List<User> recievedUsers = new List<User>();
            //get and then display the users in the data grid view
            FileHandler handler = new FileHandler();
            dgMembers.DataSource = handler.ReadUsers();
           
        }

        private void btnInsertTextFileUser_Click(object sender, EventArgs e)
        {
            ////append a user to the end of the text file
            ////username,password,usertype = admin or member
            //FileHandler handler = new FileHandler();
            //handler.InsertNewUser(txtManageUsername.Text,txtManagePassword.Text,txtManageUserType.Text);
            
            //dgMembers.DataSource = handler.ReadUsers();
        }

        private void btnDeleteTextFileUser_Click(object sender, EventArgs e)
        {
            string UserToDelete;
            //Delete a user from the text file that matches the text provided in text box from the user
            //First search for the user
            //UserToDelete = txtManageUsername.Text;
            //FileHandler handler = new FileHandler();
            //Let the user know that the user was found on a line in the textfile
            //int lineToRemove= handler.SearchForUser(UserToDelete);
            //Actually remove the user
            //handler.RemoveLineFromTextfile(lineToRemove);



        }

        private void btnUpdateTextFileUser_Click(object sender, EventArgs e)
        {
            string UserToUpdate;
            //Update a user in the text file that matches the text provided in the text box from the user

        }

        private void btnSearchClassInstructor_Click(object sender, EventArgs e)
        {
            string instructorToSearch;
            //Search for all the classes that have the instructor provided in the textbox
            instructorToSearch = txtInstructorToSearch.Text;
            DataHandler handler = new DataHandler();
            dgMembers.DataSource = handler.ReadClassesByInstructor(instructorToSearch);

            
        }

        private void btnClassDelete_Click(object sender, EventArgs e)
        {
            //Delete the class using the class ID
            DeleteClass.DeleteClass1(txtClassID.Text);
            //show the updated result 
            DataHandler handler = new DataHandler();
            dgMembers.DataSource = handler.ReadClasses();

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplayUsers_Click(object sender, EventArgs e)
        {
           FileHandler handler = new FileHandler(); 
            dgMembers.DataSource= handler.ReadUsers();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CurrentTabIndex;
            CurrentTabIndex = tabControl1.SelectedIndex;
            if(CurrentTabIndex == 0)
            {
                //MessageBox.Show("First Tab");
                // Display the Classes
                DataHandler handler = new DataHandler();
                dgMembers.DataSource = handler.ReadClasses();
            }
            if (CurrentTabIndex == 1)
            {
                //MessageBox.Show("Second Tab");
                //Display the Members
                DataHandler handler = new DataHandler();
                dgMembers.DataSource = handler.Read();
            }
            if (CurrentTabIndex == 2)
            {
                //MessageBox.Show("Third Tab");
                //Display the Users
                FileHandler handler = new FileHandler();
                dgMembers.DataSource = handler.ReadUsers();


            }
        }

        private void btnClassDelete_Click_1(object sender, EventArgs e)
        {
            //Delete a row that maches the Class Id
            try
            {
                string connString = "Server =.\\SQLExpress; Database =GymMembersDB; Integrated Security = SSPI";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = "DELETE FROM dbo.tblClasses WHERE dbo.tblClasses.[Class\\ProgramID] like @ProgramID";
                    // Create a SQL Command to add the program or class using textbox text values
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProgramID", txtClassID.Text);
                        cmd.ExecuteNonQuery();
                    }

                    DataHandler handler = new DataHandler();
                    dgMembers.DataSource = handler.ReadClasses();
                    conn.Close();
                    MessageBox.Show($"The Class called {txtClassName.Text} has successfully been deleted");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred when trying to delete a class record");
            }
        }

        private void btnInsertClass_Click_1(object sender, EventArgs e)
        {
            //Insert user provided values into the classes tabel in the database
            //Insert Into TableName (

            //Get the textbox and other control's current values
            try
            {
                string connString = "Server =.\\SQLExpress; Database =GymMembersDB; Integrated Security = SSPI";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = "INSERT INTO tblClasses ([Class\\ProgramID], [Class\\ProgramName], [ClassDescription], [Instructor], [Schedule], [Capacity], [Duration]) " +
                                   "VALUES (@ProgramID, @ProgramName, @Description, @Instructor, @Schedule, @Capacity, @Duration)";
                    // Create a SQL Command to add the program or class using textbox text values
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProgramID", txtClassID.Text);
                        cmd.Parameters.AddWithValue("@ProgramName", txtClassName.Text);
                        cmd.Parameters.AddWithValue("@Description", txtClassDescription.Text);
                        cmd.Parameters.AddWithValue("@Instructor", txtClassInstructor.Text);
                        cmd.Parameters.AddWithValue("@Schedule", txtClassSchedule.Text);
                        cmd.Parameters.AddWithValue("@Capacity", txtClassCapacity.Text);
                        cmd.Parameters.AddWithValue("@Duration", txtClassDuration.Text);

                        cmd.ExecuteNonQuery();
                    }

                    DataHandler handler = new DataHandler();
                    dgMembers.DataSource = handler.ReadClasses();
                    conn.Close();
                }
            }
            //catch sql exception 
            catch (SqlException sqlEx)
            {
                MessageBox.Show("A class with that id already exists, try again");
            }
            //catch more general exceptions
            catch (Exception ex)
            {
                // If the database is not available, show a message to the user
                MessageBox.Show($"Error: {ex.Message}", "A database related error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClassUpdate_Click(object sender, EventArgs e)
        {
            
            try
            {
                string connString = "Server =.\\SQLExpress; Database =GymMembersDB; Integrated Security = SSPI";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = $"UPDATE dbo.tblClasses SET [Class\\ProgramName] = @ProgramName,[ClassDescription] = @Description,[Instructor] = @Instructor,[Schedule] = @Schedule,[Capacity] = @Capacity,[Duration] = @Duration WHERE [Class\\ProgramID] = @ProgramID;";
                    // Create a SQL Command to add the program or class using textbox text values
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProgramID", txtClassID.Text);
                        cmd.Parameters.AddWithValue("@ProgramName", txtClassName.Text);
                        cmd.Parameters.AddWithValue("@Description", txtClassDescription.Text);
                        cmd.Parameters.AddWithValue("@Instructor", txtClassInstructor.Text);
                        cmd.Parameters.AddWithValue("@Schedule", txtClassSchedule.Text);
                        cmd.Parameters.AddWithValue("@Capacity", txtClassCapacity.Text);
                        cmd.Parameters.AddWithValue("@Duration", txtClassDuration.Text);

                        cmd.ExecuteNonQuery();
                    }

                    DataHandler handler = new DataHandler();
                    dgMembers.DataSource = handler.ReadClasses();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                // If the database is not available, show a message to the user
                MessageBox.Show($"Error: {ex.Message}", "A database related error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchClassInstructor_Click_1(object sender, EventArgs e)
        {
            //Search for classes by a instructor by name
            try
            {
                DataHandler handler = new DataHandler();
                dgMembers.DataSource = handler.ReadClassesByInstructor(txtInstructorToSearch.Text);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when selecting that instructor's classes from the database.");
            }
        }

        private void btnManageMemberInsert_Click(object sender, EventArgs e)
        {
            //Insert a member with the values from the form into the database's table
            //create a new member using the values from the Form 
            Member m = new Member();
            m.MemberID = txtMemberID.Text;           
            m.FirstName = txtMemberFirstName.Text;            
            m.LastName = txtMemberLastName.Text;
            m.DateOfBirth = dtpMemberDOB.Value.ToShortDateString();
            m.Gender = cmbMemberGender.Text;
            m.PhoneNumber = txtMemberPhoneNumber.Text;
            m.Address = txtMemberAddress.Text;
            m.TrainingProgram = txtMemberTrainingProgram.Text;
            m.MembershipStartDate = dtpMemberStartDate.Value.ToShortDateString();
            m.MembershipEndDate = dtpMemberEndDate.Value.ToShortDateString();
            //use a function from the Members class to create/add the Member in the database 
            Member.Create(m.MemberID, m.FirstName, m.LastName, m.DateOfBirth,m.Gender, m.PhoneNumber, m.Address, m.TrainingProgram, m.MembershipStartDate, m.MembershipEndDate);
            //Display the new members on the datagridview
            DataHandler handler = new DataHandler();
            dgMembers.DataSource = handler.Read();
        }

        private void btnManageMemberUpdate_Click(object sender, EventArgs e)
        {
            //Update a member with the values from the form into the database's table            
            Member m = new Member();
            m.MemberID = txtMemberID.Text;
            m.FirstName = txtMemberFirstName.Text;
            m.LastName = txtMemberLastName.Text;
            m.DateOfBirth = dtpMemberDOB.Value.ToShortDateString();
            m.Gender = cmbMemberGender.Text;
            m.PhoneNumber = txtMemberPhoneNumber.Text;
            m.Address = txtMemberAddress.Text;
            m.TrainingProgram = txtMemberTrainingProgram.Text;
            m.MembershipStartDate = dtpMemberStartDate.Value.ToShortDateString();
            m.MembershipEndDate = dtpMemberEndDate.Value.ToShortDateString();
            //use a function from the Members class to create/add the Member in the database 
            Member.Update(m.MemberID, m.FirstName, m.LastName, m.DateOfBirth, m.Gender, m.PhoneNumber, m.Address, m.TrainingProgram, m.MembershipStartDate, m.MembershipEndDate);
            //Display the new members on the datagridview
            DataHandler handler = new DataHandler();
            dgMembers.DataSource = handler.Read();
        }

        private void btnManageMemberDelete_Click(object sender, EventArgs e)
        {
            //Delete a member that maches the member id from the members table in the database
            Member.Delete(txtMemberID.Text);
            //Display the updated members from the database after deleting the member with the matching member id
            DataHandler handler = new DataHandler();
            dgMembers.DataSource = handler.Read();
        }

        private void btnManageCreate_Click(object sender, EventArgs e)
        {
            //Warn the user that the information in the members table will be lost
            //Recreate the Members database table
        }

        private void btnManageMemberRemove_Click(object sender, EventArgs e)
        {
            ////Remove all the records from the members table in the database
            ////update the display grid view
            //try
            //{
                
            //    //Warn the user that the members table will be empty 
            //    var userAnswer = MessageBox.Show("Are you sure, this will remove existing member details from the system?", "Warning", MessageBoxButtons.YesNoCancel);
            //    if (userAnswer == DialogResult.Yes)
            //    {
            //        //drop the members table 
            //        string connString = "Server =.\\SQLExpress; Database =GymMembersDB; Integrated Security = SSPI";
                    
            //        string query = "DROP TABLE dbo.tblClasses;";
            //        using (SqlCommand cmd = new SqlCommand(query, connString))
            //        {
                        
            //            cmd.ExecuteNonQuery();
            //        }
            //            //then recreate the table and leave it empty
            //            //display the current state of the table
            //            DataHandler handler = new DataHandler();
            //        dgMembers.DataSource = handler.Read();
            //    }
            //    else if (userAnswer == DialogResult.No)
            //    {
            //        //the user chose to not continue with the operation
            //    }
            //    else if (userAnswer == DialogResult.Cancel)
            //    {
            //        //the user chose to not continue with the operation
            //    }
                //Recreate the table 
                //string query = @"CREATE TABLE tblClasses(
                //[Class\Program] int NOT NULL UNIQUE,
                //[Class\ProgramName] varchar(25),
                //ClassDescription varchar(255),
                //Instructor varchar(50),
                //Schedule varchar(50),
                //Capacity int,
                //Duration int);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("There was an error when removing all of the members");
            //}
        }

        private void btnCreateTextFileUser_Click(object sender, EventArgs e)
        {
            try
            {
                //Create a new empty users text file
                //Warn the user that the users text file will be empty
                var userAnswer = MessageBox.Show("Are you sure, this will remove existing user login details from the system?", "Warning", MessageBoxButtons.YesNoCancel);
                if (userAnswer == DialogResult.Yes)
                {
                    //the user chose to continue with re creating the text file
                    FileHandler handler = new FileHandler();
                    handler.NewEmptyUsersTextFile();
                    //display that the users are empty
                    handler.ReadUsers();
                }
                else if (userAnswer == DialogResult.No)
                {
                    //the user chose to not continue with the operation
                }
                else if (userAnswer == DialogResult.Cancel)
                {
                    //the user chose to not continue with the operation
                }
            }catch(Exception ex)
            {
                MessageBox.Show("There was an error when accessing the file, perhaps it is open in another application?");
            }


        }

        private void btnRemoveTextFileUser_Click(object sender, EventArgs e)
        {
            //Remove a User from the users text file by UserID
            User userToRemove = new User();
            //userToRemove.Id = Convert.ToInt32(txtManageUserID.Text);
            //loop through the Users text file lines to find the matching user


            //Update the view to show the users that are left
        }

        private void btnUpdateTextFileUser_Click_1(object sender, EventArgs e)
        {
            //Use the text box values to update a username, password and access level
            //Create a user object containing the values from the form
            User UserToUpdate = new User();
            //UserToUpdate.Id = Convert.ToInt16(txtManageUserID.Text);
            //UserToUpdate.Username = txtManageUsername.Text;
            //UserToUpdate.UserType = txtManageUserType.Text;
            //UserToUpdate.Password = txtManagePassword.Text;
            //Use a method in the Users class to get the line to update            
            int TextfileLineToUpdate = UserToUpdate.FindUserByUsername(UserToUpdate.Username);
            //Do the actual update in the textfile using the specified line
            FileHandler handler = new FileHandler();
            handler.UpdateSpecificLine(UserToUpdate.Id, UserToUpdate.Username,UserToUpdate.UserType,UserToUpdate.Password,TextfileLineToUpdate);
            //Display the changed users in the data grid view
            FileHandler handler2 = new FileHandler();
            dgMembers.DataSource = handler.ReadUsers();
        }

        private void btnDeleteTextFileUser_Click_1(object sender, EventArgs e)
        {
            //Delete a specific user by UserID
        }

        private void btnInsertTextFileUser_Click_1(object sender, EventArgs e)
        {
            //Insert a new user at the end of the text file

        }

        private void btnRemoveClass_Click(object sender, EventArgs e)
        {

        }

        public static void DisplayNemMembers()
        {
            DataHandler handler = new DataHandler();
            //dgMembers.DataSource = handler.Read();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenNewUserForm_Click(object sender, EventArgs e)
        {
            FrmAddNewUser frmAddNewUser = new FrmAddNewUser();
            frmAddNewUser.Show();
        }
    }
}

