using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG262_BKV_8
{
    class DataHandler
    {
        public DataHandler() { }

        string conn = "Server =.\\SQLExpress; Database =GymMembersDB; Integrated Security = SSPI";

        public DataTable Read()
        {
            // Get the Gym Members from Database
            string query = "Select * from Members";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ReadClasses() {
            //Get the Classes / programs from the database
            string query = "Select * from tblClasses";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable ReadClassesByInstructor(string instructor)
        {
            //Get the Classes / programs from the database
            string query = $"Select * from tblClasses where instructor like '{instructor}'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
    }
}
