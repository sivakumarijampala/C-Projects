using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
     class PerfectNumber
    {
        static void Main()
        {
            Console.WriteLine("enter a number");
            int number=int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }

            }
            if (number == sum)
            {
                Console.WriteLine("the number is perfect");
            }
            else
            {
                Console.WriteLine("the number is not perfect");
            }
        }
    }
}
