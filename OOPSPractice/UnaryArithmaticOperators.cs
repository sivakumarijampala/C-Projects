using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPractice
{
    class UnaryArithmaticOperators
    {
        static void Main()
        {

            int a = 20;
            //post increment
            int result=a++;
            Console.WriteLine("the a value is{0},the result is{1}",a,result);

            int a1= 20;
            //pre increment
            int result1 = ++a1;
            Console.WriteLine("the a value is{0},the result is{1}", a1, result1);


            int a2 = 20;
            //post decrement
            int result2 =a2--;
            Console.WriteLine("the a value is{0},the result is{1}", a2, result2);

            int a3 = 20;
            //pre decrement
            int result3 = --a1;
            Console.WriteLine("the a value is{0},the result is{1}", a3, result3);
        }
    }
}
