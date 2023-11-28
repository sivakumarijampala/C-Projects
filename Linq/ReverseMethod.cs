using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class ReverseMethod
    {
        public static void Main()
        {
            int[] num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            //method syntax
            Console.WriteLine("**********");
            List<int> numbers=num.Reverse().ToList();
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }


            //query syntax
            Console.WriteLine("**********");
            IEnumerable<int> n1 =(from n in num select n).Reverse();
            foreach (int i in n1)
            {
                Console.WriteLine(i);
            }

        }
    }
}
