using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicModifier
{    // Declaring members rollNo and name as public
    class Student
    {
        public int rollNo;
        public string name;
        //constructor
        public Student(int r, string n)
        {
            rollNo = r;
            name = n;
        }
        // method getName declared as public
        public string getName()
        {
            return name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {            // Creating object of the class Student
            Student objStudent = new Student(10, "Yash");
            // Displaying details directly using the class members accessible through another method
            Console.WriteLine("Roll number: {0}", objStudent.rollNo);
            Console.Write("Name: {0}", objStudent.name);
            Console.WriteLine();
            Console.WriteLine("Name: {0}", objStudent.getName());
            Console.Read();

        }
    }
}
