using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
     class ArmstrongNumber
    {
        static void Main()
        {
            Console.WriteLine( "eneter number");
            int number=int.Parse(Console.ReadLine());
            int temp = number;int sum = 0;
            while (number > 0)
            {
                int rem = number % 10;
                sum = sum + (rem * rem * rem);
                number = number / 10;
                
            }
            if (temp == sum)
            {
                Console.WriteLine("the number is armstrong ");

            }
            else
            {
                Console.WriteLine("the number is not armstrong");
            }

        }
    }
}
