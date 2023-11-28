using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{
    //case2:consuming members from child class in same project
    class ProgramTwo:Program
    {
        static void Main()
        {
            ProgramTwo two = new ProgramTwo();
            two.Test2();
            two.Test3();
            two.Test4();
            two.Test5();
        }
    }
}
