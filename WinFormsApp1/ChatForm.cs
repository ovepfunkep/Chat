using System;
using System.Collections.Generic;
using System.Windows.Forms;
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

        public void LoadChat()
        {
            using (SqlConnection connection = new(connectionString))
            {
                string query = "Select Users.Nickname,MessageText from Messages inner join Users on Users.Id = Messages.UserId inner join Chats on Chats.Id = Messages.ChatId where Chats.Id = (Select Id from Chats where Chats._name = @ChatName) order by SentTime";
                connection.Open();
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("ChatName", "Flood");
                SqlDataReader reader = command.ExecuteReader();
                chatBox.Text = "";
                while (reader.Read()) chatBox.Text += $"{reader[0]}» {reader[1]}\n";
            }

        }

        public void UpdateChatForm(string username = "")
        {
            if (username == "")
            {
                UsernameTextBox.Text = username;
                messageBox.Text = "You are not authorised to send messages";
                messageBox.ReadOnly = true;
                timerLoadChat.Enabled = false;
                sendMessageBt.Enabled = false;
                loadChatBt.Enabled = false;
            }
            else
            {
                UsernameTextBox.Text = username;
                messageBox.Text = "Enter your message";
                messageBox.ReadOnly = false;
                timerLoadChat.Enabled = true;
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
            chatBox.Text = "";
            using (SqlConnection connection = new(connectionString))
            {
                string query = "insert into Messages values " +
                    "((Select Id from Users where Nickname = @Nickname)," +
                    "@MessageText,@SentTime,(Select Id from Chats where Chats._name = @ChatName))";
                connection.Open();
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("Nickname", UsernameTextBox.Text);
                command.Parameters.AddWithValue("MessageText", messageBox.Text);
                command.Parameters.AddWithValue("SentTime", DateTime.Now);
                command.Parameters.AddWithValue("ChatName", "Flood");
                command.ExecuteNonQuery();
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

        private void ChatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateUserStatus(UsernameTextBox.Text, "Offline");
        }

        private void buttonSH_Click(object sender, EventArgs e)
        {
            if (richTextBoxUsers.Visible == false)
            {
                richTextBoxUsers.Visible = true;
                richTextBoxUsers.Clear();
                richTextBoxUsers.Text += "==Online==\n";
                List<String> list = getListUsers("online");
                foreach (string value in list)
                    richTextBoxUsers.Text += $"{value}\n";
                richTextBoxUsers.Text += "==Offline==\n";
                list = getListUsers("offline");
                foreach (string value in list)
                    richTextBoxUsers.Text += $"{value}\n";
            }
            else richTextBoxUsers.Visible = false;
        }

        private void timerLoadChat_Tick(object sender, EventArgs e)
        {
            LoadChat();
        }
    }
}
