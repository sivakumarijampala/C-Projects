using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPractice
{
     class RelationalOperators
    {
        static void Main()
        {
            int number1= 30;
            int number2 = 20;

            Boolean result = (number1 == number2);
            Console.WriteLine("result is"+result);

            Boolean result1 = (number1 > number2);
            Console.WriteLine("result is" + result1);

            Boolean result2 = (number1 < number2);
            Console.WriteLine("result is" + result2);

            Boolean result3 = (number1 >= number2);
            Console.WriteLine("result is" + result3);

            Boolean result4 = (number1 <= number2);
            Console.WriteLine("result is" + result4);

            Boolean result5 = (number1 != number2);
            Console.WriteLine("result is" + result5);

        }
    }
}
