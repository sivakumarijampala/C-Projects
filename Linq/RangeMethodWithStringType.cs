using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class RangeMethodWithStringType
    {
        public static void Main()
        {
            IEnumerable<string> rangeWithString = Enumerable.Range(1, 5).Select(i => (i*i ) + " " + CustomLogic(i)).ToArray();
            foreach(string str in rangeWithString)
            {
                Console.WriteLine(str);
            }
        }

        public static string CustomLogic(int num)
        {
            string result=string.Empty;
            switch(num)
            {
                case 1:
                    result = "1st";
                    break;

                case 2:
                    result = "2nd";
                    break;
                case 3:
                    result = "2nd";
                    break;
                case 4:
                    result = "2nd";
                    break;
                case 5:
                    result = "2nd";
                    break;

            }
            return result;

        }
    }
}
