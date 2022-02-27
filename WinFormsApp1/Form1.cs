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
    public partial class Form1 : Form
    {
        private const string Path = "D:\\Programs\\Chat\\chat.txt"; //   "T:\\903Б\\lab11Tyabin\\users.txt"    "D:\\Programs\\Chat\\chat.txt"
        public Form1()
        {
            InitializeComponent();
            chatBox.Text = "Welcome to the club";
            new Form2(this).ShowDialog();
        }

        private void LoadChatBt_Click(object sender, EventArgs e)
        {
            chatBox.Text = String.Join('\n', File.ReadAllLines(Path));
        }

        private void SendMessageBt_Click(object sender, EventArgs e)
        {
            File.AppendAllText(Path,$"{usernameLabel.Text}: {messageBox.Text}\n");
        }

        private void MessageBox_Enter(object sender, EventArgs e)
        {
            messageBox.Text = "";
        }

        private void messageBox_Leave(object sender, EventArgs e)
        {
            if (messageBox.Text == "") messageBox.Text = "Enter your message";
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {
            new Form2(this).ShowDialog();
        }
    }
}
