using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hybrid_Inheritance
{
    interface Vehicle // base interface
    {
         void Display();
    }
    interface PetrolCar : Vehicle 
    {
         void DisplayPetrol();

    }
    interface DieselCar : Vehicle
    {
         void DisplayDiesel();

    }
    class car : PetrolCar, DieselCar // derived form 2 interfaces
    {
        public void Display()
        {
            Console.WriteLine("Inherited form Vehicle Interface");
        }
        public void DisplayPetrol()
        {
            Console.WriteLine("Inherited From Petorl Car Interface");

        }
        public void DisplayDiesel()
        {
            Console.WriteLine("Inherited From Diesel Car Interface");

        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            car ObjCar = new car();
            ObjCar.Display();
            ObjCar.DisplayPetrol();
            ObjCar.DisplayDiesel();
            Console.Read();

        }
    }
}
