using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPractice
{
   abstract class Shape
    {
        public abstract int area();
    }
   class Square : Shape
    {
        public int side;
        public Square(int x)
        {
            side = x;
        }
        public override int  area()
        {
            return (side * side);
        }

    }
    public class Abstraction
    {
        static void Main()
        {


            Square square = new Square(7);
            double result = square.area();
            Console.WriteLine("area of square is:" + result);



        }
    }
}
