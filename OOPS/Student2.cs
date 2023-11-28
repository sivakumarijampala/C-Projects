using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
     class Student2
    {
        int id;
        string name;

        //parameterized constructor
        Student2(int id1,string name1)
        {
            id = id1;
            name = name1;

        }
        static void Main()
        {

            //creating object for Student2 class
            Student2 student2= new Student2(1,"malliswari");
            Console.WriteLine("student id:"+student2.id);
            Console.WriteLine("student name:"+student2.name);



        }
    }
}
