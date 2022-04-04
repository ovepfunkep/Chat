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

        private bool CheckUser (string mode)
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                string query;
                if (mode == "login") query = "select * from Users where Nickname = @Nickname and Password = @Password";
                else query = "select * from Users where Nickname = @Nickname";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("Nickname", enterLoginBox.Text);
                if (mode == "login") command.Parameters.AddWithValue("Password", enterPasswordBox.Text);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) return true;
                return false;
            }
        }
        private void RegBt_Click(object sender, EventArgs e)
        {
            if (!CheckUser("register"))
            {
                using (SqlConnection connection = new(connectionString))
                {
                    connection.Open();
                    string query = "Insert into Users values (@Login,@Password,2)";
                    SqlCommand command = new(query, connection);
                    command.Parameters.AddWithValue("Login", enterLoginBox.Text);
                    command.Parameters.AddWithValue("Password", enterPasswordBox.Text);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("You are succesfully registered", "Ok");
            }
            else MessageBox.Show("User already exists", "Ok");
        }

        private void EnterBt_Click(object sender, EventArgs e)
        {
            /*
            var users = File.ReadAllLines(pathUsers);
            var i = Array.IndexOf(users,"`"+enterLoginBox.Text);
            if ((i != -1) && (users[i + 1] == enterPasswordBox.Text))
            {
                form1.Show();
                form1.UsernameTextBox.Text = enterLoginBox.Text;
                form1.LoggedIn = true;
                this.Close();
            }
            else WelcomeLabel.Text = "Somtehing went wrong...";
            */
            if (CheckUser("login"))
            {
                form1.Show();
                form1.UsernameTextBox.Text = enterLoginBox.Text;
                form1.LoggedIn = true;
                this.Close();
            }
            else MessageBox.Show("User isn't exists", "Ok");
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
