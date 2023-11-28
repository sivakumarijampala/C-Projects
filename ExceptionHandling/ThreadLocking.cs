using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//locking the thread
namespace ExceptionHandling
{
    //multiple threads are trying to access the same resource
    ///at that time we use lock to use the only one thread to be used that resource
    public class ThreadLocking
    {
        public void Display()
        {
            lock (this)
            {
                Console.Write("c sharp is");
                Thread.Sleep(5000);
                Console.WriteLine("object oriented");
            }

        }
        public static void Main()
        {
            ThreadLocking t1 = new ThreadLocking();
            Thread thread1 = new Thread(t1.Display);
            Thread thread2 = new Thread(t1.Display);
            Thread thread3 = new Thread(t1.Display);
            thread1.Start();
            thread2.Start();
            thread3.Start();

        }

    }
}
