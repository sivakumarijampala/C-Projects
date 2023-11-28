using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPractice
{
    internal class NullableTypes
    {
        static void Main()
        {
            //defining nullable type(1 way)
            Nullable <int> n = null;
            Console.WriteLine( n.GetValueOrDefault());

            //defining nullable types
            int ? a= null;
            Console.WriteLine(a.GetValueOrDefault());

            //defing non nullable types

            Nullable<int> n1 = 47;
            Console.WriteLine(n1.GetValueOrDefault());

            int? a1 = 30;
            Console.WriteLine(a1.GetValueOrDefault());

            int? a2 = null;
            Console.WriteLine( a2 );

            int? b = 234;
            Console.WriteLine(b);


            //nullable type contains null values
            Nullable<int> b1 = null;
           
            //check the value of object
            Console.WriteLine(b1.HasValue);


            //nullable type contains value
            Nullable<int> b2 = 89;
           
            //check the value of object
            Console.WriteLine(b2.HasValue);


            //nullable type
            int? m = null;

            //means if m is null assign 58 as value to the l
            int l = m ?? 58;
            Console.WriteLine(l);




        }
    }
}
