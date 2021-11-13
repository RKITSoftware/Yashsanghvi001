using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_Inheritance
{
    class Father // Base Class
    {
        public void display()
        {
            Console.WriteLine("Display From Father Class");
        }
    }
    class Son : Father // derived Class
    {
        public void displayOne()
        {
            Console.WriteLine("Display Form Son Class");
        }
    }
    class Daughter : Father // second derived Class
    {
        public void displayTwo()
        {
            Console.WriteLine("Display From Daughter Class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Father ObjFather = new Father();
            ObjFather.display();

            Console.WriteLine();

            Son ObjSon = new Son(); // son can access it's parent class
            ObjSon.display();
            ObjSon.displayOne();

            Console.WriteLine();

            Daughter ObjDaughter = new Daughter();// Daughter can access it's parent class
            ObjDaughter.display();
            ObjDaughter.displayTwo();

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
