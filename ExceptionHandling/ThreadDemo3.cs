using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ExceptionHandling
{
    //join method--->is used to wait the main thread untill all threads executing the task
    public class ThreadDemo3
    {
        public static void Test1()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("thread1 exiting");

        }
        public static void Test2()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("thread2 exiting");

        }
        public static void Test3()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("thread 3 exiting");

        }
        static void Main()
        {
            Console.WriteLine("main thread started");
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start();
            t2.Start();
            t3.Start();
            t1.Join(3000);
            t2.Join();
            t3.Join();
            Console.WriteLine("main thread ended");
        }
    }
}
