using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
                var Country = new Hashtable()
            {
                {"India","Usa,Canada" },
                {"UK","France,Rassia,China" }
            };
                Country.Add("SA", "Maxico,SriLanka,Ukarin");

                foreach (DictionaryEntry de in Country)
                {
                    Console.WriteLine("Key: " + de.Key + " Value: " + de.Value);
                }

                Console.WriteLine();
                if (Country.ContainsKey("USA"))
                {
                    Country.Remove("USA");
                }
                foreach (DictionaryEntry de in Country)
                {
                    Console.WriteLine("Key: " + de.Key + " Value: " + de.Value);
                }
            Console.ReadLine();
            }
    }
}
