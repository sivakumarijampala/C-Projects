using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPractice
{
     class LogicalOperators
    {
        static void Main()
        {

            //logicle operators
            Console.WriteLine("logical operators:");
            Console.WriteLine( );
            bool a = false;
            bool b= true;
            
            Boolean result = a && b;
            Console.WriteLine("result is:"+result);


            Boolean result1= a || b;
            Console.WriteLine("result is:" + result1);

            Boolean result2 =  ! b;
            Console.WriteLine("result is:" + result2);

            Console.WriteLine(  );
            //bitwise operators
            Console.WriteLine( "bitwise operators:");
            Console.WriteLine( "****************");
            int x = 10;
                int y = 20;

                //bitwise and
                int res1 = x & y;
                Console.WriteLine("result1 is: " + res1);

                //bitwise or
                int res2 = x | y;
                Console.WriteLine("result2 is: " + res2);

                //bitwise xor
                int res3 = x ^ y;
                Console.WriteLine("result3 is: " + res3);


                //bitwise leftshift
                int res4 = x << 2;
                Console.WriteLine("result4 is: " + res4);


                //bitwise right shift
                int res5 = x >> 2;
                Console.WriteLine("result5 is: " + res5);

            Console.WriteLine();
            Console.WriteLine("assignment operators:");
            Console.WriteLine( "************");
            Console.WriteLine();
            //assignment operators
            int l = 80;int m = 50;

            l += m;
            Console.WriteLine("add assignment operator:"+l);

            l -= m;
            Console.WriteLine("sub assignment operator:"+l);

            l *= m;
            Console.WriteLine("mul assignment operator:"+l);

            l = 40;
            l %= m;
            Console.WriteLine("div assignment operator is:"+l);


            l = 10;
            l /= m;
            Console.WriteLine("mod assigment operator is:"+l);


            l = 70;
            l <<= 2;
            Console.WriteLine(l);

            l >>= 2;
            Console.WriteLine(l);


            l = 80;
            l &= 10;
            Console.WriteLine(l);

            l ^= 10;
            Console.WriteLine(l);

            l |= 10;
            Console.WriteLine(l);
            Console.WriteLine(  );


            //conditional operators
            Console.WriteLine( "conditional operators");
            int num1 = 20;
            int num2 = 60;
            int resu = num1 > num2 ? num1  : num2;
            Console.WriteLine(resu);
            Console.WriteLine();


            //datatypes
            Console.WriteLine("datatypes and range:");
            Console.WriteLine();
            Console.WriteLine("Range of sbyte: {0} to {1}", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("Range of byte: {0} to {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Range of short: {0} to {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("Range of ushort: {0} to {1}", ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("Range of int: {0} to {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("Range of uint: {0} to {1}", uint.MinValue, uint.MaxValue);
            Console.WriteLine("Range of long: {0} to {1}", long.MinValue, long.MaxValue);
            Console.WriteLine("Range of ulong: {0} to {1}", ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("Range of float: {0} to {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("Range of double: {0} to {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("Range of decimal: {0} to {1}", decimal.MinValue, decimal.MaxValue);




        }

        }
}

