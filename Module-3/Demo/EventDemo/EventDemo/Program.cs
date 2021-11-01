using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{    //declare a 'MyDel' delegate 
    public delegate string MyDel(string str);
    class Event_demo
    {
        //declare the 'MyEvent' event of delagate 'MyDel'
        event MyDel MyEvent;
        public Event_demo()
        {
            this.MyEvent += new MyDel(this.WelcomeUser);
        }
        public string WelcomeUser(string username)
        {
            return "Hello, Welcome" + username + "To RKIT Softwere";
        }
    }
        class Program
    {
        static void Main(string[] args)
            {            //creating a object of EventProgram
                Event_demo objEvent = new Event_demo();
                string result = objEvent.MyEvent("Yash Sanghvi");
                Console.WriteLine(result);
                Console.Read();
            }
    }
}
