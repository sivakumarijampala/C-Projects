using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class DivideByOddNo : Exception
    {
        /*public override string Message
        {
            get
            {
                return "attempted to divide by zero";
            }
        }*/

       /* public DivideByOddNo(string message)
                       : base(message)
        {

        }*/

        public DivideByOddNo()
                      
        {
          Console.WriteLine("attempted to divide by zero");
        }
    }
}

