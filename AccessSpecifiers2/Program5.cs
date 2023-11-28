using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers2
{
    //case5:consuming members of a class from non-child class of different project
    //private:not possible,protected:not possible,internal:not possible,
    //protectedinternal:not possible
    class Program5
    {
        static void Main()
        {
            AccessSpecifiers.Program ap = new AccessSpecifiers.Program();
            ap.Test5();
        }
    }
}
