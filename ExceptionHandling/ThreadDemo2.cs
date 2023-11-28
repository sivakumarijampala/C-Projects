using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ExceptionHandling
{
    //parameterized thread start deligate
    public class ThreadDemo2
    {
       
        public static void Test1(object max)
        {
           int num= Convert.ToInt32(max);
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine(i);
            }  

        }

        static void Main()
        {

            ParameterizedThreadStart pts = new ParameterizedThreadStart(Test1);
            Thread t2 = new Thread(pts);
            
            Thread t = new Thread(Test1);
            t.Start(15);

        }
    }
}
