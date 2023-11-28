using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class ElementAtMethodAtObjects
    {
        public static void Main()
        {
            Console.WriteLine("********mehod syntax  element at method************");
            //method syntax
            Student1 ElementAtMs = Student1.GetAllStudents().ElementAt(1);
            Console.WriteLine($"Id={ElementAtMs.Id},Name={ElementAtMs.Name},Department={ElementAtMs.Department}");

            Console.WriteLine("*********query syntax element at method************");
            //query syntax
            Student1 ElementAtQs=(from student in Student1.GetAllStudents() select student).ElementAt(3);
            Console.WriteLine($"Id={ElementAtQs.Id},Name={ElementAtQs.Name},Department={ElementAtQs.Department}");

            Console.WriteLine("************method syntax element at or default method*********");
            //method syntax
            Student1 ElementAtOrDefault = Student1.GetAllStudents().ElementAtOrDefault(2);
            Console.WriteLine($"Id={ElementAtOrDefault.Id},Name={ElementAtOrDefault.Name},Department={ElementAtOrDefault.Department}");

            Console.WriteLine("*******query syntax element at or default method*****************");
            //query syntax
            Student1 ElementAtOrDefaultQuerySyntax=(from stu in Student1.GetAllStudents() select stu).ElementAtOrDefault(0);
            Console.WriteLine($"Id={ElementAtOrDefaultQuerySyntax.Id},Name={ElementAtOrDefaultQuerySyntax.Name}, Department ={ElementAtOrDefaultQuerySyntax.Department}");
        }

            
    }
}
