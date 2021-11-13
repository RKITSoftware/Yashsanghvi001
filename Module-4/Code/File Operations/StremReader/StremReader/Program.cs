using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StremReader
{
    class Program
    {
        public void Data()
        {
            StreamReader objReader = new StreamReader("C://Users//yashs//Desktop//Module - 4//code//File Operations//Demo_Duplicate.txt");//it will read from the file given in the location

            Console.WriteLine("Text in the file is :");
            //this takes user input in string variable
            string str = objReader.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = objReader.ReadLine();
            }
            objReader.Close();//stream is closed

        }
        static void Main(string[] args)
        {
            Program objProgram = new Program();
            objProgram.Data();

            Console.Read();
        }
    }
}
