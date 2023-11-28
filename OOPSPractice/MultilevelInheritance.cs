using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPractice
{
    class Animal
    {
        public void eat()
        {
            Console.WriteLine( "eating");
        }
    }
    class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("barking");
        }
    }
    class BabyDog : Dog
    {
        public void weep()
        {
            Console.WriteLine( "weeping");
        }
    }

     class MultilevelInheritance
    {
        public static void Main()
        {
            BabyDog babyDog = new BabyDog();
            babyDog.weep();
            babyDog.bark();
            babyDog.eat();
        }
    }
}
