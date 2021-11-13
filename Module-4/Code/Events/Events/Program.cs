using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate string EventDemo(string str);

    class EventProgram
    {
        event EventDemo MyEvent;

        public EventProgram()
        {
            this.MyEvent += new EventDemo(this.WelcomeUser);
        }
        public string WelcomeUser(string username)
        {
            return "Welcome To " + username;
        }
        static void Main(string[] args)
        {
            EventProgram objEvent = new EventProgram();
            string result = objEvent.MyEvent("RKIT");
            Console.WriteLine(result);
            Console.Read();
        }
    }
}

