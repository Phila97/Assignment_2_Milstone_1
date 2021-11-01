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
            try
            {
                //Search db
                string search = txtSearch.Text;
                int search_int = Int16.Parse(search);
                //Create datahandler
                DataHandler dh = new DataHandler();

                //Populate the text boxes
                if (dataGridView1.SelectedRows.Count > 0)//Make sur that atleast 1 row is selected
                {
                    //Store the values in variables
                    string name = txtNameA.Text;
                    string surname = txtSurameA.Text;
                    string gender = cbGenderA.Text;
                    string phone = txtPhoneA.Text;
                    string address = txtAddressA.Text;
                    string modules_codes = cbModuleCodesA.Text;

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("There was an error, make sure that you entered only numbers");
                Console.WriteLine($"Error:{exc}");
                throw;
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentNumberA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //Collect Data
                string search = txtSearch.Text;
                int search_int = Int16.Parse(search);
                //Create datahandler
                DataHandler dh = new DataHandler();
                //Update the gridview
                dataGridView1.DataSource = dh.Search(search);
                dataGridView1.DataMember = "tblStudents";
                dataGridView1.Rows[0].Selected = true;

                //Populate the text boxes
                if (dataGridView1.SelectedRows.Count > 0)//Make sur that atleast 1 row is selected
                {
                    //Store the values in variables
                    string name = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                    string surname = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                    string gender = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                    string phone = dataGridView1.SelectedRows[0].Cells[4].Value + string.Empty;
                    string address = dataGridView1.SelectedRows[0].Cells[5].Value + string.Empty;
                    string modules_codes = dataGridView1.SelectedRows[0].Cells[6].Value + string.Empty;
                    //Populate the fields
                    txtNameA.Text = name;
                    txtSurameA.Text = surname;
                    cbGenderA.Text = gender;
                    txtPhoneA.Text = phone;
                    txtAddressA.Text = address;
                    cbModuleCodesA.Text = modules_codes;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("There was an error, make sure that you entered only numbers");
                Console.WriteLine($"Error:{exc}");
                throw;
            }
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            //Remove everything from update section
            txtNameA.Text = "";
            txtSurameA.Text = "";
            cbGenderA.Text = "";
            txtPhoneA.Text = "";
            txtAddressA.Text = "";
            cbModuleCodesA.Text = "";

            //Show all the data
            ShowInGrid();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Search db
                string search = txtSearch.Text;
                int search_int = Int16.Parse(search);
                //Create datahandler
                DataHandler dh = new DataHandler();

                //Populate the text boxes
                if (dataGridView1.SelectedRows.Count > 0)//Make sur that atleast 1 row is selected
                {
                    dh.Delete(search);
                    MessageBox.Show("Successfully deleted student account");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("There was an error, make sure that you entered only numbers");
                Console.WriteLine($"Error:{exc}");
                throw;
            }
        }
    }
}
