using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPractice
{
     class MethodOverloading
    {
        public void add(int num1,int num2)
        {
            Console.WriteLine("addition of two numbers is:"+(num1+num2));
        }
        public void add(int num1,int num2,int num3)
        {
            Console.WriteLine("addition of three numbers is:" + (num1 + num2+num3));
        }
        public void add(int num1, int num2, int num3,int num4)
        {
            Console.WriteLine("addition of four numbers is:" + (num1 + num2 + num3+num4));
        }
        static void Main()
        {
            MethodOverloading overloading = new MethodOverloading();
            overloading.add(1, 2);
            overloading.add(1, 2, 3);
            overloading.add(1, 2, 3, 4);
        }
    }
}
