using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class OrderBymethod
    {
        public static void Main()
        {
            List<int> num= new List<int>() { 10,2,3,23,43,7,8,6,9};

            //method syntax
            List<int> numbers=num.OrderBy(x=> x).ToList();
            foreach(int x in numbers)
            {
                Console.WriteLine(x);
            }


            Console.WriteLine("***********");
            //query  syntax
            List<int> l=(from x in numbers select x).OrderBy(x => x).ToList();
            List<int> l1=(from i in numbers orderby i select i).ToList();
            foreach(int a in l1)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("***********");
            List<string> names= new List<string>() { "siva","anusha","priya","swathi","bhavana"};

            //method syntax
            List<string> l2=names.OrderBy(x=>x).ToList();
            foreach (string x in l2)
            {

                Console.WriteLine(x);
            }


            Console.WriteLine("****************");
            //query syntax
            List<string> l3=(from n in names orderby n select n).ToList();  
            foreach(string x in l3)
            {
                Console.WriteLine(x);
            }



            //order by method based on complex types
            Console.WriteLine("***********");
            List<Student1> l4 = Student1.GetAllStudents().OrderBy(stu => stu.Name).ToList();
            foreach (Student1 s in l4)
            {
                Console.WriteLine($"Id={s.Id},Name={s.Name},Department={s.Department}");

            }

            Console.WriteLine("*************");
            //query syntax
            List<Student1> l5=(from student in l4 orderby student.Name select student).ToList(); 
            foreach(Student1  student in l5)
            {
                Console.WriteLine($"Id={student.Id},name={student.Name},Department={student.Department}");
            }

            Console.WriteLine("**************");
            List<Student1> stud=Student1.GetAllStudents().Where(s=>s.Department=="IT").OrderBy(s=>s.Name).ToList();
            foreach(Student1 s in stud)
            {
                Console.WriteLine($"Id={s.Id},Name={s.Name},Department={s.Department}");
            }

            Console.WriteLine("**************");
            List<Student1> su=(from st in Student1.GetAllStudents() where st.Department=="Hr" orderby st.Name select st).ToList();
            foreach (Student1 s in su)
            {
                Console.WriteLine($"Id={s.Id},Name={s.Name},Department={s.Department}");
            }

            Console.WriteLine("implementing comparer interface");
            Console.WriteLine("*************");
            CaseSensitiveComparer caseSensitive = new CaseSensitiveComparer();
            string[] str = { "A", "a", "B", "b", "c", "C","D","F","U","G" };
            var stringalphabets=str.OrderBy(s => s, caseSensitive);
            foreach(var s in stringalphabets)
            {
                Console.WriteLine(s);
            }



        }
    }

    public class CaseSensitiveComparer : IComparer<string>

    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, true);
        }
    }
}
