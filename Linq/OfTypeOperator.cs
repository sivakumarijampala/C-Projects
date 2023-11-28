using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class OfTypeOperator
    {
        public static void Main()
        {
            List<Object> list = new List<Object>()
            {
                "siva",10,20,"krishna","ram",45,90,"lakshman"
            };


            //getting integer values
            //method syntax
            List<int> numbers= list.OfType<int>().ToList();
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }

           
            //getting integers by using query syntax
            List<int> numbers2 = (from num in list.OfType<int>() select num).ToList();
           foreach (int i in numbers2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*********");


            //getting string values
            //query syntax
            Console.WriteLine("*************");
            List<string> names=(from name in list.OfType<string>() select name).ToList();
            Console.WriteLine(string.Join(",",names));



            //getting string using method syntax
            Console.WriteLine("**************");
            List<string> names1=list.OfType<string>().ToList();
            Console.WriteLine(string.Join(" ",names1));

           
            
            //getting string using is operator
            Console.WriteLine("************");
           List<object> name1=(from num in list where num is string select num).ToList();
            Console.WriteLine(string.Join(",",name1));

            
            //getting int using is operator
            Console.WriteLine("***********");
            var nu=(from n in list where n is Int32 select n).ToList();
            Console.WriteLine(string.Join(" ", nu));


            Console.WriteLine("************");
            List<int> ms=list.OfType<int>().Where(a => a > 40).ToList();
            foreach(int i in ms)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("***********");
            List<object> l=(from i in list where i is string && i.ToString().Length > 4 select i).ToList();
            foreach(object i in l)
            {
                Console.WriteLine(i+" ");
            }

            Console.WriteLine("*********");
            List<string> s= (from i in list.OfType<string>() where i.Length > 3 select i).ToList();
            foreach(string s1 in s)
            {
                Console.WriteLine(s1+" ");
            }
        }
    }
}
