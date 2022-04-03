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
        public MainMenuPage()
        {
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
    }
}
