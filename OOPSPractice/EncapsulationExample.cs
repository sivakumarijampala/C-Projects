﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPractice
{
    class Student1
    {
        private int id;
        private string name;

        public int Id
        {
            get 
            { 
               return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

    }
    class EncapsulationExample
    {
        static void Main() { 
        Student1 stud = new Student1();
            stud.Id = 1;
            Console.WriteLine(stud.Id);
            stud.Name = "sivakumari";
            Console.WriteLine(stud.Name);

        }
    }
}
