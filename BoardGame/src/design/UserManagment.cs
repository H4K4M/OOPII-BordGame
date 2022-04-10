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
            List<string> usernamelist = UserDatabase.listUsername();
            for (int i = 0; i < usernamelist.Count; i++)
            {
                userlist.Items.Add(usernamelist[i]);
            }
        }

        private void deletebut_Click(object sender, EventArgs e)
        {
            if (userlist.SelectedItems.Count != 0)
            {
                while (userlist.SelectedIndex != -1)
                {
                    string username = userlist.GetItemText(userlist.SelectedItem);
                    userlist.Items.RemoveAt(userlist.SelectedIndex);
                    UserDatabase.DeleteUser(username);
                    panel1.Hide();
                }
                
            }
        }

        private void adduserbut_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void refreshbut_Click(object sender, EventArgs e)
        {
            userlist.Items.Clear();
            List<string> usernamelist = UserDatabase.listUsername();
            for (int i = 0; i < usernamelist.Count; i++)
            {
                userlist.Items.Add(usernamelist[i]);
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
            if (userlist.SelectedItems.Count != 0)
            {
                username = userlist.GetItemText(userlist.SelectedItem);
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
            User user = new User();

            user.NameSurname = textBox1.Text;

            if (textBox2.Text.Length > 0 && textBox2.Text != null && textBox2.Text != "")
            {
                user.PhoneNumber = long.Parse(textBox2.Text);
            }

            user.Address = textBox3.Text;
            user.City = textBox4.Text;
            user.Country = textBox5.Text;
            user.Email = textBox6.Text;

            string username = userlist.GetItemText(userlist.SelectedItem);
            UserDatabase.UpdateUserInfo(username,user);

            panel1.Hide();
        }
    }
}
