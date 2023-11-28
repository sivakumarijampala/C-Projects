using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class RangeMethod
    {
        public static void Main()
        {
            IEnumerable<int> numberSequence = Enumerable.Range(1, 10);
            foreach (int number in numberSequence)
            {
                Console.WriteLine($"{number} ");
            }
            Console.WriteLine("**********");
            IEnumerable<int> evenNumbers = Enumerable.Range(20, 50).Where(i => i % 2 == 0).ToList();
            foreach(int number in evenNumbers)
            {
                Console.WriteLine($"{number}");
            }

            Console.WriteLine("************");
            IEnumerable<int> num = Enumerable.Range(1, 5).Select(x => x * x);
            foreach(int number in num) 
            {
                Console.WriteLine($"{number}");
            }
                    
        }
    }
}
