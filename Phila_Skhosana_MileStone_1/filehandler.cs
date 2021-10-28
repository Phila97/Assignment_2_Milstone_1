using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Phila_Skhosana_MileStone_1
{
    public class filehandler
    {
        string path;
        FileStream fs;
        StreamWriter writer;
        StreamReader reader;

        public filehandler(string pathName = "Specific.txt") 
        {
            try
            {
                if (pathName == "Sensitive.txt")
                {
                    MessageBox.Show("No Text will be specified");

                }
                this.path = pathName;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        
        }

        public List<string> ReadData() 
        {
            List<string> rawData = new List<string>();
            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(fs);
                while (!reader.EndOfStream)
                {
                    rawData.Add(reader.ReadLine());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally 
            {
                 reader.Close();
                 fs.Close();
            }
             return rawData;
        
        }

        public void writetofile(string writeToFile) 
        {
            try
            {
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                writer = new StreamWriter(fs);
                writer.WriteLine(writeToFile);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            { 
                 writer.Close();
                 fs.Close();
            }
           
        }

    }
}
