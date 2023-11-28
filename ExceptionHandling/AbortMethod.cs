using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


//abort method example
namespace ExceptionHandling
{
    internal class AbortMethod
    {
        public static void Main()
        {
            Thread thr = Thread.CurrentThread;

            //checks the current thread is working or not
            Console.WriteLine(thr.IsAlive);

            //checking the state of the current thread
            Console.WriteLine(thr.ThreadState);



            Console.WriteLine("the backgroung thread is bydefault:");
            Console.WriteLine("the backgroung thread is bydefault:");
            Console.WriteLine(thr.IsBackground);


            Example ex = new Example();
            Thread t = new Thread(ex.display);
            
            Console.WriteLine("checks the thread state before start the thread");
            Console.WriteLine(t.IsAlive);
           
            //is used to start the thread
            t.Start();
           
            Console.WriteLine("checks the thread state after start the thread");
            Console.WriteLine(t.IsAlive);
            
            //Console.WriteLine("abort method called");
            //t.Abort();
            //is used to terminate the exicution of the thread

        }
    }

    public class Example
    {
        public void display()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
