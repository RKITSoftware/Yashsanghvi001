using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalModifiers
{
    internal class User
    {
        //local variable
        string name;

        //constructor
        public User(string fullName)
        {
            this.name = fullName;
        }
        // display name 
        public void DisplayName()
        {
            Console.WriteLine("User's Name is {0} ", this.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //creating object
            var objUser = new User("Yash");
            objUser.DisplayName();
            Console.Read();
        }
    }
}
