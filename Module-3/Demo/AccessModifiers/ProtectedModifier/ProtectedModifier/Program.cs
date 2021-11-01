using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedModifier
{
	class Name
	{

		// Member name declared as protected
		protected string name = "Yash Sanghvi";

		public Name()
		{
			name = "Yash Sanghvi";
		}
	}

	// class MyName inherits name
	class MyName : Name
	{

		public string getName()
		{
			return name;
		}
	}
	class Program
    {
        static void Main(string[] args)
        {
			Name obj1 = new Name();
			MyName obj2 = new MyName();

			// Displaying the value of name
			Console.WriteLine("Name is : {0}", obj2.getName());
			Console.Read();
		}
	}
}
