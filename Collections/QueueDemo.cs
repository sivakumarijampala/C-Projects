using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class QueueDemo
    {
        public static void Main()
        {
            Queue<string> queue = new Queue<string>();

            //enqueue--->used to add the element in the queue
            queue.Enqueue("siva");
            queue.Enqueue("kumari");
            queue.Enqueue("malli");
            queue.Enqueue("bhavana");
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***dequeue****");
            //dequeue-->is used to delete the element in the queue
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }


            //peek method
            Console.WriteLine(queue.Peek());

            //clear method
            Console.WriteLine("clear method");
            queue.Clear();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }


        }
    }
}
