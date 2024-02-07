using System;

namespace ConsoleUI
{
	internal class Program
	{
		private static void Main()
		{
			for ( int i = 1; i < 50; i *= 5 )
			{
				Console.WriteLine($"The value of i is {i}");
			}

			_ = Console.ReadLine();
		}
	}
}
