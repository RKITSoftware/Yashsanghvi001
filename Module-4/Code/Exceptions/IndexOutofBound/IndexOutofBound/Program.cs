using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOutofBound
{
    class Program
    {
        static void Main(string[] args)
		{           
			int[] arr = { 5, 10, 20, 40, 80 };

			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine(arr[i]);
			}
	
			try
			{

				Console.WriteLine(arr[10]);
				// An exception is thrown

			}
			catch (IndexOutOfRangeException e)
			{
				Console.WriteLine("Exception : " + e.Message);

			}
			Console.Read();
		}
    }
}
