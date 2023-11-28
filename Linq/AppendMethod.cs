using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class AppendMethod
    {
        public static void Main()
        {
            List<int> num= new List<int>() {1,2,4,5,6};
            num.Append(10);

            Console.WriteLine("**********");
            Console.WriteLine(string.Join(",",num));


            Console.WriteLine("**************");
            Console.WriteLine(string.Join(",",num.Append(8)));


            Console.WriteLine("************");
            List<int> num2 = num.Append(11).ToList();
            Console.WriteLine(string.Join(" ", num2));
        }
    }
}
