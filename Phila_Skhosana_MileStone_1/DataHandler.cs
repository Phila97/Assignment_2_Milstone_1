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
                string sql = $"INSERT INTO tblStudents (FirstName, LastName, Gender, Phone, Address, ModulesCodes) VALUES(@first_name, @last_name, @gender, @phone, @address, @module_code)";
                using (conn)
                {
                    conn.Open();
                    using(SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@first_name", first_name);
                        cmd.Parameters.AddWithValue("@last_name", last_name);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@module_code", module_code);
                        cmd.ExecuteNonQuery();
                    }
                }
                
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
                string sql = $"DELETE FROM tblStudents WHERE StudentNumber = @search";
                using (conn)
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@search", search);
                        cmd.ExecuteNonQuery();
                    }
                }
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
                /*
                //Open connection
                conn.Open();
                Console.WriteLine("Connection open");

                //Update query
                SqlDataAdapter cmd = new SqlDataAdapter();
                cmd.UpdateCommand = new SqlCommand($"UPDATE tblStudents SET FirstName = {first_name}, LastName = {last_name}, Gender = {gender}, Phone = {phone}, Address = {address}, ModulesCodes = {module_code} WHERE StudentNumber = {search}");
                cmd.UpdateCommand.Connection = conn;
                */
                string sql = $"UPDATE tblStudents SET FirstName = @first_name, LastName = @last_name, Gender = @gender, Phone = @phone, Address = @address, ModulesCodes = @module_code WHERE StudentNumber = @search";
                using (conn)
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        //Add Parameters
                        cmd.Parameters.AddWithValue("@first_name", first_name);
                        cmd.Parameters.AddWithValue("@last_name", last_name);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@module_code", module_code);
                        cmd.Parameters.AddWithValue("@search", search);
                        //Execute
                        cmd.ExecuteNonQuery();
                    }
                }

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
