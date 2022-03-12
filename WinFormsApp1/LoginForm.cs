using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        //   "T:\903Б\ovepfunkep's hub\users.txt"    "D:\Programs\Chat1\users.txt"
        private const string pathUsers = @"D:\Programs\Chat1\users.txt";
        private const bool T = true;
        private const bool F = false;

        public LoginForm(ChatForm form)
        {
            InitializeComponent();
            form1 = form;
        }

        private ChatForm form1;

        private void RegBt_Click(object sender, EventArgs e)
        {
            if (enterLoginBox.Text != "Enter login" && enterPasswordBox.Text != "Enter Password" && enterLoginBox.Text.Length > 3 && enterPasswordBox.Text.Length > 3)
            {
                var users = File.ReadAllLines(pathUsers);
                var i = Array.IndexOf(users,"`" + enterLoginBox.Text);
                if (i == -1)
                {
                    File.AppendAllText(pathUsers, $"`{enterLoginBox.Text}\n{enterPasswordBox.Text}\n");
                    enterLoginBox.Text = "Enter login";
                    enterPasswordBox.Text = "Enter Password";
                    WelcomeLabel.Text = "Now enter login and password again";
                }
                else WelcomeLabel.Text = "User already exists";
            }
            else WelcomeLabel.Text = "Try entering login and password.\n Both should be more than 3 symbols";
        }

        private void EnterBt_Click(object sender, EventArgs e)
        {
            var users = File.ReadAllLines(pathUsers);
            var i = Array.IndexOf(users,"`"+enterLoginBox.Text);
            WelcomeLabel.Text = $"{i}";
            if ((i != -1) && (users[i + 1] == enterPasswordBox.Text))
            {
                form1.Show();
                form1.UsernameTextBox.Text = enterLoginBox.Text;
                form1.LoggedIn = T;
                this.Close();
            }
            else WelcomeLabel.Text = "Somtehing went wrong...";
        }

        private void EnterPasswordBox_Enter(object sender, EventArgs e)
        {
            if (enterPasswordBox.Text == "Enter password") enterPasswordBox.Text = "";
        }

        private void EnterPasswordBox_Leave(object sender, EventArgs e)
        {
            if (enterPasswordBox.Text == "") enterPasswordBox.Text = "Enter password";
        }

        private void EnterLoginBox_Enter(object sender, EventArgs e)
        {
            if (enterLoginBox.Text == "Enter login") enterLoginBox.Text = "";
        }

        private void EnterLoginBox_Leave(object sender, EventArgs e)
        {
            if (enterLoginBox.Text == "") enterLoginBox.Text = "Enter login";
        }
    }
}
