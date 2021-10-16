using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotoStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

        Loop:

            x++;

            if (x < 10)

            {
                Console.WriteLine(x);

                goto Loop;

            }
            Console.Read();
        }
    }
}
