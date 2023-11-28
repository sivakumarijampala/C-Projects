using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
     class Student3
    {
        int id;
        string name;
        Student3()
        {
            Console.WriteLine("Constructor called");
        }

        Student3(int id1,string name1)
        {
            Console.WriteLine( "parameterized constructor");
            id = id1;
            name = name1;
        }
        static void Main()
        {
            Student3 student3 = new Student3(13,"ramu");
            Console.WriteLine("student id:"+student3.id);
            Console.WriteLine("student name:"+student3.name);


        }

        //if default constructor and parameterized constructor both are there 
        //it call parameterized constructor not default constructor
    }
}
