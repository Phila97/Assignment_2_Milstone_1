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
    public partial class Register : Form
    {
        
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.writeruser(regUsernametxt.Text, regPasswordtxt.Text);
            MessageBox.Show("You have been Successfully added");

            Login_Form lf = new Login_Form();
            lf.Show();
            this.Hide();
        }
         
        private void regUsernametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
