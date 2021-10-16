using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakStatement
{
    class Program
    {
        static void Main(string[] args)
        {
    
            for (int number = 0; number < 10; number++)
            {
                if (number == 4)
                {
                    break;
                }
                Console.WriteLine(number);
            }
            Console.Read();
        }
    }
}
