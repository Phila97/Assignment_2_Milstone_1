using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phila_Skhosana_MileStone_1
{
    public partial class Student_DEtails : Form
    {
        public Student_DEtails()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Collect the input data
                string name = nametxt.Text;
                string surname = surnametxt.Text;
                string gender = cbGender.Text;
                string phone = phonetxt.Text;
                string address = addresstxt.Text;
                string modules_codes = cbModuleCodes.Text;

                //Create data handler
                DataHandler dh = new DataHandler();

                dh.Insert(name, surname, gender, phone, address, modules_codes);
                MessageBox.Show("Successfully inserted data");
            }
            catch (Exception exc)
            {
                MessageBox.Show($"An error occured");
                Console.WriteLine($"Error: {exc}");
                throw;
            }
            

            
        }
    }
}
