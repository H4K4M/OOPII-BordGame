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
                User user = InMemoryUserDatabase[username];

                if (user.PassWord.Equals(password))
                {
                    return true;
                }
            }

            throw new ArgumentException("Username and password did not matched.");
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

        private void ReadUserDatabaseJsonFile()
        {
            InMemoryUserDatabase.Clear();

            FileStream fileStream = File.Open(USER_DATABASE, FileMode.OpenOrCreate);

            using (StreamReader streamReader = new StreamReader(fileStream))
            {
                string userDatabase = streamReader.ReadToEnd();
                List<User> users = JsonConvert.DeserializeObject<List<User>>(userDatabase);

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
    }
}
