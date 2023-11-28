using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{

    class Test4
    {
       public  int id;
       public string name;
        //this is a keyword that refers to the current instance of the class
        public Test4(int id,string name)
        {
            this.id = id;
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine(id);
            Console.WriteLine( name);
        }
    }
    class Student11
    {
        static void Main()
        {
            Test4 t = new Test4(112,"mallika");
            Test4 t1 = new Test4(113,"santhi");
            t.display();
            t1.display();


        }
    }
}
