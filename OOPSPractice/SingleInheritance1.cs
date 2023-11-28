using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPractice
{
    class Parent
    {
        public void display()
        {
            Console.WriteLine( "parent method");
        }
    }
    class Child : Parent
    {
        public void show()
        {
            Console.WriteLine("child method");
        }
    }




     class SingleInheritance1
    {
        public static void Main()
        {
            Child child = new Child();
            child.display();
            child.show();
        }
    }
}
