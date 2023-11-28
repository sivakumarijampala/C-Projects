using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Student5
    {
        static int id;
        static string name;
        //static constructor is used to initialize static variables
        //static constructor is must be parameter less
        static Student5()
        {
            Console.WriteLine(  "static constructor");
            id = 6;
            name = "lakshman";
        }
        //it calls first default constructor
        Student5()
        {
            Console.WriteLine( "default constructor");
        }
        static void Main()
        {
            Student5 student5 = new Student5();
            Console.WriteLine(id);
            Console.WriteLine(name??"null");
        }
    }
}
