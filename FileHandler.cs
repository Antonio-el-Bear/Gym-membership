using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG262_BKV_8
{
    class FileHandler
    {

        private static List<User> adminUsers = new List<User>();
        private static List<User> userList = new List<User>();

        public static List<User> UserList { get => userList; set => userList = value; }
        public static List<User> AdminUsers { get => adminUsers; set => adminUsers = value; }

        //Read method to read username and password from textfile
        public List<User> ReadUsers()
        {
            string path = "Users.txt";

            StreamReader reader = new StreamReader(path);
            string line;
            //starting with no users 
            int userCount = 0;
            while ((line = reader.ReadLine()) != null)
            {
                //user id will start at 1
                userCount++;
                string[] items = line.Split(',');
                UserList.Add(new User(userCount, items[0], items[1], items[2]));
                //if a user is an admin add the user to the adminUsers list
                if (items[2] == "admin")
                {
                    AdminUsers.Add(new User(userCount, items[0], items[1], items[2]));
                }

            }
            reader.Close();
            return userList;

        }
        // find out if a user is an admin
        public int UserLineInTextfile(string usernameToFind)
        {
            string path = "Users.txt";

            StreamReader reader = new StreamReader(path);
            string line;
            int lineFound=0;
            //starting with no users 
            int userCount = 0;
            while ((line = reader.ReadLine()) != null)
            {
                //user id will start at 1
                userCount++;
                string[] items = line.Split(',');
                UserList.Add(new User(userCount, items[0], items[1], items[2]));
                //Check if the username matches
                if (items[0] ==usernameToFind)
                {
                    // the userCount should currently match the line number in the Users file
                    lineFound = userCount;
                    //exit the loop once the username has been found
                    break;
                }
                

            }
            reader.Close();
            return lineFound;

        }
        public bool IsUserAdmin(string username)
        {
            bool result = false;


            return result;
        }

        //Write method to add users to the textfile

        public static void Write() 
        {
            string path = "Users.txt";
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate,FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (User u in UserList)
            {
                writer.WriteLine(u.Username + "," + u.Password + "," + u.UserType);
            }

            writer.Close();
            stream.Close();

        
        }  

        //Insert a new user at the end of the users text file
        public void InsertNewUser(string username, string password, string userType)
        {
            string path = "Users.txt";
            FileStream stream = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine($"{username},{password},{userType}");
            writer.Close();
            stream.Close();
        }

        public int SearchForUser(string username)
        {
            //Return the line number of the user searched for in the textfile
            int lineToRemove = 0;
            string path = "Users.txt";
            StreamReader reader = new StreamReader(path);
            //Get the userlist from the ReadUsers function
            FileHandler handler = new FileHandler();
            //store the users in a temporary list
            List<User> usersToSearch = new List<User>();

            usersToSearch = handler.ReadUsers();
            int lineCount = 1;
            foreach (User u in usersToSearch)
            {
                if (u.Username == username)
                {
                    //found the user at this line
                    //exit the loop
                    MessageBox.Show("Found user at text file line "+lineCount);
                    break;
                }
                else
                {
                   lineCount++;
                }

            }
            lineToRemove = lineCount;
            reader.Close();
            return lineToRemove;
        }

        public void RemoveLineFromTextfile(int lineToDelete)
        {
            string line = null;
            int lineNumber= 0;
            try
            {


                using (StreamReader reader = new StreamReader("Users.txt"))
                {
                    using (StreamWriter writer = new StreamWriter("Users.txt"))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            lineNumber++;
                            if (lineNumber != lineToDelete) //do not write the line we want to remove
                                writer.WriteLine(line);
                        }
                        writer.Close();
                    }
                    
                    reader.Close();
                }
                
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void NewEmptyUsersTextFile()
        {
            string path = "Users.txt";
            if (File.Exists(path))
            {
                StreamWriter writer = new StreamWriter(path);
                // Write an empty text file in place of Users.txt in its place
                if (File.Exists("Users.txt"))
                {
                    File.Delete(path);
                    File.WriteAllText(path, "");
                }
                writer.Close(); 
               
            }
        }

        public void ChangeTextAppStatusFalse()
        {
            string path = "SystemStatus.txt";
            if (File.Exists(path))
            {
                StreamWriter writer = new StreamWriter(path);
                // Write the status to the text file
                if (File.Exists("Users.txt"))
                {
                    File.Delete(path);
                    File.WriteAllText(path, "Locked,false");
                }
                writer.Close();

            }
        }
        public void ChangeTextAppStatusTrue()
        {
            string path = "SystemStatus.txt";
            if (File.Exists(path))
            {
                StreamWriter writer = new StreamWriter(path);
                // Write the status to the text file
                if (File.Exists("Users.txt"))
                {
                    File.Delete(path);
                    File.WriteAllText(path, "Locked,true");
                }
                writer.Close();

            }
        }
        public void UpdateSpecificLine(int id, string username, string usertype, string password ,int lineRemove)
        {
            string line = null;
            int lineNumber = 0;
            try
            {


                using (StreamReader reader = new StreamReader("Users.txt"))
                {
                    using (StreamWriter writer = new StreamWriter("Users.txt"))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            lineNumber++;
                            if (lineNumber != lineRemove) //do not write the line we want to remove
                                writer.WriteLine(line);
                        }
                        writer.Close();
                    }
                    reader.Close();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
