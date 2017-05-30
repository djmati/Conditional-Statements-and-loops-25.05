﻿using System;

namespace CaloriesCounter
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var ingredientsCount = int.Parse(Console.ReadLine());
			var calories = 0;

			for (int i = 0; i < ingredientsCount; i++)
			{
				switch (Console.ReadLine().ToLower())
				{
					case "cheese":
						calories += 500;
						break;
					case "tomato sauce":
						calories += 150;
						break;
					case "salami":
						calories += 600;
						break;
					case "pepper":
						calories += 50;
						break;
				}
			}

			Console.WriteLine($"Total calories: {calories}");
		}
	}
}
