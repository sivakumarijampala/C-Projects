using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{
    public class Program3
    {
        //case3:consuming members of class from non-child class in same project
        static void Main()
        {
            Program p = new Program();

            //accessing program class methods in Program3 class
            //private and protected not accessable
            //if we create protected in class we can only access that methods within the child class only
            //protected not accessable from non child classes
            p.Test2();
            p.Test4();
            p.Test5();
        }
    }
}
