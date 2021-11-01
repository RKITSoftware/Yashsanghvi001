using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
 {

    class Program
    {
        static void Main(string[] args)
        {           
            // Creating a List of integers 
            List<int> mylist = new List<int>();
            for (int j = 1; j < 10; j++)
            {
                mylist.Add((j + (j-1)));
            }
            // Displaying items of mylist
            foreach (int items in mylist)
            {
                Console.Write(items + " ");
            }
            Console.WriteLine();
            Console.WriteLine(mylist.Contains(13));
            mylist.Remove(5);
            foreach (int items in mylist)
            {
                Console.Write(items + " ");
            }
            Console.Read();

        }
    }
}
