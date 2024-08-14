using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRG262_BKV_8
{
    class DeleteClass
    {
        public static void DeleteClass1(string classID)
        {
            string connString = "Server =.\\SQLExpress; Database =GymMembersDB; Integrated Security = SSPI";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    int ProgramID = Convert.ToInt32(classID); 
                    string query = "DELETE FROM dbo.tblClasses WHERE [Class\\ProgramID] = @classID"; 
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@classID", ProgramID); 

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Class deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No class found with the specified ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "A database-related error has occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
