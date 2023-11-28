using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ExceptionHandling
{
    //thread start deligate
    public class ThreadDemo
    {
        public static void Test()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main()
        {
            //threadstart is a deligate that call the method

            //we are explicity doing this
           
            ThreadStart obj = new ThreadStart(Test);
            //ThreadStart obj = Test;
            //ThreadStart obj=deligate(){Test();};
            //ThreadStart obj=()=>Test();
           
            Thread T2= new Thread(obj);
            T2.Start();


            //whenever we are passing the method as directly to the thread class 
            //it will internally creates deligate instance and call the method
            Thread T1 = new Thread(Test);
            T1.Start();

            
        }
            
    }
}
