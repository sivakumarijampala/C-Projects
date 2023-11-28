using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Test3
    {
       public Test3()
        {
            Console.WriteLine("constructor invoked");
        }

        //A destructor works opposite to constructor, It destructs the objects of classes. It can be defined only once in a class. Like constructors,

        //it is invoked automatically.
        //Note: C# destructor cannot have parameters.
        //modifiers can't be applied on destructors.
        ~Test3()
        {
            Console.WriteLine("distructor invoked");
        }

    }
    class Student10
    {
        static void Main()
        {
            Test3 t = new Test3();
            Test3 t1 = new Test3();

        }

    }
}
