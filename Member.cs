using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PRG262_BKV_8
{
    class Member
    {
        private string memberID;
        private string firstName;
        private string lastName;
        private string dateOfBirth;
        private string gender;
        private string phoneNumber;
        private string address;
        private string trainingProgram;
        private string membershipStartDate;
        private string membershipEndDate;

        public Member(string memberID, string firstName, string lastName, string dateOfBirth, string gender, string phoneNumber, string address, string trainingProgram, string membershipStartDate, string membershipEndDate)
        {
            this.memberID = memberID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.trainingProgram = trainingProgram;
            this.membershipStartDate = membershipStartDate;
            this.membershipEndDate = membershipEndDate;
        }

        public Member()
        {
        }

        public string MemberID { get => memberID; set => memberID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Gender { get => gender; set => gender = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public string TrainingProgram { get => trainingProgram; set => trainingProgram = value; }
        public string MembershipStartDate { get => membershipStartDate; set => membershipStartDate = value; }
        public string MembershipEndDate { get => membershipEndDate; set => membershipEndDate = value; }

        public static void AddToDatabase()
        {

        }

        //Member CRUD methods
        public static void Create(string memberID, string firstName,string lastName,string dateOfBirth,string gender, string phoneNumber,string address,string trainingProgram, string membershipStartDate,string membershipEndDate)
        {
            
            //add the new Member to the database 
            try
            {
                string connString = "Server =.\\SQLExpress; Database =GymMembersDB; Integrated Security = SSPI";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = "INSERT INTO Members ([MemberID], [FirstName], [LastName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [TrainingProgram], [MembershipStartDate], [MembershipEndDate]) " +
               "VALUES (@MemberID, @FirstName, @LastName, @DateOfBirth, @Gender, @PhoneNumber, @Address, @TrainingProgram, @MembershipStartDate, @MembershipEndDate)";
                    // Create a SQL Command to add the program or class using textbox text values
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@MemberID", memberID);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@TrainingProgram", trainingProgram);
                        cmd.Parameters.AddWithValue("@MembershipStartDate", membershipStartDate);
                        cmd.Parameters.AddWithValue("@MembershipEndDate", membershipEndDate);

                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    MessageBox.Show("The new member has been created successfully in the database.");
                   

                }
            }
            catch (Exception ex)
            {
                // If the database is not available, show a message to the user
                MessageBox.Show($"Error: {ex.Message}", "A database related error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void Read()
        {

        }
        public static void Update(string memberID, string firstName, string lastName, string dateOfBirth, string gender, string phoneNumber, string address, string trainingProgram, string membershipStartDate, string membershipEndDate)
        {
            //add the new Member to the database 
            try
            {
                string connString = "Server =.\\SQLExpress; Database =GymMembersDB; Integrated Security = SSPI";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = "UPDATE Members SET [FirstName] = @FirstName, [LastName] = @LastName, [DateOfBirth]"+
                        " = @DateOfBirth, [Gender] = @Gender, [PhoneNumber] = @PhoneNumber, [Address] = @Address, [TrainingProgram]"+"" +
                        " = @TrainingProgram, [MembershipStartDate] = @MembershipStartDate, [MembershipEndDate] = @MembershipEndDate WHERE [MemberID] = @MemberID;";
                    // Create a SQL Command to add the program or class using textbox text values
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@MemberID", memberID);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@TrainingProgram", trainingProgram);
                        cmd.Parameters.AddWithValue("@MembershipStartDate", membershipStartDate);
                        cmd.Parameters.AddWithValue("@MembershipEndDate", membershipEndDate);

                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    MessageBox.Show("The new member updated successfully in the database.");


                }
            }
            catch (Exception ex)
            {
                // If the database is not available, show a message to the user
                MessageBox.Show($"Error: {ex.Message}", "A database related error has occured while updating a member.");
            }

        }

        public static void Delete(string memberToDelete)
        {
            //Remove the specified member from the database
            try
            {
                string connString = "Server =.\\SQLExpress; Database =GymMembersDB; Integrated Security = SSPI";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = $"DELETE FROM Members where MemberID=@MemberID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@MemberID", memberToDelete);
                       

                        cmd.ExecuteNonQuery();
                    }
                    
                    conn.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show("Database error when deleting a member. "); }
        }


                //View member information in a ListView or DataGridView.
                public static void ViewMembers()
        {

        }
        //Search feature to find a member's information using ID or Name 
        public static void Search(int memberID)
        {

        }
        public static void Search(string memberName)
        {

        }

        //search feature to view all members assigned to the instructor
        //should return a list of members that match the instructor
        public static void SearchByInstructor(string instructor){

         }



    }
}
