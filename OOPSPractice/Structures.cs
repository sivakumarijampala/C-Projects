using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//this program shows structures inc#

namespace OOPSPractice
{
    struct Employee1
    {

        public int employeeId;

        //this will give compile time error
        //because this we can not define explicit default constructor in struct
        //because it has implicit default constructor
        
        /*public Employee1()
        {

        }*/

        public Employee1(int value)
        {
            this.employeeId = value;
        }
        
        //this will give compile time error
        //structures can not  directly initialized at the declaration time
        // public int Age = 23;
        //inorder to initialize we need constructor 

    }

    //gives compile time error because structure dont support inheritance
    //class A:Employee1-
    class Structures
    {
        static void Main()
        {
            
             Employee1 employee = new Employee1();
            Console.WriteLine(employee.employeeId);

            //after creating instance only we can initialize struct fields
            // employee.employeeId = 10;
            //Console.WriteLine(employee.employeeId);


            //in structures there is no mandatory to use new Keyword
            Employee1 e1;

            //we must initialize the value to the struct field
            ////otherwise we get compile time error
            e1.employeeId = 12;
            Console.WriteLine(e1.employeeId);


            Console.WriteLine("parameterized constructor");
            Employee1 employee1 = new Employee1(67);
            Console.WriteLine(employee1.employeeId);


            
        }
    }
}


