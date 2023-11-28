using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPractice
{
    class ConstandReadonly
    {
        //we ca not chane the value through out the application
        public const double pie = 3.14;

        //we can assign value at once through constructor
        public readonly int num;

        public ConstandReadonly(int num1)
        {
            num = num1;
        }

        public static void Main()
        {
            ConstandReadonly c = new ConstandReadonly(100);
            Console.WriteLine(c.num);
            


            ConstandReadonly c1 = new ConstandReadonly(500);
            //c1.num=200---->we can not initialize the readonly once we assigned value to the readonly variablethrough constructor
            Console.WriteLine(c1.num);
           


        }
    }
}
