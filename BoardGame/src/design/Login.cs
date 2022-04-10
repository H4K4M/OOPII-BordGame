using BoardGame.src;
using BoardGame.src.design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGame
{
    public partial class LoginPage : Form
    {

        private readonly UserDatabase UserDatabase;

        public LoginPage()
        {
            UserDatabase = UserDatabase.GetInstance();
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String usernameText = usernameTextBox.Text;
            String passwordText = passwordTextBox.Text;

            try
            {
                UserDatabase.IsUserExistsWithUsernameAndPassword(usernameText, HashPassword.HashString(passwordText));
                Settings1.Default.username = usernameTextBox.Text;
                Settings1.Default.Save();
                MainMenuPage mainMenuPage = new MainMenuPage();               
                mainMenuPage.Show();
                
            }
            catch (ArgumentException Exception)
            {
                usernamePasswordWarningLabel.Text = Exception.Message;
                usernamePasswordWarningLabel.Visible = true;
            }
        }


        private void LoginPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                loginButton.PerformClick();
            }
        }

        private void usernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsNumber(ch))
            {
                e.Handled = true;
            }
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsNumber(ch))
            {
                e.Handled = true;
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            usernameTextBox.Text = Settings1.Default.username;
        }

        private void ShowPasswordButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = (char)0;
        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass.Checked) passwordTextBox.PasswordChar = (char)0;
            else passwordTextBox.PasswordChar = '*';
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
    }
}
