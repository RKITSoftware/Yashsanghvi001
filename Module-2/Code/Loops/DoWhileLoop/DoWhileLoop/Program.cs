using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            do // do-while loop
            {
                Console.WriteLine(number++);
            } while (number <= 5);
            Console.Read();
        }
    }
}
