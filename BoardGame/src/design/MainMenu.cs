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
            settingpage.Hide();
        }

        private void settingbutton_Click(object sender, EventArgs e)
        {
            settingpage.Show();
            if (custom.Checked)
            {
                text.Show();
                label1.Show();
                textBox1.Show();
                textBox2.Show();
            }
            else
            {
                text.Hide();
                label1.Hide();
                textBox1.Hide();
                textBox2.Hide();
            }
        }

        private void custom_CheckedChanged(object sender, EventArgs e)
        {
            if (custom.Checked) 
            {
                text.Show();
                label1.Show();
                textBox1.Show();
                textBox2.Show();
            }
            else
            {
                text.Hide();
                label1.Hide();
                textBox1.Hide();
                textBox2.Hide();
            }
            
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            easy.Checked = false;
            hard.Checked = false;
            normal.Checked = false;
            custom.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox2.Checked = false;
            RedColour.Checked = false;
            GreenColour.Checked = false;
            BlueColour.Checked = false;
            settingpage.Hide();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            Settings1.Default.easy = easy.Checked;
            Settings1.Default.hard = hard.Checked;
            Settings1.Default.normal = normal.Checked;
            Settings1.Default.custom = custom.Checked;
            Settings1.Default.square = checkBox1.Checked;
            Settings1.Default.triangle = checkBox2.Checked;
            Settings1.Default.round = checkBox3.Checked;
            Settings1.Default.texbox1 = textBox1.Text;
            Settings1.Default.textbox2 = textBox2.Text;
            Settings1.Default.red = RedColour.Checked;
            Settings1.Default.blue = BlueColour.Checked;
            Settings1.Default.green = GreenColour.Checked;
            Settings1.Default.Save();
            settingpage.Hide();
        }

        private void MainMenuPage_Load(object sender, EventArgs e)
        {
            easy.Checked = Settings1.Default.easy;
            hard.Checked = Settings1.Default.hard;
            normal.Checked = Settings1.Default.normal;
            custom.Checked = Settings1.Default.custom;
            checkBox1.Checked = Settings1.Default.square;
            checkBox2.Checked = Settings1.Default.triangle;
            checkBox3.Checked = Settings1.Default.round;
            textBox1.Text = Settings1.Default.texbox1;
            textBox2.Text = Settings1.Default.textbox2;
            RedColour.Checked = Settings1.Default.red;
            BlueColour.Checked = Settings1.Default.blue;
            GreenColour.Checked = Settings1.Default.green;
        }

        private void quitbutton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            //this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
