using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPractice
{
   public  class Indexors
    {
        static void Main()
        {
            Employee3 employee3 = new Employee3(1,"shiv",20000);
            
            //getting the value based on index
            Console.WriteLine("eno:" + employee3[0]);
            Console.WriteLine("ename:" + employee3[1]);
            Console.WriteLine("salary:" + employee3[2]);
            
            //setting value based on index
            employee3[0] = 12;
            employee3[1] = "sivakumari";
            employee3[2] = 20000;
            Console.WriteLine("******* *******");
            Console.WriteLine("eno:" + employee3[0]);
            Console.WriteLine("ename:" + employee3[1]);
            Console.WriteLine("salary:" + employee3[2]);

            Console.WriteLine("*****************");
            Console.WriteLine("printing values based on string");
            Console.WriteLine("eno:" + employee3["eid"]);
            Console.WriteLine("ename:" + employee3["name"]);
            Console.WriteLine("salary:" + employee3["salary"]);


            Console.WriteLine("*****************");
            employee3["eid"] = 10;
            employee3["name"] = "ram";
            employee3["salary"] = 20000;
            Console.WriteLine("printing values based on string");
            Console.WriteLine("eno:" + employee3["eid"]);
            Console.WriteLine("ename:" + employee3["name"]);
            Console.WriteLine("salary:" + employee3["salary"]);
        }

            
    }
}
