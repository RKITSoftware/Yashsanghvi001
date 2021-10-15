using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstration of 1D array \n");

            // created and initialize  1-D Array
            int[] intArray = new int[] { 1, 2, 3, 4, 5};
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]); // print element
            }

            Console.WriteLine("\nDemonstration of 2D array \n");

            // created and initialize  2-D Array
            int[,] array1 = new int[3, 2] { { 5, 10 }, { 10, 20 }, { 20, 40 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(array1[i, j] + " "); // print element
                }
                Console.WriteLine();

            }

            Console.ReadLine();
        }
    }
}
