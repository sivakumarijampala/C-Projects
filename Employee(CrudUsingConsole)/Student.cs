using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Student
    {
       // public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }


        public Student(string name,string gender,DateTime dateOfbirth)
        {
            //this.Id = id;
            this.Name = name;
            this.Gender = gender;
            this.DateOfBirth = dateOfbirth;
        }
    }
}
