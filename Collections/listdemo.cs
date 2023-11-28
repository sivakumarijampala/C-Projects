using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//list and methods available in list
namespace Collections
{
    internal class listdemo
    {
        static void Main(string[] args)
        {


            //creating list by using list class
            List<int> list = new List<int>();
            Console.WriteLine("capacity:" + list.Capacity); //output:0


            //adding elements to the list by using add method
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(78);  //output:4
            Console.WriteLine("capacity:" + list.Capacity);
           
            list.Add(40);
            list.Add(50);
            list.Add(60);  //output:8


            Console.WriteLine("capacity after adding elements:" + list.Capacity);

            //accessing elements from list by using foreach loop
            Console.WriteLine("elements in list");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
           
                            
            //counting elements in the list
            Console.WriteLine("no of elements in list:"+list.Count);

            //insert method-->is used to insert the element at specific position
            Console.WriteLine("elements after present in after insert");
            list.Insert(1, 3);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            //insert range
            Console.WriteLine("insert range method");
            int[]  arr= {34,45,67 };
            list.InsertRange(1, arr);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            
            //distant method is used to find unique elements
            Console.WriteLine("distant");
            List<int> d = new List<int>() { 10, 10, 20, 30, 30 };
            List<int> dis=d.Distinct().ToList();
            foreach (int i in dis)
            {
                Console.WriteLine(i);
            }

          
            //remove method--->is used to remove the element
            list.Remove(10);
            Console.WriteLine("after remove count is:"+list.Count);
           
            
            
            //converting list to array                                  
            int[] a=list.ToArray();
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
          

          
            //removeAt method--->used to remove element based on index
            list.RemoveAt(3);
            Console.WriteLine("after remove element based on index is:"+list.Count);
            Console.WriteLine(string.Join(Environment.NewLine, list));




            //remove range method
            list.RemoveRange(1, 2);
            Console.WriteLine("after remove elements based on range is:"+list.Count);
            

            //without using forloop we can print values present in collecton by using string.join method
            Console.WriteLine(string.Join(Environment.NewLine,list));

            //or we can using following way also--this print the elements by separating coma
            //ex:---10,20
            Console.WriteLine(string.Join(",",list));
            Console.WriteLine(string.Join("*",list));
            Console.WriteLine(string.Join(" ",list));

            //convert the list into array then print
            int[] a1=list.ToArray();
            Console.WriteLine(string.Join(Environment.NewLine,list));


            //capacity method
            Console.WriteLine("capacity of list is");
            Console.WriteLine( list.Capacity);

            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(70);
            list.Add(80);
            list.Add(80);
            Console.WriteLine("capacity of li is");
            Console.WriteLine(list.Capacity);


            //clear method is used to clear all elements in the list
            list.Clear();
            Console.WriteLine(string.Join(" ", list));
            Console.WriteLine("after clear the elements in the list:"+list.Count);

            List <int> l = new List<int>();           
            int[] array = {12,15,27,28,19};
            //add range method is used to add multiple elements in the list
            l.AddRange(array);
            Console.WriteLine(string.Join(" ",l));

            list.AddRange(array);
            Console.WriteLine(string.Join(" ", l));


            // sum(by using aggregate method)
            int sum= list.Aggregate((acc, num) => acc + num);
            Console.WriteLine("sum is:"+sum);

            //multiplication by using aggreate method
            int mul=list.Aggregate((acc, num) => num * acc);
            Console.WriteLine("mul is:"+mul);

            //max (finding by using aggregate method)

           int max= list.Aggregate((acc, num) => acc > num ? acc : num);
            Console.WriteLine("max is:"+max);

            //min (finding by using aggregate method)
            int min = list.Aggregate((acc, num) => acc < num ? acc : num);
            Console.WriteLine("min is:"+min);

            //concatenation by using aggregate
            var words = new List<string>() {"siva"+" "+"kumari" };
            var concatenated=words.Aggregate((acc,str)=>acc+str);
            Console.WriteLine(concatenated);

            //finding average by using aggregate
            Console.WriteLine("avg is");
            double avg = list.Aggregate(0.0, (acc, number) => acc + number) / list.Count;
            Console.WriteLine(avg);

            Console.WriteLine("elements in list is");
            Console.WriteLine(string.Join(Environment.NewLine,list));


            //checks whether element is present in list or not
            Console.WriteLine(list.Contains(50));


            //average method is used to find average
            Console.WriteLine(list.Average(x => x));

            //any method is used to check if at least one is present based on condition
            List<int> li = new List<int> {10,20,30,40,60 };
            //this checks whether at least one element is present in the list if it satisfies the condition
            Console.WriteLine(li.Any(x => x >1000));

            //all method--->is used to check the condition satisfies all elements in the list or not
            Console.WriteLine("all method");
            Console.WriteLine(li.All(x => x > 10000));
          

            //converting list of numbers to string representation
            List<int> list1 = new List<int> { 5, 2, 8, 4, 6 };
            List<string> lis=list1.Select(n => n.ToString()).ToList();
            Console.WriteLine(string.Join(Environment.NewLine,lis));
            //output---"1,2,3,4,5,6"


            //sorting elements in the list
            Console.WriteLine("sorting ascending order");
            list1.Sort();
            Console.WriteLine(string.Join(Environment.NewLine, list1));

            //sorting elements in decending order
            Console.WriteLine("sorting in decending order");
            list1.Sort((x, y) => y.CompareTo(x));
            Console.WriteLine(string.Join(Environment.NewLine, list1));

            //another way to sort elements in decending order
            Console.WriteLine("sort and reverse");
            list1.Sort();
            list1.Reverse();
            Console.WriteLine(string.Join(Environment.NewLine, list1));

            //indexof method
            //is used to find the fist matching index of that element
            Console.WriteLine("first matching index");
            List <int> l1 = new List<int> {12,45,34,67,89,45,10,89 };
            Console.WriteLine(l1.IndexOf(45));

            //lastindex of
            //used to find the last occurance of specific element
            Console.WriteLine(l1.LastIndexOf(45));

            //find-->used to find the first element that matches specific condition
            List<int> l2 = new List<int> { 12, 45, 34, 67, 89, 45, 10, 89 };
            Console.WriteLine(l2.Find(x => x % 2 == 0));

            //findlast-->is used to find the last element that matches the condition

            List<int> l6 = new List<int> { 12, 45, 34, 67, 89, 45, 10, 89 };
            Console.WriteLine(l6.FindLast(x => x % 2 == 0));

            //find all--->used to print all matching elements that satisfies specific condition
            List<int> l3 = new List<int> { 12, 45, 34, 67, 89, 45, 10, 89 };
            int[] res=l3.FindAll(x => x % 2 == 0).ToArray();
            Console.WriteLine(string.Join(" ",res));

            //findindex method is used to find the index of first element that matches the specific condition
            List<int> l4 = new List<int> { 12, 45, 34, 67, 89, 45, 10, 89 };
            Console.WriteLine(l4.FindIndex(x => x % 2 != 0));

            //findlastindex
            Console.WriteLine("last index is");
            List<int> l5 = new List<int> { 12, 45, 34, 67, 89, 45, 10, 89 };
            Console.WriteLine(l5.FindLastIndex(x => x % 2 != 0));

            //indexor
            //used to access the element based on index
            Console.WriteLine("access element based on index");
            List <string> s = new List<string>() {"siva","kumari","ram"};
            string s1=s[0];
            Console.WriteLine(s1);
            Console.WriteLine(s[1]);

            //foreach
            List<int> l9 = new List<int> { 12, 45, 34, 67, 89, 45, 10, 89 };
            l9.ForEach(n => Console.WriteLine(n));


            //getenumarator method
            Console.WriteLine("iterating by using enumarator");
            IEnumerator<string> e= s.GetEnumerator();
            while (e.MoveNext())
            {
                Console.WriteLine(e.Current);
            }

            //copyto method--->is used tocopy the elements in one list to another
            Console.WriteLine("copy method");
            List<int> lists = new List<int>() {18,34,52,89,10,34 };
            int[] copy = new int[lists.Count];
            lists.CopyTo(copy, 0);
            foreach(int i in copy)
            {
                Console.WriteLine(i);
            }

            //find min by using min method
            Console.WriteLine("min value is");
            Console.WriteLine(lists.Min());

            //find max by using max method
            Console.WriteLine("max value is");
            Console.WriteLine(lists.Max());

            //sum method
            Console.WriteLine("sum is");
            Console.WriteLine(lists.Sum());

            //first method
            Console.WriteLine("first element in list is");
            Console.WriteLine(lists.First());

            //last method
            Console.WriteLine("last element in list is");
            Console.WriteLine(lists.Last());

            //gethashcode-->is used to get the hash code
            Console.WriteLine(lists.GetHashCode());

            //gettype-->is used to specify the list type
            Console.WriteLine("type of list is");
            Console.WriteLine(lists.GetType());

            //getrange--->is used to get the range of elements
            Console.WriteLine();
            int[] ran=lists.GetRange(2, 4).ToArray();
            foreach(int i in ran)
            {
                Console.WriteLine(i);
            }

            //used to convert list into string
            Console.WriteLine(lists.ToString());

            //orderby--->is used to sort the elements in ascending order
            Console.WriteLine("order by method");
            List<int> or=lists.OrderBy(n => n).ToList();
            Console.WriteLine(string.Join(Environment.NewLine,or));

             //order by decending
            Console.WriteLine("order by decending  method");
            List<int> ordec = lists.OrderByDescending(n => n).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, ordec));

            //firstordefault-->the list contains element it will print first element
            Console.WriteLine("first or default");
            List<int> fd = new List<int>() {10,20,13,24,56};
            Console.WriteLine(fd.FirstOrDefault());

            //list does not contain any element it print default value----o/p:::0
            List<int> ford = new List<int>();
            Console.WriteLine(ford.FirstOrDefault());


            //lastordefault
            Console.WriteLine("last or default");
            Console.WriteLine(fd.LastOrDefault());
            Console.WriteLine("last or default");
            Console.WriteLine(ford.LastOrDefault());

            

        }
    }
}
