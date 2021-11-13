using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface vehical // define Interface
    {
        void Tyers();
        void Engine();
        void Speed();
    }
    class Car : vehical // Inherited Interface
    {
        public void Tyers()
        {
            Console.WriteLine("Car Have 4 Tyers");
        }
        public void Engine()
        {
            Console.WriteLine("Car is Petrol Engine");

        }
        public void Speed()
        {
            Console.WriteLine("Car's Maximum Speed is 200KMPH");

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car ObjCar = new Car();
            ObjCar.Tyers();
            ObjCar.Engine();
            ObjCar.Speed();

            Console.Read();
        }
    }
}
