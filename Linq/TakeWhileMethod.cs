using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class TakeWhileMethod
    {
        public static void Main()
        {
            List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9};

            //method syntax
            List<int> numbers=list.TakeWhile(num => num < 5).ToList();

            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }

            
            Console.WriteLine("****************");
            //query syntax

            List<int> numbers1=(from num in list select num).TakeWhile(num => num < 5).ToList();
            foreach (int num in numbers)
            {
                Console.WriteLine(num);   //output--->1,2,3,4,5
            }

            
            Console.WriteLine("***********");
            //method syntax
            List<int> list1= new List<int>() { 1, 4, 5, 6, 7, 8, 9,2,3 };
            List<int> li= list1.TakeWhile(n=>n<5).ToList();
            foreach (var item in li)
            {
                Console.WriteLine(item);  //output---->1,4
            }

            
            Console.WriteLine("***********");
            //query syntax
            List<int> li1=(from num in list1 select num ).TakeWhile(n=>n<5).ToList();
            foreach(var item in li1)
            {
                Console.WriteLine(item);
            }


            //method syntax
            Console.WriteLine("************");
            List<int> li2=list1.Where(n => n < 5).ToList();
            foreach (var item in li2)
            {
                Console.WriteLine(item);
            }
           

            //query syntax
            Console.WriteLine("***********");
            List<int> li3=(from i in list1 select i).Where(n=>n<5).ToList();
            foreach(int item in li3)
            {
                Console.WriteLine(item);
            }




        }
    }
}
