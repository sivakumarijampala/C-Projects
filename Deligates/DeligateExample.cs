using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// this program demonstrate the multicast deligate in c#

namespace Deligates
{
    //defining deligate
    //public delegate void RectDeligate(double width, double height);

    public delegate double RectDeligate(double width, double height);
    public class DeligateExample
    {
        //all the methods required to execute same values in such scenarios we will go for multicasting


        public double GetArea(double width,double height)
        {
            return width * height;
        }
        public double GetPerimeter(double width, double height)
        {
            return 2*( width + height);
        }
        /*public void GetArea(double width,double height)
        {
            Console.WriteLine("area  of rectangle is:"+(width*height));
        }
        public void GetPerimeter(double width,double height)
        {
            Console.WriteLine("peremeter of rectangle:"+(2*(width+height)));
        }*/
        static void Main()
        {
            DeligateExample d = new DeligateExample();

            //both will give same output
            //RectDeligate r = new RectDeligate(d.GetArea);

            //we can directly assign method referance like this also
           RectDeligate rect = d.GetArea;
           
            //binding another method to deligate
            rect+= d.GetPerimeter;
            rect(10.89, 20.34);

            Console.WriteLine("*********");
            double result1=rect.Invoke(10.89, 20.34);
            Console.WriteLine(result1);

            //whenever we are using multicast method make sure that the methods can not return any type
            //if we use return type it will override last method ,it will give only one result

        }
    }
}
 
