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
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "Enter username";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "") textBox2.Text = "Enter password";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();//////////////////11111111111111111111111111111111111111111////////////////////////////
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox1.Text != "Enter username") && (textBox2.Text != "") && (textBox2.Text != "Enter password"))
            {
                string line;
                int a = 0;
                StreamReader sr = new StreamReader("T:\\903Б\\lab11Tyabin\\users.txt");
                while (1 == 1)
                {
                    if (a == 0)
                    {
                        a++;
                        line = sr.ReadLine();
                        if (line == null)
                        {
                            sr.Close();
                            StreamWriter sr1 = new StreamWriter("T:\\903Б\\lab11Tyabin\\users.txt");
                            sr1.WriteLine(textBox1.Text);
                            sr1.WriteLine(textBox2.Text);
                            sr1.Close();
                            label2.Text = "Successful";
                            textBox1.Text = "Enter username";
                            textBox2.Text = "Enter password";
                            break;
                        }
                        if (line == textBox1.Text)
                        {
                            label2.Text = "User already exists";
                            break;
                        }
                    }
                    else a--;
                }
                sr.Close();
            }
            else label2.Text = "Your blanks aren't entered";
        }

    }
}
