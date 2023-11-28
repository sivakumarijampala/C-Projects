using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


//foreground thread -->a threda which keeps on running even main thread exists
//background thread---->if main threda exists the remaining threads also exists
////-->by setting--->IsBackground = true--->by default IsBackground = false
namespace ExceptionHandling
{
    internal class TypesOfThreads
    {

        public static void Main()
        {
            Console.WriteLine("start main thread");
            Thread t = new Thread(MyThread);
            
            //this method is used to start the thread
            t.Start();
            t.IsBackground = true;
           
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                //Thread.Sleep(2000);//used to stop the threda for 2 seconds
            }
            Console.WriteLine("main thread exist");
        }

        public static void MyThread()
        {
            for(int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("thread exit");
        }
    }
}
