using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class PrependMethod
    {
        public static void Main()
        {
            List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9};
            Console.WriteLine(string.Join("",list.Prepend(10)));
            Console.WriteLine("***********");
            List<int> num = list.Prepend(34).ToList();
            Console.WriteLine(string.Join(" ", num));
        }
    }
}
