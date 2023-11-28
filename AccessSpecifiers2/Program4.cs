using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers2
{
    //case4:consuming members of class from  child class in different project
     class Program4:AccessSpecifiers.Program
    {
        static void Main(string[] args)
        {
            Program4 p = new Program4();
            p.Test3();
            p.Test4();
            p.Test5();

        }
    }
}
