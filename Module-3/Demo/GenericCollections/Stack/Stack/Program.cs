using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
          
                Stack<int> numbers = new Stack<int>();
                for (int i = 0; i < 8; i++)
                {
                    numbers.Push(i);
                }
                Console.WriteLine("Total Number in stack: " + numbers.Count);

                Console.WriteLine("Does numbers contain 4: " + numbers.Contains(4));

                numbers.Pop();
               

                Console.WriteLine("Does numbers contain 8: " + numbers.Contains(8));

                Console.WriteLine("Element at the top is: " + numbers.Peek());

                Console.ReadLine();
            }
        }
}
