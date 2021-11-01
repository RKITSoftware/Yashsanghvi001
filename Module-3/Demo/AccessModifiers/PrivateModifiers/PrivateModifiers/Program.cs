using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateModifiers
{
	class Name
	{

		// Member name declared as protected
		private string name;

		public void setName(string name)
		{
			this.name = name;
		}
		public string getName()
		{
			return name;
		}
	}

	// class MyName inherits name
	class MyName : Name
	{


		// this shows an error because if accessibility of private string name


	}
	class Program
    {
        static void Main(string[] args)
		{
			Name name = new Name();
			name.setName("Yash Sanghvi");
			Console.WriteLine("Name is:" + name.getName());
			Console.Read();
		}
	}
}
