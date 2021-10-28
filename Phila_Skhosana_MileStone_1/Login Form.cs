using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Phila_Skhosana_MileStone_1
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
        }

        private void Login_Form_Load_1(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            Login_Form lf = new Login_Form();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login logins = new Login(passwordTxt.Text, userNametxt.Text);
            bool logged = false;
            string loggedName = string.Empty;
            foreach (Login item in logins.getUser())
            {
                if (userNametxt.Text == item.Username && passwordTxt.Text == item.Password)
                {
                    logged = true;
                    loggedName = item.Username;
                }
            }
            if (logged)
            {
                Student_DEtails sd = new Student_DEtails();
                sd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Credentials");
            }

            //string filename = "login.txt";

            //FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            //StreamReader reader = new StreamReader(fs);
            //string line;

            //while ((line = reader.ReadLine()) != null)
            //{
            //    string[] values = line.Split(',');
            //    string username = (values[0]);
            //    string passwoed = (values[1]);

            //    line = reader.ReadLine();
            //    if (userNametxt.Text == username && passwordTxt.Text == passwoed)
            //    {
            //        Student_DEtails sd = new Student_DEtails();
            //        sd.ShowDialog();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Username or Password is incorrect");
            //    }
            //}

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
