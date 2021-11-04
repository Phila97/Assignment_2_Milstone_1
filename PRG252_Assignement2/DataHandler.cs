using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Phila_Skhosana_MileStone_1
{
    class DataHandler
    {
        public SqlConnection conn = new SqlConnection(@"Data Source = (local); Initial Catalog=BelgiumCampus_Students; Integrated Security=SSPI");
        public DataHandler()
        {
            
        }

        public DataSet ShowData()
        {
            string sql = "SELECT * FROM tblStudents";
            SqlDataAdapter data_adapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            data_adapter.Fill(ds, "tblStudents");
            conn.Close();
            return ds;
        }

        //Search Method
        public DataSet Search(string search)
        {
            try
            {
                string sql = $"SELECT * FROM tblStudents WHERE StudentNumber={search}";
                SqlDataAdapter data_adapter = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                conn.Open();
                data_adapter.Fill(ds, "tblStudents");
                conn.Close();
                return ds;
            }
            catch (Exception exc)
            {
                Console.WriteLine($"Error: {exc}");
                throw;
            }
            
        }

        //Insert Method
        public void Insert(string first_name, string last_name, string gender, string phone, string address, string module_code)
        {
            try
            {
                //Open the connection
                conn.Open();
                Console.WriteLine("Connection Open");

                //Query the DB To insert
                SqlDataAdapter cmd = new SqlDataAdapter();
                cmd.InsertCommand = new SqlCommand($"INSERT INTO tblStudents (FirstName, LastName, Gender, Phone, Address, Address, ModulesCodes) VALUES({first_name}, {last_name}, {gender}, {phone}, {address}, {module_code})");
                cmd.InsertCommand.Connection = conn;

                Console.WriteLine("Student Successfully added");
                conn.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine($"Error: {exc}");
                throw;
            }
        }

        //Delete Method
        public void Delete(string search)
        {
            try
            {
                //Open the connection
                conn.Open();
                Console.WriteLine("Connection open");

                //Query to delete
                SqlDataAdapter cmd = new SqlDataAdapter();
                cmd.DeleteCommand = new SqlCommand($"DELETE FROM tblStudents WHERE StudentNumber = {search}");
                cmd.DeleteCommand.Connection = conn;

                Console.WriteLine("Item Deleted");
                //Close connection
                conn.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine($"Error{exc}");
                throw;
            }
            
        }

        //Update function
        public void Update(string search, string first_name, string last_name, string gender, string phone, string address, string module_code)
        {
            try
            {
                //Open connection
                conn.Open();
                Console.WriteLine("Connection open");

                //Update query
                SqlDataAdapter cmd = new SqlDataAdapter();
                cmd.UpdateCommand = new SqlCommand($"UPDATE tblStudents SET FirstName = {first_name}, LastName = {last_name}, Gender = {gender}, Phone = {phone}, Address = {address}, ModulesCodes = {module_code} WHERE StudentNumber = {search}");
                cmd.UpdateCommand.Connection = conn;

                Console.Write("Update was successfull");
            }
            catch (Exception exc)
            {
                Console.Write($"Err {exc}");
                throw;
            }
        }
    }
}
