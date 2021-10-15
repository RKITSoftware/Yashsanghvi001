using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10 , number2=20 ;
            int num1 = 25, num2 = 5;

            Console.WriteLine("Arithmatic Operations \n ");
            Console.WriteLine("Number1 + Number2 = " + (number1 + number2));
            Console.WriteLine("Number1 - Number2 = " + (number1 - number2));
            Console.WriteLine("Number1 * Number2 = " +(number1 * number2));
            Console.WriteLine("Number1 / Number2 = " + (number1 / number2));
            Console.WriteLine("Number1 % Number2 = " + (number1 % number2));
            Console.WriteLine("Number1++ = " + number1++);
            Console.WriteLine("Number1-- = " + number1--);

            Console.WriteLine();

            Console.WriteLine("Relational Operations \n");

            if (number1 == number2)
                Console.WriteLine(number1 + " is equal " + number2);
            //not equal 
            if (number1 != number2)
                Console.WriteLine(number1 + " is not equal " + number2);
            //greater than 
            if (number1 > number2)
                Console.WriteLine(number1 + " is greater than " + number2);
            //less than
            if (number1 < number2)
                Console.WriteLine(number1 + " is less than " + number2);
            //greater than or equal
            if (number1 >= number2)
                Console.WriteLine(number1 + " is greater than or equal " + number2);
            //less than or equal
            if (number1 <= number2)
                Console.WriteLine(number1 + " is less than or equal " + number2);

            Console.WriteLine();

            Console.WriteLine("Logical Operations \n");

            //Logical AND  
            if (number1 == 10 && number2 == 20)
                Console.WriteLine("Both condition becomes true");
            //not equal 
            if (number1 == 10 || number2 ==20)
                Console.WriteLine("Any one condition becomes true");
            //greater than 
            if (!(number1 == 10))
                Console.WriteLine("condition becomes false");


            Console.WriteLine();

            Console.WriteLine("Bitwise  Operations \n");

            //Binary AND 
            Console.WriteLine("number1&number2=" + (number1 & number2));
            //Binary OR
            Console.WriteLine("number1|number2=" + (number1 | number2));
            //Binary XOR
            Console.WriteLine("number1=" + (number1 ^ number2));

            Console.WriteLine();
            Console.WriteLine("Ternary  Operations \n");

            var result = num1 > num2 ? "num1 is greater" : "num2 is greater";
            Console.WriteLine(result);

            Console.ReadLine();

        

    }
    }
}
