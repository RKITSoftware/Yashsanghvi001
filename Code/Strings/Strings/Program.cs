using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "yash";
            string secondName = string.Copy(firstName); // created copy of string

            Console.WriteLine("Is Both string is equal: "+ secondName.Equals(firstName)); // Equals() method check if both string is equal or not 

            Console.WriteLine("Index of char: "+firstName.IndexOf("s")); // IndexOf() method give index of given character

            string ReplaceFirstName = firstName.Replace('Y', 'y'); // Replace() method replace one character with new one

            Console.WriteLine("Remove Character: "+ firstName.Remove(3)); // Remove() method remove character at given position

            string TrimString = " Yash   ";
            Console.WriteLine("Trim the char: \n" + TrimString.Trim()); // Trim() method trim string form both side
            Console.WriteLine("Trim From Left of char:\n" + TrimString.TrimStart()); // TrimStart() method remove white space form starting of string
            Console.WriteLine("Trim From Right of char:\n" +TrimString.TrimEnd());// TrimEnd() method remove white space form Ending of string

            Console.WriteLine("Uppercase : " + firstName.ToUpper());// Toupper() method convert string in uppercase
            Console.WriteLine("Lowercase : " + firstName.ToLower());//ToLower() method convert string in lowercase

            Console.ReadLine();



        }
    }
}
