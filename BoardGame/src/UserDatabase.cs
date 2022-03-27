using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.src
{
    class UserDatabase
    {
        private Dictionary<String, String> InMemoryUserDatabase = new Dictionary<String, String>
        {
            // Username - Password

            { "admin", "admin" },
            { "user", "user" }
        };

        public bool IsUserExistsWithUsernameAndPassword(String username, String password)
        {
            String userPassword = InMemoryUserDatabase[username];

            if (userPassword.Equals(password))
            {
                return true;
            }

            throw new ArgumentException("Username and password did not matched.");
        }
    }
}
