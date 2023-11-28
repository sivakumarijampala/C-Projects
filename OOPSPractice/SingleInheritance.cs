using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPractice
{
    class Vehicle
    {
        public string brand = "Ford";
        public void honk()
        {
          Console.WriteLine("tuut...");
        }
    }

    class Car : Vehicle
    {

        public string modelName = "mustang";
        

    }

    class SingleInheritance
    {
        static void Main() { 
        Car car = new Car();
            car.honk();
            Console.WriteLine(car.brand+" "+car.modelName);


        }
}
}
