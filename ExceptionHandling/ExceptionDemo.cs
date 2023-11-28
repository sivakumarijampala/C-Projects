using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class ExceptionDemo
    {
        static void Main()
        {
            Console.WriteLine("enter first number");
            int x=int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int y = int.Parse(Console.ReadLine());
            if (y % 2 > 0)
            {
                //this is predefined class(ApplicationException)
                // throw new ApplicationException("error in the program");

                //defining own exception
                //throw new DivideByOddNo("atempt to divide byzero");

                throw new DivideByOddNo();

            }
            int z = x / y;
            Console.WriteLine("result is:"+z);
            Console.WriteLine(  "end of program");

        }
    }
}
