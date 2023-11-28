using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


//program demonstrates enumarable interface with linq by using query syntax and method syntax
namespace Linq
{
    internal class EnumarableUsingLinq
    {
        static void Main()
        {

            //creating list by using List class that contains integer type data
            List<int> list = new List<int>()
            {

                1,2,4,5,8,9,20,23,78
            };


            //query syntax
            //this can fetch the data from the above list which is greater than 5
            Console.WriteLine("IEnumerable interface by using linq ");
            IEnumerable<int> querySyntax = from obj in list
                                           where obj > 5
                                           select obj;
            //iterating 
            foreach (int item in querySyntax)
            {
                Console.WriteLine(item);
            }

            //without using any loop we can printelement by separating coma
            Console.WriteLine("with out forloop by using join method and separating with coma");
            Console.WriteLine(string.Join(",",querySyntax));

            //without using any loop we can printelement by separating space
            Console.WriteLine("with out forloop by using join method by separating space");
            Console.WriteLine(string.Join(" ", querySyntax));


            //method syntax-->we can convert enumarable type to list then print
            Console.WriteLine("method syntax byusing IEnumarable interface");
            List<int> numbers = list.Where(x => x > 5).ToList();
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            //or
            Console.WriteLine("**********");
            IEnumerable<int> m = list.Where(x => x > 5);
            foreach (int item in m)
            {
                Console.WriteLine(item);
            }



            //creating list by using List class that has string type data
            List<string> list2 = new List<string>()
                {
                "shiv",
                "kumari",
                "malliswari",
                "bhavana",
                "rashi"
                };


            //query syntax
            //which is used to check if the list contains 'a' it print which data contains 'a'
            //Ienumerable is an interface which is used to iterate the collection
            Console.WriteLine("query syntax by using IEnumarable");
            IEnumerable<string> querySyntax1 = from obj in list2
                                               where obj.Contains('a')
                                               select obj;

            foreach (string i in querySyntax1)
            {
                Console.WriteLine(i);
            }


            //method syntax
            Console.WriteLine("method syntax");
            IEnumerable<string> e1 = list2.Where(e => e.Contains('a'));
            foreach (string i in querySyntax1)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("IQueryable interface in linq");
            Console.WriteLine("***************");

            //IQueryable---->following shows iqueryable interface by using method syntax and query syntax
            Console.WriteLine("query syntax by using iqueryable");
            List<int> l = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            IQueryable<int> iqueryable = l.AsQueryable();
           
            List<int> numb=(from num in iqueryable
                            where num > 5
                            select num).ToList();
            Console.WriteLine(string.Join(" ",numb));


            //method syntax by using iqueryable
            Console.WriteLine("method syntax by using iqueryable");
            IQueryable<int> iqe= l.AsQueryable().Where(e => e > 5);
            Console.WriteLine(string.Join(" ",iqe));


            //even numbers -->by using Enumerable class
            Console.WriteLine("printing even numbers");
            List<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            IEnumerable<int> EvenNumbers=Enumerable.Where(intList, i => i % 2 == 0);
            Console.WriteLine(string.Join(" ",EvenNumbers));

            Console.WriteLine("***********");
            List<int> l0=intList.Where(i => i % 2 == 0).ToList();
            Console.WriteLine(string.Join(" ",l0));


            ;
        }
    }
}
