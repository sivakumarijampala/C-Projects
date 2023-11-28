using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
     class Student6
    {
        static int id;
        static string name;
        Student6()
        {
            Console.WriteLine("default constructor");
        }

       /* static Student6()
        {
            Console.WriteLine("static constructor");
        }*/

        static Student6()
        {
            Console.WriteLine( "initializing properties");
            id = 40;
            name = "priya";
        }
        static void Main()
        {
            Student6 student6 = new Student6();
            Console.WriteLine(id);
            Console.WriteLine(name);
        }
    }
}
