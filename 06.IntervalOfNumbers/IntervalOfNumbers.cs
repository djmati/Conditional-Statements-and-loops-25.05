using System;

namespace IntervalOfNumbers
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var num1 = int.Parse(Console.ReadLine());
			var num2 = int.Parse(Console.ReadLine());

			if (num1 > num2)
			{
				for (int i = num2; i <= num1; i++)
				{
					Console.WriteLine(i);
				}
			}
			else if (num2 > num1)
			{
				for (int i = num1; i <= num2; i++)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
