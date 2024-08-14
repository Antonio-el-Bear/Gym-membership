using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG262_BKV_8
{
    class User
    {
        int id;
        string username;
        string password;
        string userType; // is the user an admin or just a member

        public User()
        {
        }

        public User(int id, string username, string password, string userType)
        {
            this.Username = username;
            this.Password = password;
            this.Id = id;
            this.UserType = userType;

        }

      
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }
        public string UserType { get => userType; set => userType = value; }

        public int FindUserByUsername(string usernameToFind)
        {
            string UsernameToFind = usernameToFind;
            int lineNumber = 0;
            //Search for the line number in the text file with the matching user
            FileHandler fileHandler = new FileHandler();

            lineNumber = fileHandler.UserLineInTextfile(UsernameToFind);

            //return the line number containing the user to find
            return lineNumber;
        }
    }
}
