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
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = "Welcome to the club";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            richTextBox1.Text = "Welcome to the club";
            string line;
            StreamReader sr = new StreamReader("T:\\903Б\\lab11Tyabin\\chat.txt");
            while (1 == 1)
            {
                line = sr.ReadLine();
                if (line == null) break;
                richTextBox1.Text = richTextBox1.Text + "\n" + line;
            }
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text!="Enter your name")
            //{
            //    StreamWriter sr1 = new StreamWriter("T:\\903Б\\lab11Tyabin\\chat.txt");
            //    sr1.WriteLine(textBox1.Text + "::" + richTextBox2.Text);
            //    sr1.Close();
            //}
        }

        //private void textBox1_Enter(object sender, EventArgs e)
        //{
        //    textBox1.Text = null;
        //}

        //private void textBox1_Leave(object sender, EventArgs e)
        //{
        //    if (textBox1.Text == "") textBox1.Text = "Enter your name";
        //    else if (textBox1.Text != "Enter your name") richTextBox2.ReadOnly = false;
        //}

        private void richTextBox2_Enter(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
