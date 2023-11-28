using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class ProjectionMethodsinLinq
    {
        static void Main()
        {

            //query syntax
            Console.WriteLine("query syntax");
            List<Employee> employee = (from e in Employee.Display()
                                       select e).ToList();
            foreach(Employee e in employee)
            {
                Console.WriteLine($"id={e.Id},Name={e.Name},age={e.Age}");
            }
            Console.WriteLine("***********");
           
            //method syntax
            Console.WriteLine("method syntax");
            IEnumerable<Employee> e1= Employee.Display().ToList();
            foreach (Employee e in e1)
            {
                Console.WriteLine($"id={e.Id},Name={e.Name},age={e.Age}");
            }

            Console.WriteLine("************");
           
            
            //query syntax
            IEnumerable<int> ie = (from obj in Employee.Display()
                                        select obj.Id).ToList();
            foreach (var item in ie)
            {
                Console.WriteLine($"id={item}");
            }
            
            
            Console.WriteLine("*************");
            //method syntax
            IEnumerable<int> emp1 = Employee.Display().Select(e2 => e2.Id);
            foreach (var item in ie)
            {
                Console.WriteLine($"id={item}");
            }


            //selecting only few properties by using query syntax
            IEnumerable<Employee> emp=(from em in Employee.Display()
                                       
                select  new Employee()
                {
                    Name=em.Name,
                    Age=em.Age,
                    

                });

            foreach (Employee e in emp)
            {
                Console.WriteLine($"Name={e.Name},Age={e.Age}");
            }

            //selecting few properties by using Method syntax
            Console.WriteLine("**********");
            IEnumerable<Employee> m = Employee.Display().
                Select(e => new Employee()
                {
                    Name=e.Name ,
                    Age=e.Age
                });

            foreach (Employee e in m)
            {
                Console.WriteLine($"Name={e.Name},Age={e.Age}");
            }


            //selecting annonomus
            Console.WriteLine("********");

            var employee1 = (from em in Employee.Display()

                                         select new 
                                         {
                                             Name = em.Name,
                                             Age = em.Age,


                                         });

            foreach (Employee e in emp)
            {
                Console.WriteLine($"Name={e.Name},Age={e.Age}");
            }

            Console.WriteLine("**********");
            var m1 = Employee.Display().
                Select(e => new 
                {
                    Name = e.Name,
                    Age = e.Age
                });

            foreach (Employee e in m)
            {
                Console.WriteLine($"Name={e.Name},Age={e.Age}");
            }

        }
    }


}
