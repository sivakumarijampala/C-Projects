using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
     class PalindromeNumber
    {
        static void Main()
        {
            Console.WriteLine( "enter a number");
           
            int number= int.Parse(Console.ReadLine());
            int temp = number;int sum = 0;
            while(number > 0)
            {
                int rem = number % 10;
                 sum = (sum * 10) + rem;
                number = number / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("the number is palindrome");
            }
            else
            {
                Console.WriteLine("the number is not paalindrome");
            }

        }
    }
}
