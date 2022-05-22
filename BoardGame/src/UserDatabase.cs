using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
namespace BoardGame.src
{
    public class UserDatabase
    {
        User user;
        List<User> users = new List<User>();
        //---------For SQL Local PC Host-----------#
        //private string connString = @"Data Source=H4K4M\SQLEXPRESS;Initial Catalog=users;MultipleActiveResultSets = True; Integrated Security=True";
        
        //--------For SQL Somee online cloud Host---------//
        private string connString = @"Data Source=UserDatabase.mssql.somee.com;Initial Catalog=UserDatabase;Persist Security Info=True;User ID=hakamkk123_SQLLogin_1;Password=qj4mbyoxwq";
        
        private static UserDatabase INSTANCE = null;

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
            ReadUserDatabase();
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
            InMemoryUserDatabase[username].UserHighScore = Edituser.UserHighScore;
            SqlConnection conn = new SqlConnection(connString);

            string query = "update dbo.Users set NameSurname=@NameSurname,PhoneNumber = @PhoneNumber,Address =  @Address" +
                ",City = @City,Country = @Country,Email = @Email,Usertype = @Usertype,HighScore = @HighScore where UserName = @UserName";
                   

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@UserName", InMemoryUserDatabase[username].UserName);
            cmd.Parameters.AddWithValue("@NameSurname", InMemoryUserDatabase[username].NameSurname);
            cmd.Parameters.AddWithValue("@PhoneNumber", InMemoryUserDatabase[username].PhoneNumber);
            cmd.Parameters.AddWithValue("@Address", InMemoryUserDatabase[username].Address);
            cmd.Parameters.AddWithValue("@City", InMemoryUserDatabase[username].City);
            cmd.Parameters.AddWithValue("@Country", InMemoryUserDatabase[username].Country);
            cmd.Parameters.AddWithValue("@Email", InMemoryUserDatabase[username].Email);
            if (InMemoryUserDatabase[username].UserType == UserType.ADMIN) cmd.Parameters.AddWithValue("@Usertype", 0);
            else cmd.Parameters.AddWithValue("@Usertype", 1);
            cmd.Parameters.AddWithValue("@HighScore", InMemoryUserDatabase[username].UserHighScore);
            cmd.ExecuteNonQuery();
            //}
            conn.Close();
        }
        public bool RegisterUserIfUserNameNotExists(User user)
        {
            if (InMemoryUserDatabase.ContainsKey(user.UserName))
            {
                throw new ArgumentException("Username already exists.");
            }

            InMemoryUserDatabase.Add(user.UserName, user);

            WriteUserDatabase();

            return true;
        }
        public List<User> listUser()
        {
            ReadUserDatabase();
            return users;
        }
        public void DeleteUser(string username)
        {
            try
            {
                string query = "delete from dbo.Users where UserName = @UserName";
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@UserName", InMemoryUserDatabase[username].UserName);
                cmd.ExecuteNonQuery();
                users.Remove(InMemoryUserDatabase[username]);
                conn.Close();
                
            }
            catch
            {
                throw new ArgumentException("This User name can not Delete");
            }
        }
        private void ReadUserDatabase()
        {
            InMemoryUserDatabase.Clear();
            string query = "select * from dbo.Users";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
        
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();
     
            da.Fill(dataTable);
            users.Clear();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                User user = new User();
                user.UserName = dataTable.Rows[i]["UserName"].ToString();
                user.PassWord = dataTable.Rows[i]["Password"].ToString();
                user.NameSurname = dataTable.Rows[i]["NameSurname"].ToString();
                user.PhoneNumber = dataTable.Rows[i]["PhoneNumber"].ToString(); ;
                user.Address = dataTable.Rows[i]["Address"].ToString();
                user.City = dataTable.Rows[i]["City"].ToString();
                user.Country = dataTable.Rows[i]["Country"].ToString();
                user.Email = dataTable.Rows[i]["Email"].ToString();
                int usertype = Convert.ToInt32(dataTable.Rows[i]["Usertype"]);
                if(usertype == 0) user.UserType = UserType.ADMIN;
                else user.UserType = UserType.USER;
                user.UserHighScore = Convert.ToInt32(dataTable.Rows[i]["HighScore"]);
                users.Add(user);
            }
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
            conn.Close();
            da.Dispose();
        }
        private void WriteUserDatabase()
        {            
            List<User> users = InMemoryUserDatabase.Values.ToList();

            SqlConnection conn = new SqlConnection(connString);
            
            string query = "insert into dbo.Users(UserName,Password,NameSurname,PhoneNumber,Address,City,Country,Email,Usertype,HighScore) " +
                    "values(@UserName, @Password, @NameSurname, @PhoneNumber, @Address, @City, @Country, @Email, @Usertype, @HighScore)";
                
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@UserName", users[users.Count-1].UserName);
            cmd.Parameters.AddWithValue("@Password", users[users.Count - 1].PassWord);
            cmd.Parameters.AddWithValue("@NameSurname", users[users.Count - 1].NameSurname);
            cmd.Parameters.AddWithValue("@PhoneNumber", users[users.Count - 1].PhoneNumber);
            cmd.Parameters.AddWithValue("@Address", users[users.Count - 1].Address);
            cmd.Parameters.AddWithValue("@City", users[users.Count - 1].City);
            cmd.Parameters.AddWithValue("@Country", users[users.Count - 1].Country);
            cmd.Parameters.AddWithValue("@Email", users[users.Count - 1].Email);
            if (users[users.Count - 1].UserType == UserType.ADMIN) cmd.Parameters.AddWithValue("@Usertype", 0);
            else cmd.Parameters.AddWithValue("@Usertype", 1);
            cmd.Parameters.AddWithValue("@HighScore", users[users.Count - 1].UserHighScore);
            cmd.ExecuteNonQuery();
            
            conn.Close();
            

        }
        public UserType GetUserType()
        {
            return user.UserType;
        }
    }
}
