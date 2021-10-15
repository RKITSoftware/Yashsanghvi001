using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            circle c = new circle(); // value type parameter 
            int number = 10;
            int ans = c.aera(number);
            Console.WriteLine("Aera Of Circle is " + ans);

        program p = new program();
         int num1 = 10;
         int num2 = 20;

        p.display(num1, num2);//num3 is Optional Parameter





            Console.Read();
        }
    }
    class circle

        {
        public int aera(int radius)
        {
            int answer = radius * radius * (22 / 7);
            return answer;
        }
        }
    class program
    {
        public void display(int num1,int num2,int num3=30)
        {
            Console.WriteLine("num1 : {0}", num1);
            Console.WriteLine("num2 : {0}", num2);
            Console.WriteLine("num3 : {0}", num3);
        }

    }
}
