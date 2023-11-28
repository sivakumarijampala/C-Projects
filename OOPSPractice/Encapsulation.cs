using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPractice
{

    class Student2
    {
        private int id;
        private string name;
        public int getId()
        {
            return id;
        }
        public void setId(int value)
        {
            id = value;
        }

        public string getName()
        {
            return name;
        }
        public void setName(string value)
        {
            name = value;
        }

    }

    class Encapsulation
    {
        static void Main()
        {
            Student2 student2 = new Student2();
            student2.setId(101);
            Console.WriteLine("id is:" + student2.getId());
            student2.setName("siva");
            Console.WriteLine(student2.getName());
        }

    }
}