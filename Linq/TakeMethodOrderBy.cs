using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linq
{
    public class TakeMethodOrderBy
    {
        public static void Main()
        {
            List<Employees> employees = Employees.GetEmployees();

            //method syntax-->orderbymethod with take method
            List<Employees> ResultMs=employees.OrderByDescending(e => e.Salary).Take(4).ToList();
            foreach (Employees employee in ResultMs)
            {
                Console.WriteLine($"Id={employee.Id},Name={employee.Name},Gender={employee.Gender},Salary={employee.Salary}");
            }

            //query syntax--->order by method with take
            List<Employees> emp=(from empl in employees orderby empl.Salary descending select empl).Take(4).ToList();
            Console.WriteLine("***************");
            foreach (Employees employee in emp)
            {
                Console.WriteLine($"Id={employee.Id},Name={employee.Name},Gender={employee.Gender},Salary={employee.Salary}");
            }
        }
    }
}
