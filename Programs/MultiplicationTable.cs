using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class MultiplicationTable
    {
        static void Main()
        {
            Console.WriteLine( "enter number");
            int number=int.Parse(Console.ReadLine());
            for(int i = 1; i <=10; i++)
            {
                Console.WriteLine(number + " *" + i + "=" + i * number);
            }
            
        }
    }
}
