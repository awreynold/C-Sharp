using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	class Calculator
	{
		static void Main(string[] args)
		{
			bool exit = false;

			while (!exit)
			{
				Console.WriteLine("Enter the first value:");
				String value1 = Console.ReadLine();

				Console.WriteLine("Enter the operator:");
				String op = Console.ReadLine();

				Console.WriteLine("Enter the second value:");
				String value2 = Console.ReadLine();

				Console.WriteLine(Calculate(value1, value2, op));

				Console.WriteLine("Do you have another calculation (y/n):");
				String repeat = Console.ReadLine();

				if (repeat.Equals("n")) {
					exit = true;
				}
			}
		}

		private static String Calculate(String value1, String value2, String op)
		{
			String res = null;
			int? total = null;

			switch (op)
			{
				case "+":
					total = CalcFunctions.addFunction(Int32.Parse(value1), Int32.Parse(value2));
					break;
				case "-":
					total = CalcFunctions.minusFunction(Int32.Parse(value1), Int32.Parse(value2));
					break;
				case "*":
					total = CalcFunctions.multipleFunction(Int32.Parse(value1), Int32.Parse(value2));
					break;
				case "/":
					total = CalcFunctions.divideFunction(Int32.Parse(value1), Int32.Parse(value2));
					break;
				default:
					total = null;
					break;
			}

			if (total != null)
			{
				res = value1 + " " + op + " " + value2 + " = " + total;
			}
			else
			{
				res = null;
			}
			return res;
		}
	}
}
