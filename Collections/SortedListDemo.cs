using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Collections
{
    internal class SortedListDemo
    {
        static public  void Main()
        {
            SortedList list1 = new SortedList();
            list1.Add(1, "siva");
            list1.Add(2, "kumari");
            list1.Add(3, "ramu");
            list1.Add(4, "lakshman");
            foreach(DictionaryEntry s in list1)
            {
                Console.WriteLine(s.Key+" "+s.Value);
            }

            
            //containskey method--->checks the key is present or not      
            Console.WriteLine(list1.ContainsKey(1));

            //contains value method--->checks the value is present or not
            Console.WriteLine(list1.ContainsValue("ramu"));

            //contains--->checks whether the key present or not
            Console.WriteLine(list1.Contains(2));


            //getkey method is used to get the key based on index
            Console.WriteLine(list1.GetKey(2));

            
         

        }

        
    }
}
