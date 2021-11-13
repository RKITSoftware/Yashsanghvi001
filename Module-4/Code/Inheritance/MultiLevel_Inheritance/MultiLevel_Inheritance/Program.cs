using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevel_Inheritance
{ class GrandFather
    {
        public void Display()
        {
            Console.WriteLine("Derived From GrandFather Class");
        }

    }
class Father : GrandFather
    {
        public void Display1()
        {
            Console.WriteLine("Derived From Father Class");
        }
    }
    class Son : Father // can access method of father & grandFather Class
    {
        public void Display2()
        {
            Console.WriteLine("Derived From Son Class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Son ObjSon = new Son(); // Created Object of son class which inherited all method of father, grandfather class 
            ObjSon.Display();
            ObjSon.Display1();
            ObjSon.Display2();
            Console.Read();


        }
    }
}
