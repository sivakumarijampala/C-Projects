using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


//xml and binary serialization
namespace WindowsFormsApp2
{
    [Serializable]
    public class Employee
    {
        private string Name;
        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
       
        private string Phone;

        public string phone
        {
            get
            {
                return Phone;
            }
            set
            {
                Phone = value;
            }
        }

        private DateTime DOB;

        public DateTime dob
        {
            get
            {
                return DOB;
            }
            set
            {
                DOB = value;
            }
        }
        
        private string Department;

        public string department
        {
            get
            {
                return Department;
            }
            set
            {
                Department = value;
            }
        }
       
        private int Salary;

        public int salary
        {
            get
            {
                return Salary;
            }
            set
            {
                Salary = value;
            }
        }

        [XmlIgnore]
        public string additionalInfo;
    }
}
