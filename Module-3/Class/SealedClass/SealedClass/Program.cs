using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    sealed public class PersonalInfo
    {
        public void Firstname()
        {
            Console.WriteLine("Yash");
            Console.ReadLine();
        }
        public void Lastname()
        {
            Console.WriteLine("Sanghvi");
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PersonalInfo objPersonalInfo = new PersonalInfo();
            objPersonalInfo.Firstname();
            objPersonalInfo.Lastname();
        }
    }
}
