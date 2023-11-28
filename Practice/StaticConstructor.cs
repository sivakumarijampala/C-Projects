using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    //static constructor
    internal class StaticConstructor
    {
        static int a;
        static StaticConstructor()
        {
            a = 90;
        }
        static void Main(string[] args)
        {
            Console.WriteLine( a);
        }
    }
}
