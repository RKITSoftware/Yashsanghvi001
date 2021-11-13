using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividedByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 33, 0, 22, 10 };

            try
            {

                // Try to generate an exception
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] / arr[i + 1]);
                }
            }

            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine("Exception:" + e.Message);
            }

            // Catch for attempt to divide by zero
            catch (DivideByZeroException e)
            {

                Console.WriteLine("Exception:" + e.Message);
            }

            finally
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("{0} ", arr[i]);
                }
            }
            Console.Read();
        }
    }
}
