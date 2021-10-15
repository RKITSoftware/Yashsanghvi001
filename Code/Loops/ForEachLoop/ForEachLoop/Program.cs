using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Languages = { "C++", "C#", "Java", "Python", "JavaScript" };

            foreach(string language in Languages) // defiine foreach loop
            {
                Console.WriteLine(language);
            }
            Console.Read();
        }
    }
}
