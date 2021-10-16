using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinueStatment
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    Console.WriteLine("continue");
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
