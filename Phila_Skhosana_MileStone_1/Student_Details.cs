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
        public void ShowInGrid()
        {
            DataHandler dh = new DataHandler();
            dataGridView1.DataSource = dh.ShowData();
            dataGridView1.DataMember = "tblStudents";
        }
        public Student_DEtails()
        {
            InitializeComponent();
            ShowInGrid();
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

                //Insert the data using the datahandler insert procedure
                dh.Insert(name, surname, gender, phone, address, modules_codes);
                //Refress the data grid view
                //dataGridView1.DataSource = dh.ShowData();
                MessageBox.Show("Successfully inserted data");
                ShowInGrid();

            }
            catch (Exception exc)
            {
                MessageBox.Show($"An error occured");
                Console.WriteLine($"Error: {exc}");
                throw;
            }
            

            
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentNumberA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
