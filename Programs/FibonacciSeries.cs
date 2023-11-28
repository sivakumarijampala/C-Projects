using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class FibonacciSeries
    {
        static void Main()
        {
            int f1 = 0;int f2 = 1;int f3;
            Console.WriteLine("enter number");
            int number=int.Parse(Console.ReadLine());
            Console.Write(f1 + " " + f2+" ");

            for (int i = 2; i < number; i++)
            {
                f3 = f1 + f2;
                Console.Write(f3 + " ");
                f1 = f2;
                f2 = f3;
            }
        }
    }
}
