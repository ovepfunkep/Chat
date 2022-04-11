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
using static WinFormsApp1.Utilities;
using static WinFormsApp1.Utilities.Methods;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class ChatForm : Form
    {
        public ChatForm()
        {
            InitializeComponent();
            chatBox.Text = "Welcome to the club";
            new LoginForm(this).ShowDialog();
        }

        private void LoadChat()
        {
            chatBox.Text = "";
            string curChatName;
            if (tabControl1.SelectedIndex != tabControl1.TabCount - 1) curChatName = tabControl1.SelectedTab.Text;
            else return;
            using (SqlConnection connection = new(connectionString))
            {

            }
            //var chatText = File.ReadAllLines(Path);
            //var countLines = chatText.Length;
            //if (countLines > 15)
            //    for (var i = chatText.Length - 15; i<chatText.Length; i++)
            //        chatBox.Text += chatText[i] + "\n";
            //else chatBox.Text = String.Join('\n',File.ReadAllLines(Path));

        }

        public void UpdateChatForm(string username = "")
        {
            if (username == "")
            {
                UsernameTextBox.Text = username;
                messageBox.Text = "You are not authorised to send messages";
                messageBox.ReadOnly = true;
                timer1.Enabled = false;
                sendMessageBt.Enabled = false;
                loadChatBt.Enabled = false;
            }
            else
            {
                UsernameTextBox.Text = username;
                messageBox.Text = "Enter your message";
                messageBox.ReadOnly = false;
                timer1.Enabled = true;
                sendMessageBt.Enabled = true;
                loadChatBt.Enabled = true;
            }
        }

        private void LoadChatBt_Click(object sender, EventArgs e)
        {
            LoadChat();
        }

        private void SendMessageBt_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new(connectionString))
            {
                string query = "Insert into "
            }
            messageBox.Text = "";
        }

        private void MessageBox_Enter(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text != "") messageBox.Text = "";
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
            UpdateUserStatus(UsernameTextBox.Text, "Offline");
            UpdateChatForm();
            new LoginForm(this).ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadChat();
        }

        private void ChatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateUserStatus(UsernameTextBox.Text, "Offline");
        }
    }
}
