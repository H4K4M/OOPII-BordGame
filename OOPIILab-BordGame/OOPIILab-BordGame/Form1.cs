using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPIILab_BordGame
{
    public partial class Form1 : Form
    {
        string usr;
        string pass;
        public Form1()
        {
            InitializeComponent();
            textBox1.Focus();
            label4.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((usr == "user" && pass == "user") || (usr == "admin" && pass == "admin"))
            {
               //go to the game
            }
            else
                label4.Show();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            usr = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pass = textBox1.Text;
        }
    }
}
