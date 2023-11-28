using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class groupbycs
    {
        static void Main()
        {
            List<student> students = new List<student>()
            {
              new student(1,"siva",22),
              new student(2,"kumari",24),
               new student(3,"ram",23),
                new student(4,"malliswari",22),
                 new student(5,"lakshman",24),
                 new student(6,"priya",20),
                  new student(7,"varshika",20)
            };

            var s=students.GroupBy(x => x.age);

            foreach(var g in s)
            {
                Console.WriteLine("key:"+g.Key+"------>"+ g.Count());
               

                foreach ( var stu in g)
                {
                    Console.WriteLine(stu.name);
                }
            }

        }
    }
}
