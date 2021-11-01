using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //declare class as abstract
    abstract class AreaClass
    {
        // declare method as abstract
        abstract public int Area();
    }
    class Square : AreaClass
    {
        int Length = 0;
        // constructor 
        public Square(int n)
        {
            Length = n;
        }
        // the abstract method is overridden here 
        public override int Area()
        {
            return Length * Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Square objSqure = new Square(4);
            Console.WriteLine("Area = " + objSqure.Area());
            Console.Read();
        }
    }
}
