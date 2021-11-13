using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefineExceptions
{
    class MyException : Exception
    {
        public MyException(string Message) : base(Message) { }
        public MyException() { }
        public MyException(string Message, Exception inner) : base(Message, inner) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 50;
            int k = a / b;
            try
            {
                if (k < 10)
                {
                    throw new MyException("value of k is less than 10");
                }
            }
            catch (MyException e)
            {
                Console.WriteLine("Caught My Exception");
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }
}
