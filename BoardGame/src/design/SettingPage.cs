using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoardGame.src;
using BoardGame.src.design;

namespace BoardGame
{
    public partial class SettingPage : Form
    {

        private static int MAX_BOARD_WIDTH = 20;
        private static int MAX_BOARD_HEIGHT = 20;
        private static int MIN_BOARD_WIDTH = 6;
        private static int MIN_BOARD_HEIGHT = 6;
        private static int MIN_SELECTED_CHECKBOX_COUNT = 1;

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

            MainMenuPage mainMenuPage = new MainMenuPage();
            mainMenuPage.Show();
        }
        private void savebutton_Click(object sender, EventArgs e)
        {
            int CustomRow = int.Parse(textBox1.Text);
            int CustomColumn = int.Parse(textBox2.Text);

            try
            {
                if (ControlCheckBoxEnabledItemCount())
                {
                    if (ControlCustomDimensionsInput(CustomRow, CustomColumn))
                    {
                        throw new ArgumentException("Change custom difficulty to 6-20");
                    }

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

                    MainMenuPage mainMenuPage = new MainMenuPage();
                    mainMenuPage.Show();
                }
                else
                {
                    throw new ArgumentException("You must select more shapes or colors");
                }

                
            }
            catch (ArgumentException Exception)
            {
                SettingsWarning.Text = Exception.Message;
                SettingsWarning.Visible = true;
            }
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

        private bool ControlCheckBoxEnabledItemCount()
        {
            return (ColourBox.Controls.OfType<CheckBox>().Count(Item => Item.Checked) >= MIN_SELECTED_CHECKBOX_COUNT &&
                    ShapeBox.Controls.OfType<CheckBox>().Count(Item => Item.Checked) > MIN_SELECTED_CHECKBOX_COUNT) ||
                    (ColourBox.Controls.OfType<CheckBox>().Count(Item => Item.Checked) > MIN_SELECTED_CHECKBOX_COUNT &&
                    ShapeBox.Controls.OfType<CheckBox>().Count(Item => Item.Checked) >= MIN_SELECTED_CHECKBOX_COUNT);
        }

        private bool ControlCustomDimensionsInput(int CustomRow, int CustomColumn)
        {
            return (CustomRow > MAX_BOARD_HEIGHT || CustomRow < MIN_BOARD_HEIGHT || CustomColumn > MAX_BOARD_WIDTH || CustomColumn < MIN_BOARD_WIDTH);
        }
    }
}
