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

        private void RegBt_Click(object sender, EventArgs e)
        {
            /*
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
            */
            using ()
            {
                connection.Open();
                string query = "Insert into `Users` values ('@Login','@Password','Offline')";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("Login", enterLoginBox.Text);
                command.Parameters.AddWithValue("Password", enterPasswordBox.Text);
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Now enter login and password again", "oK");
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
            string connectString = "Database=" + database + ";Data Source=" + host + ";User=" + user + ";Password=" + password;
            using (connection = new MySqlConnection(connectString))
            {
                connection.Open();
                string query = "select * from Users where Login = @Login and Password = @Password";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("Login", enterLoginBox.Text);
                command.Parameters.AddWithValue("Password", enterPasswordBox.Text);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    form1.Show();
                    form1.UsernameTextBox.Text = enterLoginBox.Text;
                    form1.LoggedIn = true;
                    this.Close();
                }
            }          
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
