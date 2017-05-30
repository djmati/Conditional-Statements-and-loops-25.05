using System;

namespace CountTheIntegers
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var integerCount = 0;
			while (true)
			{
				try
				{
					int.Parse(Console.ReadLine());
					integerCount++;
				}
				catch (OverflowException)
				{
					break;
				}
				catch (FormatException)
				{
					break;
				}
			}
			Console.WriteLine(integerCount);
		}
	}
}
