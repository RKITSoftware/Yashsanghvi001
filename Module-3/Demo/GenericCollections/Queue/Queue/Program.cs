using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            for (int i = 1; i < 6; i++)
            {
                numbers.Enqueue(i);

            }

            Console.WriteLine(string.Join("", numbers));

            Console.WriteLine("No. of Elements:" + numbers.Count); // checking number of elements

            Console.WriteLine( numbers.Contains(5));
          
            Console.WriteLine("Element popped:" + numbers.Dequeue());

            Console.WriteLine("Element at the top:" + numbers.Peek()); // top element on queue

            Console.ReadLine();
        }
    }
}
