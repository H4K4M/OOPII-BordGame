using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.src
{
    public class UserDatabase
    {
        User user;
        List<User> users;

        private static UserDatabase INSTANCE = null;

        private readonly static string USER_DATABASE = "users.json";

        private Dictionary<String, User> InMemoryUserDatabase = new Dictionary<String, User>();

        private Dictionary<String, User> PreRegisteredUsers = new Dictionary<String, User>
        {
            { "admin", new User("admin", HashPassword.HashString("admin"), UserType.ADMIN)},
            { "user", new User("user", HashPassword.HashString("user"), UserType.USER)}
        };

        public static UserDatabase GetInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new UserDatabase();
            }

            return INSTANCE;
        }

        private UserDatabase()
        {
            ReadUserDatabaseJsonFile();
        }

        public bool IsUserExistsWithUsernameAndPassword(String username, String password)
        {
            if (InMemoryUserDatabase.ContainsKey(username))
            {
                user = InMemoryUserDatabase[username];

                if (user.PassWord.Equals(password))
                {
                    return true;
                }
            }

            throw new ArgumentException("Username and password did not matched.");
        }

        public User getuserInfo()
        {
            return user;
        }

        public User getuserInfoByUsername(string username)
        {
            return InMemoryUserDatabase[username];
        }

        public bool checkIsPasswordCorect(String password, User Edituser)
        {
            if (user.PassWord.Equals(password))
            {
                UpdateUserInfo(user.UserName, Edituser);          
                return true;
            }
            throw new ArgumentException("Password is incorect.");
        }

        public void UpdateUserInfo(string username, User Edituser)
        {
            InMemoryUserDatabase[username].NameSurname = Edituser.NameSurname;
            InMemoryUserDatabase[username].PhoneNumber = Edituser.PhoneNumber;
            InMemoryUserDatabase[username].Address = Edituser.Address;
            InMemoryUserDatabase[username].City = Edituser.City;
            InMemoryUserDatabase[username].Country = Edituser.Country;
            InMemoryUserDatabase[username].Email = Edituser.Email;
            WriteUserDatabaseJsonFile();
        }

        public bool RegisterUserIfUserNameNotExists(User user)
        {
            if (InMemoryUserDatabase.ContainsKey(user.UserName))
            {
                throw new ArgumentException("Username already exists.");
            }

            InMemoryUserDatabase.Add(user.UserName, user);

            WriteUserDatabaseJsonFile();

            return true;
        }

        public List<string> listUsername()
        {
            List<string> usernamelist = new List<string>();
            ReadUserDatabaseJsonFile();
            for (int i = 0; i< users.Count; i++)
            {
                usernamelist.Add(users[i].UserName);
            }
            return usernamelist;
        }

        public void DeleteUser(string username)
        {
            using (StreamWriter streamWriter = File.CreateText(USER_DATABASE))
            {
                //List<User> users;
                users.Remove(InMemoryUserDatabase[username]);
                string userDatabase = JsonConvert.SerializeObject(users, Formatting.Indented);
                streamWriter.Write(userDatabase);
            }


        }

        private void ReadUserDatabaseJsonFile()
        {
            InMemoryUserDatabase.Clear();

            FileStream fileStream = File.Open(USER_DATABASE, FileMode.OpenOrCreate);

            using (StreamReader streamReader = new StreamReader(fileStream))
            {
                string userDatabase = streamReader.ReadToEnd();
                users = JsonConvert.DeserializeObject<List<User>>(userDatabase);

                if (users != null)
                {
                    foreach (User user in users)
                    {
                        InMemoryUserDatabase.Add(user.UserName, user);
                    }
                }
                else
                {
                    InMemoryUserDatabase = PreRegisteredUsers;
                }
            }
            fileStream.Close();
        }

        private void WriteUserDatabaseJsonFile()
        {
            using (StreamWriter streamWriter = File.CreateText(USER_DATABASE))
            {
                List<User> users = InMemoryUserDatabase.Values.ToList();
                string userDatabase = JsonConvert.SerializeObject(users, Formatting.Indented);
                streamWriter.Write(userDatabase);
            }
        }

        public UserType GetUserType()
        {
            return user.UserType;
        }
    }
}
