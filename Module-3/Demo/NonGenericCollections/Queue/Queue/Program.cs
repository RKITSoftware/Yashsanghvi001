using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Name = new Queue();
            Name.Enqueue("Yash");
            Name.Enqueue("Sanghvi");
            Name.Enqueue(20);

            foreach (var elem in Name)
            {
                Console.WriteLine(elem);
            }
            
            Console.WriteLine("top is: " + Name.Peek());

            Console.WriteLine("Does it contain no. 20:" + Name.Contains(20));

            Name.Dequeue();
            Console.WriteLine("Does it contain Yash: " + Name.Contains("Yash"));
            Console.ReadLine();
        }
    }
}
