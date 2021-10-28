using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Phila_Skhosana_MileStone_1
{
    public class Login
    {
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public Login(string password, string username)
        {
            this.password = password;
            this.username = username;
        }

        public Login()
        {

        }

        public List<Login> getUser()
        {
            List<Login> u = new List<Login>();
            filehandler fh = new filehandler("login.txt");

            foreach (string item in fh.ReadData())
            {
                string[] line = item.Split(',');
                u.Add(new Login(line[0],line[1]));
            }
            return u;
        
        }

        public void writeruser(string uSername, string pAssword) 
        {
            string writer = string.Format("{0},{1}", uSername, pAssword);
            filehandler fh = new filehandler("login.txt");
            fh.writetofile(writer);
        }

    }
}
