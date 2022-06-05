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
    public partial class Connecting : Form
    {
        private string username;
        public Connecting(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Connecting_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenuPage mainMenu = new MainMenuPage(this.username);
            mainMenu.Show();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" || textBox2.Text != "")
            {
                label2.Text = "Connecting";
                label2.ForeColor = Color.Blue;
                Task.Delay(500).Wait();              
                MultiplayerGame newGame = new MultiplayerGame(false, textBox1.Text, int.Parse(textBox2.Text));
                Visible = false;
                if (!newGame.IsDisposed)
                {
                    label2.Text = "Connected";
                    label2.ForeColor = Color.Green;
                    newGame.ShowDialog();
                }

                Visible = true;
               
                
            }
            else
            {
                label2.Text = "Please Fill up Host Ip adress and port";
                label2.ForeColor = Color.Red;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Connecting";
            label2.ForeColor = Color.Blue;
            Task.Delay(500).Wait();
            MultiplayerGame newGame = new MultiplayerGame(true);
            Visible = false;
           
            if (!newGame.IsDisposed)
            {
                label2.Text = "Connected";
                label2.ForeColor = Color.Green;
                newGame.ShowDialog();
            }
                
            Visible = true;
        }
    }
}
