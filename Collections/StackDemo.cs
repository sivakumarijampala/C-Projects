using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class StackDemo
    {
        public static void Main()
        {

            //push method--used to add element in stack
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(30);
            stack.Push(20);
            foreach(int i in stack)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("***pop method***");
           
            //pop method-->is used to remove top element
            Console.WriteLine(stack.Pop());
            Console.WriteLine("elements after pop");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }

            //peek method-->used to print top most element
            Console.WriteLine("peek method");
            Console.WriteLine(stack.Peek());

            //clear method
            stack.Clear();
            Console.WriteLine("elements after clear");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }

           

        }
    }
}
