using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> Country = new SortedList<int, string>()
            {
                {4,"CANADA" },
                {3,"CHINA" },
                {1,"RASSIA" }
            };

            Country.Add(2, "USA");
            foreach (KeyValuePair<int, string> keys in Country)
            {
                Console.WriteLine("Rank is: " + keys.Key + " Country " + keys.Value);
            }

            Console.WriteLine();
            if (Country.ContainsKey(3))
            {
                Country[3] = "CHINA";
            }

            Console.WriteLine("Rank is: " + 3 + " Country " + Country[3]);

            //remove element from given position 
            Country.RemoveAt(1);
            Console.WriteLine();
            foreach (KeyValuePair<int, string> keys in Country)
            {
                Console.WriteLine("Rank is: " + keys.Key + " Country " + keys.Value);
            }
            Console.ReadLine();
        }
    }
}
