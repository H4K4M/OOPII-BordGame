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
    public partial class SettingPage : Form
    {
        public SettingPage()
        {
            InitializeComponent();
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
            this.Hide();
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
            this.Hide();
        }

        private void SettingPage_Load(object sender, EventArgs e)
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
    }
}
