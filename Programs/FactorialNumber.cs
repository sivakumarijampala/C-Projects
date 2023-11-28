using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class FactorialNumber
    {
        static void Main()
        {
            int fact = 1;
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            for (int i = number; i >= 1; i--)
            {
                fact = fact * i;
            }

            Console.WriteLine("The factorial of the given number is: " + fact);
        }

    }
}
