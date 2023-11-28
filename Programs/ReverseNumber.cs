using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
     class ReverseNumber
    {
        static void Main()
        {
            Console.WriteLine( "enter a number");
            int number = int.Parse(Console.ReadLine());
            int reverse = 0;
            while (number > 0)
            {
                int rem = number % 10;
                reverse = reverse * 10 + rem;
                number = number / 10;
            }
            Console.WriteLine("the reverse of given number is:"+reverse);
        }
    }
}
