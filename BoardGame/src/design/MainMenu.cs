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
        private string thisUsername;
        private Board board;
        public MainMenuPage(string username = "")
        {
            UserDatabase = UserDatabase.GetInstance();
            InitializeComponent();           
            thisUsername = username;                        
        }
        public void AddCellToBoardPanel(Cell cell)
        {
            BoardPanel.Controls.Add(cell);
        }

        public void SetBoardPanelDimensions(int rowSize, int columnSize, int buttonWidth, int buttonHeight)
        {
            BoardPanel.Height = buttonHeight * rowSize;
            BoardPanel.Width = buttonWidth * columnSize;
        }

        public void DetermineBoardSize()
        {
            int CustomRow = int.Parse(Settings1.Default.texbox1);
            int CustomColumn = int.Parse(Settings1.Default.textbox2);

            if (Settings1.Default.easy == true)
            {
                board = new Board(15, 15, this, thisUsername);
            }
            if (Settings1.Default.normal == true)
            {
                board = new Board(9, 9, this, thisUsername);
            }
            if (Settings1.Default.hard == true)
            {
                board = new Board(6, 6, this, thisUsername);
            }
            if (Settings1.Default.custom == true)
            {
                board = new Board(CustomRow, CustomColumn, this, thisUsername);
            }
        }
        private void settingbutton_Click(object sender, EventArgs e)
        {
            SettingPage settingPage = new SettingPage(this);
            settingPage.TopMost = true;
            settingPage.ShowDialog();
        }
        private void quitbutton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Profilebut_Click(object sender, EventArgs e)
        {
            Profiles profiles = new Profiles();
            profiles.ShowDialog();
        }

        private void MainMenuPage_Load(object sender, EventArgs e)
        {
            BoardPanel.Controls.Clear();
            DetermineBoardSize();
            
            UserType userType = UserDatabase.GetUserType();
            if(userType == UserType.USER)
            {
                managebut.Hide();
            }
            
            HighscoreLable.Text += UserDatabase.getuserInfoByUsername(thisUsername).UserHighScore.ToString();
            
        }
        private void managebut_Click(object sender, EventArgs e)
        {
            UserManagment userManagment = new UserManagment();           
            userManagment.ShowDialog();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void helpbutton_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.TopMost = true;
            help.ShowDialog();
        }

        private void MultiPlayerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Connecting connecting = new Connecting(thisUsername);
            connecting.ShowDialog();
        }

        private void MainMenuPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
