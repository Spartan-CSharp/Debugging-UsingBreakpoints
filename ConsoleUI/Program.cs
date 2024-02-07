using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for ( int i = 1; i < 50; i *= 5 )
			{
				Console.WriteLine($"The value of i is {i}");
			}

			_ = Console.ReadLine();
		}
	}
}
