using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class ElementOperators
    {
        public static void Main()
        {
         

            //element at method

            List<int> list = new List<int>() {10,20,30,40,50,60,70,80,90};
            
            Console.WriteLine("****Method syntax******");
            int MethodSyntax=list.ElementAt(1);
            Console.WriteLine(MethodSyntax);
            
            
            Console.WriteLine("******* Query Syntax********");
            int QuerySyntax=(from i in list select i).ElementAt(1);
            Console.WriteLine(QuerySyntax);

            Console.WriteLine("***********");
            //Console.WriteLine(list.ElementAt(10));//argument out of range exception
            
            Console.WriteLine("****************empty list******************");
            List<int> list1 = new List<int>();
           // Console.WriteLine(list1.ElementAt(1));  //argument out of range exception

            Console.WriteLine("*****data source is null******");
            //List<int> list2 = null;
            //Console.WriteLine(list2.ElementAt(1));  //argument null exception
                
            
            Console.WriteLine("element at or default method");
            
            //elementatorDefault method
            List<int> list3 = new List<int>() {1,2,3,4,5,6,7,8,9};
            int methodSyntax= list3.ElementAtOrDefault(1);
            Console.WriteLine(methodSyntax);
            
            
            Console.WriteLine("*****************");
            int methodsyntax=list3.ElementAtOrDefault(10);
            Console.WriteLine(methodsyntax);

            Console.WriteLine("*************");
            Console.WriteLine(list3.ElementAtOrDefault(-1));

            Console.WriteLine("******list is empty*******");
            List<int> list4 = new List<int>();
            Console.WriteLine(list4.ElementAtOrDefault(1));


            Console.WriteLine("******list is null********");
            List<int> list5 = null;
            Console.WriteLine(list5.ElementAtOrDefault(1));









        }
    }
}
