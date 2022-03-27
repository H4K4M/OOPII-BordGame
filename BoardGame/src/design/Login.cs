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

        private readonly UserDatabase userDatabase = new UserDatabase();

        public LoginPage()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String usernameText = usernameTextBox.Text;
            String passwordText = passwordTextBox.Text;

            try
            {
                userDatabase.IsUserExistsWithUsernameAndPassword(usernameText, passwordText);

                MainMenuPage mainMenuPage = new MainMenuPage();
                mainMenuPage.Show();
                this.Hide();
            }
            catch (ArgumentException Exception)
            {
                usernamePasswordWarningLabel.Text = Exception.Message;
                usernamePasswordWarningLabel.Visible = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
