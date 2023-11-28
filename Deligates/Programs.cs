using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//this program demonstrate normal way to call method
namespace Deligates
{
    class Programs
    {
        //non static method
        public void AddNumbers(int a,int b)
        {
        Console.WriteLine("addition is:"+(a+b));
        }
        //static mehod
        public static String SayHello(string message)
        {
        return "hello"+" " + message;
        }

    
        static void Main(string[] args)
        {
            //instantiating program class
            Programs p = new Programs();

            //calling method
            p.AddNumbers(100, 3000);
            string result = Programs.SayHello("hi");
            Console.WriteLine(result);

        }
    }
}
