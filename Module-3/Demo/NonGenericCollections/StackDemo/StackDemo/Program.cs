using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack Name = new Stack();
            Name.Push("Yash");
            Name.Push("Sanghvi");
            Name.Push(20);

            foreach (var elem in Name)
            {
                Console.WriteLine(elem);
            }

            Console.WriteLine("top is: " + Name.Peek());

            Console.WriteLine("Does it contain no. 20:" + Name.Contains(20));

            Name.Pop();
            Console.WriteLine("Does it contain Yash: " + Name.Contains("Yash"));
            Console.ReadLine();
        }
    }
}
