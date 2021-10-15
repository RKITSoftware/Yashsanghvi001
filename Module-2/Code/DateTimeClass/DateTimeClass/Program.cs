using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2021, 1, 1);
            Console.WriteLine(date1.ToString());
            DateTime date2 = new DateTime(2021, 2, 3, 12, 20, 50);
            Console.WriteLine(date2.ToString());
            Console.WriteLine();

            //DayOfWeek
            Console.WriteLine(date2.DayOfWeek);

            //DayOfYear 
            Console.WriteLine(date2.DayOfYear);

            //TimeOfDay
            Console.WriteLine(date2.TimeOfDay);

            //Today  
            Console.WriteLine(DateTime.Today);

            //Now    
            Console.WriteLine(DateTime.Now);

            Console.WriteLine();

            // Adding days to a date  
            DateTime today = DateTime.Now;
            DateTime newDate = today.AddDays(30);
            Console.WriteLine(newDate);

            Console.Read();




        }
    }
}
