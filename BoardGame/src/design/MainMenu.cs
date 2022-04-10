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
    public partial class MainMenuPage : Form
    {
        private readonly UserDatabase UserDatabase;
        public MainMenuPage()
        {
            UserDatabase = UserDatabase.GetInstance();
            InitializeComponent();
        }

        private void settingbutton_Click(object sender, EventArgs e)
        {
            SettingPage settingPage = new SettingPage();
            settingPage.TopMost = true;
            settingPage.Show();
        }
        private void quitbutton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            //this.Close();
        }

        private void Profilebut_Click(object sender, EventArgs e)
        {
            Profiles profiles = new Profiles();
            profiles.TopMost = true;
            profiles.Show();
        }

        private void MainMenuPage_Load(object sender, EventArgs e)
        {
            UserType userType = UserDatabase.GetUserType();
            if(userType == UserType.USER)
            {
                managebut.Hide();
            }           
        }

        private void managebut_Click(object sender, EventArgs e)
        {
            UserManagment userManagment = new UserManagment();
            userManagment.TopMost = true;
            userManagment.Show();
        }
    }
}
