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
        private const string pathChat = "D:\\Programs\\Chat\\chat.txt"; //   "T:\\903Б\\lab11Tyabin\\chat.txt"    "D:\\Programs\\Chat\\chat.txt"
        private const string pathUsers = "D:\\Programs\\Chat\\users.txt";

        public Form2(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }

        private Form1 form1;

        private void button2_Click(object sender, EventArgs e)
        {
            //if ((textBox1.Text != "") && (textBox1.Text != "Enter username") && (textBox2.Text != "") && (textBox2.Text != "Enter password"))
            //{
            //    string line;
            //    int a = 0;
            //    StreamReader sr = new StreamReader(path);
            //    while (1 == 1)
            //    {
            //        if (a == 0)
            //        {
            //            a++;
            //            line = sr.ReadLine();
            //            if (line == null)
            //            {
            //                sr.Close();
            //                StreamWriter sr1 = new StreamWriter(path);
            //                sr1.WriteLine(textBox1.Text);
            //                sr1.WriteLine(textBox2.Text);
            //                sr1.Close();
            //                label2.Text = "Successful";
            //                textBox1.Text = "Enter username";
            //                textBox2.Text = "Enter password";
            //                break;
            //            }
            //            if (line == textBox1.Text)
            //            {
            //                label2.Text = "User already exists";
            //                break;
            //            }
            //        }
            //        else a--;
            //    }
            //    sr.Close();
            //}
            //else label2.Text = "Your blanks aren't entered";
        }


        private void RegBt_Click(object sender, EventArgs e)
        {
            if (enterLoginBox.Text != "Enter login" && enterPasswordBox.Text != "Enter Password" && enterLoginBox.Text.Length > 3 && enterPasswordBox.Text.Length > 3)
            {
                var users = File.ReadAllLines(pathUsers);
                var i = Array.IndexOf(users, enterLoginBox);
                if (i == -1)
                {
                    File.AppendAllText(pathUsers, $"{enterLoginBox.Text}\n{enterPasswordBox.Text}");
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
            var i = Array.IndexOf(users, enterLoginBox.Text);
            if ((i != -1) && (users[i + 1] == enterPasswordBox.Text))
            {
                form1.Show();
                form1.usernameLabel.Text = enterLoginBox.Text;
                enableToClose = true;
                this.Close();
            }
            else welcomeLabel.Text = "Somtehing went wrong...";
        }

        private void EnterPasswordBox_Enter(object sender, EventArgs e)
        {
            enterPasswordBox.Text = "";
        }

        private void EnterPasswordBox_Leave(object sender, EventArgs e)
        {
            if (enterPasswordBox.Text == "") enterPasswordBox.Text = "Enter password";
        }

        private void EnterLoginBox_Enter(object sender, EventArgs e)
        {
            enterLoginBox.Text = "";
        }

        private void EnterLoginBox_Leave(object sender, EventArgs e)
        {
            if (enterLoginBox.Text == "") enterLoginBox.Text = "Enter login";
        }

        private bool enableToClose = false; //Сделать так чтобы при закрытии просто все объекты на форме1 были RO (usernameLabel.Text!=Username)

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (enableToClose)
            {
                form1.logoutBt.Visible = true;
                form1.messageBox.Visible = true;
                form1.loadChatBt.Visible = true;
            }
        }
    }
}
