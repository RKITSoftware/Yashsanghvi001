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
         Console.WriteLine();

        // Declare the Jagged Array of four elements
        int[][] jagged_arr = new int[4][];
  
        // Initialize the elements
        jagged_arr[0] = new int[] {1, 2, 3, 4};
        jagged_arr[1] = new int[] {11, 34, 67};
        jagged_arr[2] = new int[] {89, 23};
        jagged_arr[3] = new int[] {0, 45, 78, 53, 99};
  
        // Display the array elements:
        for (int n = 0; n < jagged_arr.Length; n++) {
  
            // Print the row number
            System.Console.Write("Row({0}): ", n);
  
            for (int k = 0; k < jagged_arr[n].Length; k++) {
  
                // Print the elements in the row
                System.Console.Write("{0} ", jagged_arr[n][k]);
            }
            System.Console.WriteLine();
        }

        Console.ReadLine();
        }
    }
}
