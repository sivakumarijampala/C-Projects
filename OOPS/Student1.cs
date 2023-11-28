using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
     class Student1
    {
        int id;
        string name;

        //default constructor defined by programmer
        Student1()
        {
            Console.WriteLine("STUDENT1 CONSTRUCTOR");
            id = 12;
            name = "sivakumari";

        }
        static void Main()
        {
            //creating student1 object
            Student1 student = new Student1();
            Console.WriteLine("student id:"+student.id);
            Console.WriteLine("student id:" + student.name);

        }
    }
}
