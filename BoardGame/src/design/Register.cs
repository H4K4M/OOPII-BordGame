﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BoardGame.src.design
{
    public partial class Register : Form
    {
        private readonly UserDatabase UserDatabase;

        public Register()
        {
            UserDatabase = UserDatabase.GetInstance();
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            User user = new User();

            // Get the user information from textboxes
            user.UserName = UsernameTxtBox.Text;
            user.PassWord = HashPassword.HashString(PasswordTxtBox.Text);
            user.NameSurname = NameSurnameTxTBox.Text;
            user.PhoneNumber = PhoneNumberTxtBox.Text;
            user.Address = AdressTxtBox.Text;
            user.City = CityTxtBox.Text;
            user.Country = CountryTxtBox.Text;
            user.Email = EmailTxtBox.Text;
            user.UserType = UserType.USER;

            try
            {
                if (UserDatabase.RegisterUserIfUserNameNotExists(user)) // Register the user if there is not a already registered user with same username.
                {
                    this.Close();
                    //LoginPage loginPage = new LoginPage();
                    //loginPage.Show();
                }
            }
            catch (ArgumentException Exception)
            {
                UsernameWarningLabel.Text = Exception.Message;
                UsernameWarningLabel.Visible = true;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //LoginPage loginPage = new LoginPage();
            //loginPage.Show();
        }

        private void PhoneNumberTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsNumber(ch))
            {
                e.Handled = true;
            }
        }
    }
}
