using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
     class Test
    {
       public int id;
       public  string name;
        public void display()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
        }
    }

    class Student8
    {
        static void Main()
        {
            Test t= new Test();
            t.id = 123;
            t.name = "kalyani";
            t.display();


        }
    }
}
