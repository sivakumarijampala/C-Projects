using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Employee
    {
        public int Id 
        { 
            get; 
            set; 
        }
        public string Name 
        { 
            get; 
            set;
        }
        public int Age
        {
            get;
            set;
        }

        public static List<Employee> Display()
        {
            List<Employee> list = new List<Employee>
            {

                new Employee{Id=1,Name= "raju",Age=33},
                new Employee{Id=2,Name= "rama",Age=73},
                new Employee{Id=3,Name= "rashi",Age=30}

            };
            return list;
        }
    }
}
