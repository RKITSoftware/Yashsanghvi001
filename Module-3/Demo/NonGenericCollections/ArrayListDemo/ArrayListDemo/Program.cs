using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList PersonDetails = new ArrayList();

            //local variable.
            string name = "Yash Sanghvi";
            string endNumber = "12345";

            //created the object of ArrayList.

            //using add method we can add items.
            //items datatype can be anything.
            PersonDetails.Add(name);
            PersonDetails.Add(endNumber);

            Console.WriteLine("Person Details :");
            foreach (var i in PersonDetails)
            {
                Console.WriteLine("{0}", i);
            }
            Console.Read();

        }
    }
}
