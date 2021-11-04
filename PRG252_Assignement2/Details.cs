using System;
using System.Collections.Generic;
using System.Text;

namespace Phila_Skhosana_MileStone_1
{
    class Details
    {
        private int studentNumber;

        public int StudentNumber
        {
            get { return studentNumber; }
            set { studentNumber = value; }
        }


        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        private string dob;

        public string DOB
        {
            get { return dob; }
            set { dob = value; }
        }

        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        private int phone;

        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private string  address;

        public string  Address
        {
            get { return address; }
            set { address = value; }
        }

        private string moduleCode;

        public string ModuleCode
        {
            get { return moduleCode; }
            set { moduleCode = value; }
        }

        private string moduleName;

        public string ModuleName
        {
            get { return moduleName; }
            set { moduleName = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string link;

        public string Link
        {
            get { return link; }
            set { link = value; }
        }


        public Details(int studentNumber, string name,string surname, string dob, string gender, int phone, string address,string moduleCode, string moduleName, string description, string link)
        {
            this.studentNumber = studentNumber;
            this.surname = surname;
            this.name = name;
            this.dob = dob;
            this.gender = gender;
            this.phone = phone;
            this.address = address;
            this.moduleCode = moduleCode;
            this.moduleName =moduleName;
            this.description = description;
            this.link = link;
        }

        public override string ToString()
        {
            return studentNumber + name + surname + dob + gender + phone + address + moduleCode + moduleName+ description + link ;

        }
    }
}
