using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
     class Student4
    {
        //static constructor
        //no need to call constructor
        //even main method present it will execute first static constructor 
        //then it will call main method
       static Student4()
        {
            Console.WriteLine(  "static constructor called");
        }
        static void Main()
        {
            Console.WriteLine("welcome to .net tutorials");

        }
    }
}
