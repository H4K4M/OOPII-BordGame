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
    public partial class Profiles : Form
    {
        private readonly UserDatabase UserDatabase;
        public Profiles()
        {
            UserDatabase = UserDatabase.GetInstance();
            InitializeComponent();
            passctrltextbox.Hide();
            label1.Hide();
        }

        private void Profiles_Load(object sender, EventArgs e)
        {
            User userinfo = UserDatabase.getuserInfo();
            textBox1.Text = userinfo.NameSurname;
            textBox2.Text = userinfo.PhoneNumber.ToString();
            textBox3.Text = userinfo.Address;
            textBox4.Text = userinfo.City;
            textBox5.Text = userinfo.Country; 
            textBox6.Text = userinfo.Email;

        }

        private void editbut_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            textBox6.ReadOnly = false;
            passctrltextbox.Show();
            label1.Show();
            editbut.Hide();
        }

        private void canclebut_Click(object sender, EventArgs e)
        {
            User userinfo = UserDatabase.getuserInfo();
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox1.Text = userinfo.NameSurname;
            textBox2.Text = userinfo.PhoneNumber.ToString();
            textBox3.Text = userinfo.Address;
            textBox4.Text = userinfo.City;
            textBox5.Text = userinfo.Country;
            textBox6.Text = userinfo.Email;
            this.Close();
        }

        private void savebut_Click(object sender, EventArgs e)
        {
            User user = UserDatabase.getuserInfo();

            user.NameSurname = textBox1.Text;
            user.PhoneNumber = textBox2.Text;
            user.Address = textBox3.Text;
            user.City = textBox4.Text;
            user.Country = textBox5.Text;
            user.Email = textBox6.Text;

            String passwordText = passctrltextbox.Text;
            try
            {
                UserDatabase.checkIsPasswordCorect(HashPassword.HashString(passwordText), user);
                UserDatabase.UpdateUserInfo(user.UserName, user);
                this.Close();
            }
            catch (ArgumentException Exception)
            {
                label1.Text = Exception.Message;
            }         
        }
    }
}
