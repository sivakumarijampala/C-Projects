using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligates
{
     class Rectangle
    {
        public void GetArea(int x,int y)
        {
            Console.WriteLine(x*y);
        }
        public void GetPerimeter(int x,int y)
        {
            Console.WriteLine(2*(x+y));
        }
        public static void Main()
        {
            Rectangle rect = new Rectangle();
            rect.GetArea(12,13);
            rect.GetPerimeter(12,13);
        }
    }
}
