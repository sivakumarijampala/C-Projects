using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


//select many projection method
namespace Linq
{
    internal class SelectManyProjectionMethod
    {
        public static void Main()
        {
            List<string> list = new List<string>()
            {
                "siva",
                "kumari"
            };


            //method syntax
            IEnumerable<char> ch=list.SelectMany(x => x);
            Console.WriteLine(string.Join(" , ",ch));


            //Query Syntax
            Console.WriteLine("***************");
            List<Char> e = (from l in list
                                  from c in l
                                  select c).ToList();
            foreach(var c in e)
            {
                Console.Write(c+" ");
            }


            //method syntax
            Console.WriteLine("*************");
            Stud s = new Stud();
            List<string> s1 = s.DispalyStudents().SelectMany(a => a.Programming).ToList();
            foreach(string s2 in s1)
            {
                Console.WriteLine(s2);
            }



            //query syntax
            Console.WriteLine("*************");
            List<string> pro= (from std in s.DispalyStudents()
            from program in std.Programming
            select program).ToList();
            Console.WriteLine(string.Join(", ",pro));


            Console.WriteLine("***********");

            //removing duplicates by using select many in linq
            //method syntax
            List<string> du= s.DispalyStudents().SelectMany(a => a.Programming).Distinct().ToList();
            Console.WriteLine(string.Join(" ",du));


            //query syntax
            Console.WriteLine("*********");
            List<string> programming = (from student in s.DispalyStudents()
                                        from program in student.Programming
                                        select program).Distinct().ToList();
            Console.WriteLine(string.Join(" ",programming));


            //retrive student name along with programming languages
            //method syntax
            Console.WriteLine("***********");
            var methodSyntax = s.DispalyStudents().SelectMany(stu => stu.Programming,
                                     (stu, program) => new
                                     {
                                         studentName = stu.Name,
                                         programname = program
                                     }).Distinct().ToList();
            foreach(var i in methodSyntax)
            {
                Console.WriteLine(i.studentName+"------>"+i.programname);
            }

            //query syntax

            Console.WriteLine("********");
             var querySyntax =(from st in s.DispalyStudents()
                                  from prog in st.Programming
             select new
             {
                 stuName = st.Name,
                 Program1=prog
             }).ToList();

            foreach(var k in querySyntax)
            {
                Console.WriteLine(k.stuName+"---"+k.Program1);
            }
        }
    }
}
