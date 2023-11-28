using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{
    //case1:consuming members from same class
    public class Program
    {

        //private method
        private void Test1()
        {
            Console.WriteLine( "private method");
        }

        //internal method

        internal void Test2()
        {
            Console.WriteLine("internal method");
        }

        //protected method
        protected void Test3()
        {
            Console.WriteLine("protected method");
        }

        //protected internal
        protected internal void Test4()
        {
            Console.WriteLine("protected internal method");
        }

        //public method
        public void Test5()
        {
            Console.WriteLine( "public method");
        }
        static void Main(string[] args)
        {
            Program p= new Program();
            p.Test1();
            p.Test2();
            p.Test3();
            p.Test4();
            p.Test5();


        }
    }
}
