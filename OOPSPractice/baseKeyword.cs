using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPractice
{



    using System;
    public class Animal1
    {
       public string color = "white";
    }
    public class Cat: Animal1
    {
        string color = "black";
        public void showColor()
        {
            Console.WriteLine(base.color);
            Console.WriteLine(color);
        }

    }
    public class baseKeyword
    {
        public static void Main()
        {
            Cat d = new Cat();
            d.showColor();
        }
    }
}
