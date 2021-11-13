using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    enum months
    { // enum by default starts form 0 
        January,  //0
        February, //1
        March,    //2
        April,    //3
        May,      //4
        June =10,  // explicitly defined value of June is 10
        July    

    }




    class Program
    {
        static void Main(string[] args)
        {
            // getting the integer values of data members..
            Console.WriteLine("The value of January in month " +
                              "enum is " + (int)months.January);
            Console.WriteLine("The value of February in month " +
                              "enum is " + (int)months.February);
            Console.WriteLine("The value of March in month " +
                              "enum is " + (int)months.March);
            Console.WriteLine("The value of April in month " +
                              "enum is " + (int)months.April);
            Console.WriteLine("The value of June in month " +
                              "enum is " + (int)months.June);

            Console.ReadLine();
        }
    }
}
