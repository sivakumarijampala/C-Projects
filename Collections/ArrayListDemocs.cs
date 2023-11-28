using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class ArrayListDemocs
    {
        static void Main()
        {
            ArrayList arrayList = new  ArrayList();

            arrayList.Add(new student(1, "shiv", 24));
            arrayList.Add(new student(2, "pooja", 23));
            arrayList.Add(new student(3, "trusha", 22));
            arrayList.Add(new student(4, "sai", 22));
            arrayList.Add(new student(5, "supriya",23));
            //arrayList.Add(new student(5, "supriya", 23));


            //checking list contains name if it contains print the age of that person
            foreach (student s in arrayList)
            {
                if (s.name.Contains("shiv"))
                {
                    Console.WriteLine(s.age);
                }

            }


          //check the list contains name or not
            var isNamePresent = false;
          foreach(student s1 in arrayList)
            {
                if (s1.name.Contains("shiv"))
                {
                    isNamePresent = true;
                }
            }
            if (isNamePresent == true)
            {
                Console.WriteLine("the name present in list");
            }
            else
            {
                Console.WriteLine("name not present in list");
            }

            //finding sum of ages in the list
            int sumage = 0;
            foreach(student s in arrayList)
            {
                sumage = sumage + s.age;
            }
            Console.WriteLine("sum of age is:"+sumage);

            //counting no of students in list
            int countofstud=arrayList.Count;
            Console.WriteLine("no of students in list:"+countofstud);


            //converting list to set
            Console.WriteLine("converting arraylist to set");
            HashSet<student> students = new HashSet<student>(arrayList.Cast<student>());
            foreach(student s in students)
            {
                Console.WriteLine($"id:{s.id},name:{s.name},age:{s.age}");
            }

            Console.WriteLine("converting arraylist to array");
            //converting list to array
            student[] array = arrayList.Cast<student>().ToArray();
            foreach(student s in array)
            {
                Console.WriteLine($"id:{s.id},name:{s.name},age:{s.age}");
            }

            //converting arraylist to dictionary
            Dictionary<int, student> dic = arrayList.Cast<student>()
                .ToDictionary(student => student.id);

            foreach(KeyValuePair <int,student>  s in dic){
                Console.WriteLine($"key:{s.Key}"+"----------->"+$"value:id:{s.Value.id},name:{s.Value.name},age:{s.Value.age}");

            }

            //finding min age in arraylist
           int minage= arrayList.Cast<student>().Min(s => s.age);
            Console.WriteLine("min age is:"+minage);

            //finding max age
            int maxage=arrayList.Cast<student>().Max(s => s.age);
            Console.WriteLine("max age is:"+maxage);

            //avg age
            double avgage=arrayList.Cast<student>().Average(s=>s.age);
            Console.WriteLine("average:"+avgage);

            //finding max age student name
            student stu=arrayList.Cast<student>().OrderByDescending(s => s.age).First();
            Console.WriteLine(stu.name);

           //equals method
            var isNameEquals = false;
            foreach(student s in arrayList)
            {
                if (s.name.Equals("pooja"))
                {
                    isNameEquals = true;
                    Console.WriteLine(s.id);
                }
            }
            if (isNameEquals == true)
            {
                Console.WriteLine("the name is equal");
            }
            else
            {
                Console.WriteLine("name not there in list");
            }

            //fetching all names in list
            Console.WriteLine("nmaes in list");
            foreach (student s in arrayList)
            {
                Console.WriteLine(string.Join(",",s.name));
            }

            //groupby
            var groupbyage=arrayList.Cast<student>().GroupBy(s =>s.age);
            foreach(var s in groupbyage)
            {
                Console.WriteLine(s.Key);
                foreach(var student in s)
                {
                    Console.WriteLine("name:"+student.name);
                }
            }

            //sorting
            Console.WriteLine("sorting elements by age ");
            arrayList.Sort();
            foreach(student s in arrayList)
            {
                Console.WriteLine(s.id+" "+s.name+" "+s.age);
            }

        }

    }
}
