

















using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ExceptionHandling
{
    public class Multithreading
    {
        static void Test1()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("test1:"+i);
            }
            Console.WriteLine("thread1 exiting");
        }


        static void Test2()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("test2:" + i);
                if (i == 5)
                {
                    Console.WriteLine("thread is going to sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("thread is awakes");
                }
            }
            Console.WriteLine("thread2 exiting");
        }

        static void Test3()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("test3:" + i);
            }
            Console.WriteLine("thread3 exiting");
        }

        static void Main()
        {
            Thread T1 = new Thread(Test1);
            Thread T2 = new Thread(Test2); 
            Thread T3=new Thread(Test3);
            T1.Start();
            T2.Start();
            T3.Start();
            Console.WriteLine( "thread main exiting");


        }
    }
}
