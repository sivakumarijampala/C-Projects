using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class IEnumarableUsingObjects
    {
        public static void Main()
        {
            //creating list of students
            List<Student> students = new List<Student>()
            {
                new Student(){Id=1,Name="siva",Gender="female" },
                 new Student(){Id=2,Name="sivakumari",Gender="female" },
                  new Student(){Id=3,Name="malliswari",Gender="female" },
                   new Student(){Id=4,Name="ramu",Gender="male" },
                    new Student(){Id=5,Name="lakshman",Gender="male" },
            };


            //fetch the details who is female
            //query syntax
            Console.WriteLine("query syntax by using IEnumerable byusing objects");
            IEnumerable<Student> stu = from student in students
                                       where student.Gender == "female"
                                       select student;

           //iterating
            foreach(var s in stu)
            {
                Console.WriteLine($"Id={s.Id},Name={s.Name},Gender={s.Gender}");
            }

            //method syntax by using IEnumarable
            Console.WriteLine("method syntax by using iEnumarable by using object");
            IEnumerable<Student> methodsyntaxIEn=stu.Where(e => e.Gender == "female");
            foreach (var s in methodsyntaxIEn)
            {
                Console.WriteLine($"Id={s.Id},Name={s.Name},Gender={s.Gender}");
            }

            //iqueryable 
            Console.WriteLine("iqueryable interface by using method syntax");
            IQueryable <Student> iqueryable=students.AsQueryable().Where(s => s.Gender == "female");
            foreach (Student s in iqueryable)
            {
                Console.WriteLine($"Id={s.Id},Name={s.Name},Gender={s.Gender}");
            }

            //fetching details who are males
            //method syntax-->by using IQueryable--->converting toarray
            Console.WriteLine("iqueryable convert to array");
            Student[] stud=students.AsQueryable().Where(s => s.Gender == "male").ToArray() ;
            foreach(Student s in stud)
            {
                Console.WriteLine($"Id={s.Id},Name={s.Name},Gender={s.Gender}");
            }
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        
    }
}
