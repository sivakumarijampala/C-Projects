using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPractice
{
    interface Vehicle1
    {
        //abstract methods
        void applyBrakes(int z);
        void speedUp(int x);
        void changeGear(int y);

    }
    class Bicycle : Vehicle1
    {
        //implementing interface vehicle methods
        int speed;
        int gear;
        public void applyBrakes(int z)
        {
            speed = speed - z;
        }
        public void speedUp(int x)
        {
            speed = x;
        }
        public void changeGear(int y)
        {
            gear = y;
        }
        public void displayStates()
        {
            Console.WriteLine(  speed+" "+gear);
        }
    }
    class Bike : Vehicle1
    {
        int speed;
        int gear;
        //implementing vehicle interface methods
        public void applyBrakes(int z)
        {
            speed -= z;
        }
        public void speedUp(int x)
        {
            speed = x;
        }
        public void changeGear(int y)
        {
            gear = y;
        }
        public void displayStates()
        {
            Console.WriteLine(speed + " " + gear);
        }

    }

     class MultipleInheritanceUsingInterfaces
    {
        static void Main()
        {
            Bike bike = new Bike();
            bike.speedUp(10);
            bike.changeGear(2);
            bike.applyBrakes(1);
            bike.displayStates();


            Bicycle bicycle = new Bicycle();
            bicycle.speedUp(12);
            bicycle.changeGear(11);
            bicycle.applyBrakes(3);
            bicycle.displayStates();



        }
    }
}
