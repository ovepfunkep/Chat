using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static WinFormsApp1.Utilities;
using static WinFormsApp1.Utilities.Methods;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        private ChatForm form1;
        public LoginForm(ChatForm form)
        {
            InitializeComponent();
            form1 = form;
        }

        bool CheckTextBoxes()
        {
            return (enterLoginBox.Text != "" && enterLoginBox.Text != "Enter login" &&
                enterPasswordBox.Text != "" && enterPasswordBox.Text != "Enter password");
        }

        private bool CheckUser (string mode)
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                string query;
                if (mode == "login") query = "select * from Users where Nickname = @Nickname and Password = @Password";
                else query = "select * from Users where Nickname = @Nickname";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("Nickname", enterLoginBox.Text);
                if (mode == "login") command.Parameters.AddWithValue("Password", enterPasswordBox.Text);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) return true;
                return false;
            }
        }
        private void RegBt_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
                if (!CheckUser("register"))
                {
                    using (SqlConnection connection = new(connectionString))
                    {
                        connection.Open();
                        string query = "Insert into Users values (@Nickname,@Password,2)";
                        SqlCommand command = new(query, connection);
                        command.Parameters.AddWithValue("Nickname", enterLoginBox.Text);
                        command.Parameters.AddWithValue("Password", enterPasswordBox.Text);
                        command.ExecuteNonQuery();
                        query = "Insert into ChatsUsers values " +
                            "((Select Id from Chats where Chats._name = 'Flood'), " +
                            "(Select Id from Users where Users.Nickname = @Nickname))";
                        SqlCommand command2 = new(query, connection);
                        command2.Parameters.AddWithValue("Nickname", enterLoginBox.Text);
                        command2.ExecuteNonQuery();
                    }
                    MessageBox.Show("You are succesfully registered", "Open chat");
                    EnterBt_Click(sender,e);
                }
                else MessageBox.Show("User already exists", "Ok");
            else MessageBox.Show("Fields filled incorrectly!");
        }

        private void EnterBt_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
                if (CheckUser("login"))
                {
                    form1.Show();
                    UpdateUserStatus(enterLoginBox.Text, "Online");
                    form1.UpdateChatForm(enterLoginBox.Text);
                    form1.LoadChat();
                    this.Close();
                }
                else MessageBox.Show("User isn't exists", "Ok");
            else MessageBox.Show("Fields filled incorrectly!");
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
