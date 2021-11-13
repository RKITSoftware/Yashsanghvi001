using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StremWriterDemo
{
    class Program
    {
        public void Data()
        {
            // write in the file given in the location
            StreamWriter objWriter = new StreamWriter("C: //Users//yashs//Desktop//Module - 4//code//File Operations//StreamWriter.txt");

            Console.WriteLine("Enter text to write in demo file:");
            string str = Console.ReadLine();
            objWriter.WriteLine(str);
            objWriter.Flush();
            //closes the stream and stream object
            objWriter.Close();
        }
        static void Main(string[] args)
        {
            Program objProgram = new Program();
            objProgram.Data();
            Console.Read();
        }
    }
}
