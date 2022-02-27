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
    public partial class Form2 : Form
    {
       //   "T:\\903Б\\lab11Tyabin\\users.txt"    "D:\\Programs\\Chat\\users.txt"
        private const string pathUsers = "D:\\Programs\\Chat\\users.txt";
        private const bool T = true;
        private const bool F = false;

        public Form2(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }

        private Form1 form1;

        private void RegBt_Click(object sender, EventArgs e)
        {
            if (enterLoginBox.Text != "Enter login" && enterPasswordBox.Text != "Enter Password" && enterLoginBox.Text.Length > 3 && enterPasswordBox.Text.Length > 3)
            {
                var users = File.ReadAllLines(pathUsers);
                var i = Array.IndexOf(users, enterLoginBox);
                if (i == -1)
                {
                    File.AppendAllText(pathUsers, $"`{enterLoginBox.Text}\n{enterPasswordBox.Text}\n");
                    enterLoginBox.Text = "Enter login";
                    enterPasswordBox.Text = "Enter Password";
                    welcomeLabel.Text = "Now enter login and password again";
                }
                else welcomeLabel.Text = "User already exists";
            }
            else welcomeLabel.Text = "Try entering login and password.\n Both should be more than 3 symbols";
        }

        private void EnterBt_Click(object sender, EventArgs e)
        {
            var users = File.ReadAllLines(pathUsers);
            var i = Array.IndexOf(users,"`"+enterLoginBox.Text);
            welcomeLabel.Text = $"{i}";
            if ((i != -1) && (users[i + 1] == enterPasswordBox.Text))
            {
                form1.Show();
                form1.usernameLabel.Text = enterLoginBox.Text;
                enableToClose = T;
                this.Close();
            }
            else welcomeLabel.Text = "Somtehing went wrong...";
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

        private bool enableToClose = F; 

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (enableToClose)
            {
                form1.messageBox.Visible = T;
                form1.loadChatBt.Visible = T;
                form1.sendMessageBt.Visible = T;
            }
        }
    }
}
