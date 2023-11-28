using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//program for deligates(calling method by using deligates)
namespace Deligates
{
    //defining deligate(step1)
    public delegate void AddDeligate(int num1,int num2);
    public delegate string SayDeligate(string name);
    public class DeligatesExample1
    {

        public void AddNumbers(int x,int y)
        {
            Console.WriteLine("addition is:"+(x+y));
        }
        public static string SayHello(string message)
        {
            return message;
        }


        static void Main()
        {

            //creating object for class
           
            DeligatesExample1 d = new DeligatesExample1();

            //instantiating deligate
            //we have to pass method as referance to the delgate
            //step4
            AddDeligate ad = new AddDeligate(d.AddNumbers);
            SayDeligate sd = new SayDeligate(DeligatesExample1.SayHello);

            //calling deligate by passing required parameter values(step3)
            //internally the method which is referanced through the deligate is called

            /*ad(100, 200);
            string result = sd("welcome to delogates...");
            Console.WriteLine(result);*/

            //or we can call like this also
            ad.Invoke(100, 200);
            string res = sd.Invoke("welcome to .net deligates");
            Console.WriteLine(res);



        }
    }
}
