using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class EmptyMethod
    {
        public static void Main()
        {
            IEnumerable<string> list = Enumerable.Empty<string>();
            IEnumerable<Student> students = Enumerable.Empty<Student>();   
            
            Console.WriteLine(list.Count());
            Console.WriteLine(list.GetType().Name);
            Console.WriteLine(students.Count());
            Console.Write(students.GetType().Name);


            Console.WriteLine("************");
            IEnumerable<int> num = GetData();
            if (num != null)
            {
                foreach (int i in num)
                {
                    Console.WriteLine(i);
                }
            }


            Console.WriteLine("*************");
            IEnumerable<int> num1= GetData() ?? Enumerable.Empty<int>() ;
            foreach(int i in num1)
            {
                Console.WriteLine(i);
            }

        }

        public static IEnumerable<int>  GetData()
        {
            return null;

        }

        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Salary { get; set; }
        }
    }
}
