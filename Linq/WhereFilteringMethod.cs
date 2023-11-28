using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{

    //where filtering methods
    //where method
    //of type method
    public class WhereFilteringMethod
    {
        static void Main()
        {

            //method syntax
            List<int> intlist1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> filteredData = intlist1.Where(x => x > 5);
            Console.WriteLine(string.Join(" ",filteredData));


            //query syntax
            Console.WriteLine("********");
            IEnumerable<int> intList2 = from data in intlist1
                                        where data > 5
                                        select data;
            Console.WriteLine(string.Join(" ",intList2));

            //another way
            Console.WriteLine("*******");
           IEnumerable<int> num= intlist1.Where(x => CheckNumber(x));
            foreach(int y in num)
            {
                Console.WriteLine(y);
            }

            //find numbers along with their index
            Console.WriteLine("***********");
            var oddNumbersWithInsedPosition= intlist1.Select((nu, index) => new
            {
                Numbers = nu,
                IndexPosition = index

            }).Where(x => x.Numbers % 2 != 0)
                              .Select(data => new
                              {
                                  Number=data.Numbers,
                                  IndexPos=data.IndexPosition
                              }
                );

            foreach (var  i in oddNumbersWithInsedPosition)
            {
                Console.WriteLine(i.IndexPos+" ---"+i.Number);
            }


        }
        public static bool CheckNumber(int x)
        {
            if (x > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       

       



    }
}
