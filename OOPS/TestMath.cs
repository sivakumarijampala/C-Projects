using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
   public static class Test5
    {
        public static int id=10;
        public static int cube(int value)
        {
            return value * value * value;
        }

    }
     class TestMath
    {
        static void Main()
        {
            Console.WriteLine("id is"+Test5.id);
            Console.WriteLine("the cube is:"+Test5.cube(5));
        }
    }
}
