using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//anonymus methods in deligates
namespace Deligates
{
    public delegate string GreetDeligate(string messsage);
    class AnonymusMethodsInDeligates
    {

        /*public static string Greetings(string m)
        {
            return "hello" + m;
        }*/
        static void Main()
        {

            //instead og calling like this we can simplify this
            //GreetDeligate greetDeligate = new GreetDeligate(Greetings);
            //string result = greetDeligate("sivakumari");
            //Console.WriteLine(result);

            GreetDeligate greet = delegate (string name)
            {
                return "hello " + name;
            };
            string result = greet("sivakumari");
            Console.WriteLine(result);


        }
    }
}
