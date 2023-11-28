using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class HashSet
    {
        static public void Main()
        {
            HashSet<string> hashset = new HashSet<string>();
            hashset.Add("shiv");
            hashset.Add("pallavai");
            hashset.Add("ram");
            hashset.Add("ram");
           hashset.Add("pallavai"); 
            foreach (string s in hashset)
            {
                Console.WriteLine(s);
            }

            HashSet<string> set = new HashSet<string>();

              set.Add("malli");
              set.Add("mallika");
              set.Add("ram");
              set.Add("pallavai");
            foreach (string s in set)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("****");
            hashset.IntersectWith(set);
            foreach (string s in hashset)
            {
                Console.WriteLine(s);
            }

            



        }
    }
}
