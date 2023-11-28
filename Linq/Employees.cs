using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public  class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public static List<Employees> GetEmployees()
        {
            return new List<Employees>
            {
                new Employees {Id=1,Name="sivakumari",Gender="female",Salary=12000},
                new Employees {Id=2,Name="shiv",Gender="female",Salary=20000},
                new Employees {Id=3,Name="ram",Gender="male",Salary=25000},
                new Employees {Id=4,Name="lakshman",Gender="male",Salary=4000}
            };
        }
    }
}
