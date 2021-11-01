using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{ 
    static class Person_info
{
    // Static data members of Person_Details
    public static int Age = 20;
    public static string FirstName = "Yash";
    public static string LastName = "Sanghvi";
    public static string WorkAt = "RKIT";

    // Static method of Person_Details
    public static void show_details()
    {
        Console.WriteLine("The Information of person is as below ");
    }
}
class Program
    {
        static void Main(string[] args)
        {

        // Calling static method of static class
        Person_info.show_details();

        // Accessing the static data members of static class as it cannot be inherited or instantiated
        Console.WriteLine("Age of person : {0} ", Person_info.Age);
        Console.WriteLine("Person's First name : {0} ", Person_info.FirstName);
        Console.WriteLine("Person's Last name : {0} ", Person_info.LastName);
        Console.WriteLine("Person Work at : {0} ", Person_info.WorkAt);
        Console.ReadLine();
    }
    }
}
