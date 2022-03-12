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
        private const string Path = @"D:\Programs\Chat1\chat.txt"; //   "T:\\903Б\\ovepfunkep's hub\\users.txt"    "D:\\Programs\\Chat1\\chat.txt"
        public ChatForm()
        {
            InitializeComponent();
            chatBox.Text = "Welcome to the club";
            LoggedIn = false;
            new LoginForm(this).ShowDialog();
        }

        private void LoadChat()
        {
            chatBox.Text = "";
            var chatText = File.ReadAllLines(Path);
            var countLines = chatText.Length;
            if (countLines > 15)
                for (var i = chatText.Length - 15; i<chatText.Length; i++)
                    chatBox.Text += chatText[i] + "\n";
            else chatBox.Text = String.Join('\n',File.ReadAllLines(Path));
        }

        private bool _loggedIn;
        public bool LoggedIn
        {
            get { return _loggedIn; }
            set
            {
                if (!value)
                {
                    messageBox.Text = "You are not authorised to send messages";
                    messageBox.ReadOnly = true;
                    timer1.Enabled = false;
                    _loggedIn = false;
                }
                else
                {
                    messageBox.Text = "Enter your message";
                    messageBox.ReadOnly = false;
                    timer1.Enabled = true;
                    _loggedIn = true;
                }
            }
        }
        private void LoadChatBt_Click(object sender, EventArgs e)
        {
            LoadChat();
            chatBox.SelectionStart = chatBox.Text.Length;
        }

        private void SendMessageBt_Click(object sender, EventArgs e)
        {
            File.AppendAllText(Path,$"{UsernameTextBox.Text}: {messageBox.Text}\n");
            messageBox.Text = "";
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadChat();
        }
    }
}
