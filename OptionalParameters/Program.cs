using System;
namespace OptionalParameters
{
    internal class Program
    {
         
        static void Main(string[] args)
        {
           
            Employee emp = new Employee(1,"sivakumari",23,20000,"computer");
            Console.WriteLine(emp[0]);
            Console.WriteLine(emp["EmpName"]);

            var name = "sivakumari";
            int count= name.Length;
            Console.WriteLine(count);

            dynamic name1 ;
          
            name1 = "siva kumari one";
            Console.WriteLine(name1);
            int coun1t=name1.Length;
            Console.WriteLine(coun1t);


            var fullname = "shiv";
            fullname = "kumari";

            Console.WriteLine(fullname);

            dynamic lastname = "jampala";
            lastname = 10;
            Console.WriteLine(lastname);
           
            Console.WriteLine( AddValues(10, 34));
          



        }
        public  static dynamic AddValues(dynamic a,dynamic b)
        {
            return a + b;
        }
        public static var AddValues(var a,var b)
        {
            return a + b;
        }
      
       
    }
}