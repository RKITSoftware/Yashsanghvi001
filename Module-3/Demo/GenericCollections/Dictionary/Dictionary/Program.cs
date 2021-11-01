using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {  // Creating a dictionary 
            Dictionary<int, string> My_dict = new Dictionary<int, string>();
            // Adding key/value pairs 
            My_dict.Add(1, "Hello");
            My_dict.Add(2, "I am");
            My_dict.Add(3, "Yash Sanghvi");
            // Displaying pair of dict 
            foreach (KeyValuePair<int, string> pair in My_dict)
            {
                Console.WriteLine("{0} and {1}",pair.Key, pair.Value);

            }
            Console.WriteLine();
            if (My_dict.ContainsKey(1) == true)
            {
                Console.WriteLine("Key is found...!!");
            }

            else
            {
                Console.WriteLine("Key is not found...!!");
            }
            if (My_dict.ContainsValue("Welcome") == true)
            {
                Console.WriteLine("Value is found...!!");
            }
            else
            {
                Console.WriteLine("Value is not found...!!");

            }
            Console.Read();
        }
    }
}
