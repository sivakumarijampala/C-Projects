using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeClassLibrary
{
    public class Class1
    {
        public int X;
        private int Y;
        public int P1 { get; set; }
        private int P2 { get;set; } 
        public  void Method1()
        {
            Console.WriteLine("method1 invoked");
        }
        private void Method2()
        {
            Console.WriteLine("method2 invoked");
        }
    }
}
