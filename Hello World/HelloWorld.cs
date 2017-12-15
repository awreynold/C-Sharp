using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
	class HelloWorld
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World"); //writes out to the console

			Console.WriteLine("Press any key to exit."); //keeps the window open until a key is pressed
			Console.ReadKey();
		}
	}
}
