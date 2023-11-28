using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
     class Student
    {
        int id;
        string name;
        static void Main()
        {

            //creating stuident object
            Student student = new Student();
            
            /*student.id = 1;
            student.name = "shiv";*/
            
            Console.WriteLine("id is:"+ student.id);
            
            //it will default print empty string 
            Console.WriteLine("name  is:"+ (student.name??  "null"));

        }
    }
}
