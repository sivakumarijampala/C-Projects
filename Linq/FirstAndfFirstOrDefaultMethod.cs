using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class FirstAndfFirstOrDefaultMethod
    {
        public static void Main()
        {
            List<int> list= new List<int>() { 1,2,3,4,5,6,7,8,9,10};

            //method synatx
            Console.WriteLine("********method syntax*********");
            int number = list.First();
            Console.WriteLine(number);


            //query syntax
            Console.WriteLine("************query syntax********" );
            int num1=(from num in list select num).First();
            Console.WriteLine(num1);
            

            //method syntax
            Console.WriteLine("********finding first even number********");
            int number1=list.First(e=>e%2==0);
            Console.WriteLine(number1);

            //query syntax
            Console.WriteLine("******* query syntax find first even number*********");
            int number2=(from num in list select num).First(e=>e%2==0);
            Console.WriteLine(number2);


            //empty datasource
            Console.WriteLine("*******data source is empty*******");
            List<int> list2 = new List<int>();


            //method syntax
            Console.WriteLine("*******method syntax********");
           // int n = list2.First();  //invalid operation exception
            //Console.WriteLine(n);

            //query syntax
            Console.WriteLine("*******Query Syntax**********");
            //int n1 = (from num in list2 select num).First();
            // Console.WriteLine(n1);  //invalid operation exception


            Console.WriteLine("*******list is null*********");
            List<int> list3 = null;
            //Console.WriteLine(list3.First());  //argument null exception



            Console.WriteLine("first or default method examples");
            List<int> n1= new List<int>() { 10,20,30,40,50,60,70,80,90};
            Console.WriteLine("first or default method method syntax");
            Console.WriteLine(n1.FirstOrDefault());



            Console.WriteLine("first or default method query syntax");
            int qs = (from num in n1 select num).FirstOrDefault();
            Console.WriteLine(qs);


            //method syntx
            Console.WriteLine("******");
            List<int> n2 = new List<int>();
            Console.WriteLine(n2.FirstOrDefault());

            //query syntax
            Console.WriteLine("********");
            int a=(from i in n2 select i).FirstOrDefault();
            Console.WriteLine(a);

            //List<int> n3 = null;
           // Console.WriteLine(n3.FirstOrDefault());  //argument null exception


            List<Student1> stu = Student1.GetAllStudents();
            Student1 s=stu.First();
            Console.WriteLine($"Id={s.Id},Name={s.Name},Department={s.Department}");

        }
    }
}
