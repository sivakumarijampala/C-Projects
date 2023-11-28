using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPractice
{
    class Employee
    {
        public void display()
        {
            Console.WriteLine("employee method");
        }
    }
    class Project1 : Employee
    {
        public void show()
        {
            Console.WriteLine("project 1 method");
        }
    }
    class Project2 : Employee
    {
        public void print()
        {
            Console.WriteLine("project1 method");
        }
    }
    class HybridInheritance
    {
        static void Main()
        {
        Project2 project2 = new Project2();
            project2.display();
            project2.print();
            Project1 project1 = new Project1();
            project1.display();
            project1.show();
    }
}
}
