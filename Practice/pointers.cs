using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    unsafe class pointers
    {
        static void Main()
        {
            int a = 10;
            int* p=&a;
            Console.WriteLine("a value is:"  + a);
            Console.WriteLine("address value of p is" + *p);
            *p = 40;
            Console.WriteLine("value:",+a);
            Console.WriteLine("value address:" + *p);
        }
    }
}
