using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("enter number");
            int number =int.Parse (Console.ReadLine());
            for(int i = 1; i <=number; i++)
            {
                if (number % i == 0)
                {
                    count++; 
                }
            }
            if (count == 2)
            {
                Console.WriteLine("the number is prime");
            }
            else
            {
                Console.WriteLine("the number is not prime");
            }
        }
    }
}
