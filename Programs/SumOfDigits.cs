using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
     class SumOfDigits
    {
        static void Main()
        {
            Console.WriteLine( "enter number");
            int number=int.Parse(Console.ReadLine());
            int sum = 0;
            while (number > 0)
            {
                int rem = number % 10;
                sum = sum + rem;
                number = number / 10;
            }
            Console.WriteLine( "the sum of digits:"+sum);
        }
    }
}
