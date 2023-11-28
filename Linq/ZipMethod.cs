using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class ZipMethod
    {
        public static void Main()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            string[] strings = { "siva", "kumari", "malliswari", "ramu", "Lakshman","mallika" };
            var result=numbers.Zip(strings, (first, second) => first + "---->" + second);
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }


            Console.WriteLine("**********");

            int[] numbersSequence = { 10, 20, 30, 40, 50 };
            string[] wordsSequence = { "Ten", "Twenty", "Thirty", "Fourty" };
            var resultSequence = numbersSequence.Zip(wordsSequence, (first, second) => first + " - " + second);
            foreach (var item in resultSequence)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
    
}
