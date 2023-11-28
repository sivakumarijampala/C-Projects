using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
     class Student7
    {
        int id;
        string name;

        //initializing values through method
        public void insert(int id1,string name1)
        {
            id = id1;
            name = name1;
        }
        //displaying values through method
        public void display()
        {
            Console.WriteLine(id+" "+name);
        }
        static void Main()
        {
            Student7 student7 = new Student7();
            student7.insert(101, "siva");
            student7.display();
            student7.insert(102, "sivakumari");
            student7.display();

        }
    }
}
