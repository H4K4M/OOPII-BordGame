using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.src
{
    public class User
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string NameSurname { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }

        public UserType UserType { get; set; }

        public User() { }

        public User(string userName, string passWord, UserType userType)
        {
            this.UserName = userName;
            this.PassWord = passWord;
            this.UserType = userType;
        }
    }
}
