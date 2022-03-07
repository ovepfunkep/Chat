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
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class ChatForm : Form
    {
        private const string Path = "T:\\903Б\\ovepfunkep's hub\\chat.txt"; //   "T:\\903Б\\ovepfunkep's hub\\users.txt"    "D:\\Programs\\Chat\\chat.txt"
        public ChatForm()
        {
            InitializeComponent();
            chatBox.Text = "Welcome to the club";
            new LoginForm(this).ShowDialog();
        }

        private void LoadChatBt_Click(object sender, EventArgs e)
        {
            chatBox.Text = String.Join('\n', File.ReadAllLines(Path));
        }

        private void SendMessageBt_Click(object sender, EventArgs e)
        {
            File.AppendAllText(Path,$"{UsernameTextBox.Text}: {messageBox.Text}\n");
        }

        private void MessageBox_Enter(object sender, EventArgs e)
        {
            messageBox.Text = "";
        }

        private void messageBox_Leave(object sender, EventArgs e)
        {
            if (messageBox.Text == "") messageBox.Text = "Enter your message";
        }

        private void messageBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                SendMessageBt_Click(this, EventArgs.Empty);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            new LoginForm(this).ShowDialog();
        }
    }
}
