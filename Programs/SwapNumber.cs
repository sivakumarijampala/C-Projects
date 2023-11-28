using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
     class SwapNumber
    {
        static void Main()
        {
            Console.WriteLine( "enter number1");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number2");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("the numbers before swapping");
            Console.WriteLine(number1+" "+number2);
            int temp;
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("the numbers after swapping");
            Console.WriteLine(number1 + " " + number2);
        }
    }
}
