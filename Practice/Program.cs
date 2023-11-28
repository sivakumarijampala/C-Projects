using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        int i;
        Program(int x)
        {
            i =x;
        }
        Program(Program p1)
        {
            i = p1.i;
        }
       
        
       
        static void Main(string[] args)
        {
            Program p = new Program(10);
            Program p1 = new Program(p);
            Console.WriteLine("HELLO WORLD");
            Console.WriteLine(p.i);
            Console.WriteLine( p1.i);


        }
    }
}
