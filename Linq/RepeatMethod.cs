using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class RepeatMethod
    {
        public static void Main()
        {
            IEnumerable<string> repeatString = Enumerable.Repeat("welcome", 5);
            foreach (string repeat in repeatString)
            {
                Console.WriteLine(repeat);
            }

            Console.WriteLine("**********");
            IEnumerable<string> repeatstring = Enumerable.Repeat("welcome", -5);
            foreach(string repeat in repeatstring)
            {
                Console.WriteLine(repeat);   //argument out of rage exception
            }

            Console.WriteLine("***********");


        }
    }
}
