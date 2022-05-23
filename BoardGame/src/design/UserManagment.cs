using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGame.src.design
{
    public partial class UserManagment : Form
    {
        private readonly UserDatabase UserDatabase;
        
        public UserManagment()
        {
            UserDatabase = UserDatabase.GetInstance();
            InitializeComponent();
            panel1.Hide();
        }

        private void UserManagment_Load(object sender, EventArgs e)
        {
            List<User> userslist = UserDatabase.listUser();            
            for (int i = 0; i < userslist.Count; i++)
            {
                if (userslist[i].UserName != "admin" && userslist[i].UserName != "user")
                {
                    UserDataGridview.Rows.Add(userslist[i].UserName, userslist[i].UserHighScore.ToString());                   
               }
            }
        }

        private void deletebut_Click(object sender, EventArgs e)
        {
            
            if (UserDataGridview.SelectedCells.Count != 0 && UserDataGridview.CurrentCell.ColumnIndex == 0 
                && UserDataGridview.CurrentCell.Value != null && MessageBox.Show("Are you sure want to delete ", "Delete user", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string username = UserDataGridview.CurrentCell.Value.ToString();
                int i = UserDataGridview.CurrentCell.RowIndex;
                UserDataGridview.Rows.RemoveAt(i);
                UserDatabase.DeleteUser(username);
                panel1.Hide();               

            }
        }

        private void adduserbut_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.TopMost = true;          
            register.ShowDialog();
        }

        private void refreshbut_Click(object sender, EventArgs e)
        {
            UserDataGridview.Rows.Clear();
            List<User> userslist = UserDatabase.listUser();
            for (int i = 0; i < userslist.Count; i++)
            {
                if (userslist[i].UserName != "admin" && userslist[i].UserName != "user")
                {
                    UserDataGridview.Rows.Add(userslist[i].UserName, userslist[i].UserHighScore.ToString());
                }
            }

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            User userinfo = UserDatabase.getuserInfo();
            textBox1.Text = userinfo.NameSurname;
            textBox2.Text = userinfo.PhoneNumber.ToString();
            textBox3.Text = userinfo.Address;
            textBox4.Text = userinfo.City;
            textBox5.Text = userinfo.Country;
            textBox6.Text = userinfo.Email;
        }

        private void updatinfoubut_Click(object sender, EventArgs e)
        {
            string username;
            if (UserDataGridview.SelectedCells.Count !=0 && UserDataGridview.CurrentCell.ColumnIndex == 0 && UserDataGridview.CurrentCell.Value != null)
            {
                username = UserDataGridview.CurrentCell.Value.ToString();
                User userinfo = UserDatabase.getuserInfoByUsername(username);
                textBox1.Text = userinfo.NameSurname;
                textBox2.Text = userinfo.PhoneNumber.ToString();
                textBox3.Text = userinfo.Address;
                textBox4.Text = userinfo.City;
                textBox5.Text = userinfo.Country;
                textBox6.Text = userinfo.Email;

                panel1.Show();

            }
        }

        private void savebut_Click(object sender, EventArgs e)
        {
            string username = UserDataGridview.CurrentCell.Value.ToString();
           
            User user = UserDatabase.getuserInfoByUsername(username);

            user.NameSurname = textBox1.Text;           
            user.PhoneNumber = textBox2.Text;
            user.Address = textBox3.Text;
            user.City = textBox4.Text;
            user.Country = textBox5.Text;
            user.Email = textBox6.Text;

            
            UserDatabase.UpdateUserInfo(username,user);

            panel1.Hide();
        }
    }
}
