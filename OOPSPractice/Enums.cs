using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPractice
{
    enum month
    {
        january,
        february,
        march,
        april,
        may,
        june,
        july,
    }
    enum days
    {
        sunday,
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday,
    }
    enum colors
    {
        pink,
        blue,
        green=blue+9,
        black,
        yellow=pink+3,
    }
    enum Button : byte
    {
        Off,
        on,
    }
    internal class Enums
    {
        static void Main()
        {
            Console.WriteLine("months .............");
            Console.WriteLine((int)month.january);
            Console.WriteLine((int)month.february);
            Console.WriteLine((int)month.march);
            Console.WriteLine((int)month.april);
            Console.WriteLine((int)month.march);
            Console.WriteLine((int)month.june);
            Console.WriteLine((int)month.july);

            Console.WriteLine(  "days.............");
            Console.WriteLine((int)(days.sunday));
            Console.WriteLine((int)(days.monday));
            Console.WriteLine((int)(days.tuesday));
            Console.WriteLine((int)(days.wednesday));
            Console.WriteLine((int)(days.thursday));
            Console.WriteLine((int)(days.friday));
            Console.WriteLine((int)(days.saturday));

            Console.WriteLine("colors...........");
            Console.WriteLine((int)(colors.pink));
            Console.WriteLine((int)(colors.blue));
            Console.WriteLine((int)(colors.green));
            Console.WriteLine((int)(colors.black));
            Console.WriteLine((int)(colors.yellow));

            Console.WriteLine("enter 0 or 1 to know the state of switch");
           byte i= Convert.ToByte(Console.ReadLine());
            if (i == (byte)Button.Off)
            {
                Console.WriteLine("switch is off");
            }

            else
            {
                Console.WriteLine("switch is on");
            }

        }
    }
}
