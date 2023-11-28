using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPractice
{
    class Student
    {
        public virtual void display()
        {
            Console.WriteLine("student....");
        }
    }
    class Project : Student
    {
        public  override  void display()
        {
            Console.WriteLine("project....");
        }
    }
     class MethodOverriding
    {
        public static void Main()
        {
            Student s = new Project();
            s.display();
            Console.WriteLine( "******");
            Student s1 = new Student();
            s1.display();
            Console.WriteLine( "***********");
            Project project = new Project();
            project.display();

        }
    }
}
