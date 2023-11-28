using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{

    //partitioning operators
    public class LinqPartitioningMethods
    {

        public static   void Main()
        {
            List<int> numbers = new List<int>() { 1, 2, 4, 5, 8, 3, 9, 6, 7 };

            Console.WriteLine("***********");
            //method syntax using take method
            List<int> result =numbers.Take(4).ToList();
            
            foreach(int i in result)
            {
                Console.WriteLine(i+" ");
            }

            Console.WriteLine("***********");
            //query syntax using take method
            List<int> numbers2 = (from i in result select i).Take(4).ToList();   

            foreach(int i in numbers2)
            {
                Console.WriteLine($"{i} ");
            }

            Console.WriteLine("**********");
            //where method after take method-->method syntax

            List<int> res=numbers.Take(4).Where(x => x > 2).ToList();
            foreach(int i in res)
            {
                Console.WriteLine(i+" ");
            }

            Console.WriteLine("************");
            //where method after take method--->query syntax
            List<int> res1=(from i in numbers select i).Take(4).Where(x=>x>2).ToList();
            foreach(int i in res1)
            {
                Console.WriteLine($"{i} ");
            }

            Console.WriteLine("*********");
            //where condition after take method--->method syntax
            List<int> res2=numbers.Where(x => x > 2).Take(4).ToList();
            foreach (int i in res2)
            {
                Console.WriteLine($"{i}");
            }


            Console.WriteLine("***********");
            //where condition after take method --->query syntax
            List<int> res3=(from i in numbers select i).Where(x=>x>2).Take(4).ToList();
            foreach(int i in res3)
            {
                Console.WriteLine(i + "");
            }

            //if data source is null---->Argument null exception
            List<int> num = null;


            //method syntax

            /*List<int> num1=num.Take(4).ToList();

            foreach(int i in num1 )
            {
                Console.WriteLine(i + " ");
            }*/

            //query syntax
            /*List<int> num2 = (from i in num1 select i).Take(4).ToList();
            foreach(int i in num2)
            {
                Console.WriteLine(i + " ");
            }*/
        }
    }
}
