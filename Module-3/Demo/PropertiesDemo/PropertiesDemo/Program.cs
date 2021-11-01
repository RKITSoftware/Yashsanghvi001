using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    class student
    {
        //Getter and setter is used to set or get value.
        public static string name { get; set; }
        public static int age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        { //set the value.
            student.name = "Yash";
            student.age = 20;

            //get the value.
            Console.WriteLine("Name : " + student.name);
            Console.WriteLine("Age : " + student.age);
            Console.ReadLine();
        }
    }
}
