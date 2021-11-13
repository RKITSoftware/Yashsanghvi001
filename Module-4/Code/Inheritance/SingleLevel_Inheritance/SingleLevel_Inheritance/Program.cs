using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLevel_Inheritance
{
    public class Employee // Base Class
    {
        public float salary = 40000;
    }
    public class Programmer : Employee // Child Class deriverd from Base Class
    {
        public float bonus = 10000;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Programmer p1 = new Programmer();

            Console.WriteLine("Salary: " + p1.salary); // Child Class Can Access Data Form It's Parent Class
            Console.WriteLine("Bonus: " + p1.bonus);
            Console.Read();

        }
    }
}
