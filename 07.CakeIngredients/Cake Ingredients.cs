using System;

namespace CakeIngredients
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var ingredient = Console.ReadLine();
			var ingredientCount = 0;

			while (ingredient != "Bake!")
			{
				Console.WriteLine($"Adding ingredient {ingredient}.");
				ingredientCount++;
				ingredient = Console.ReadLine();
			}

			Console.WriteLine($"Preparing cake with {ingredientCount} ingredients.");
		}
	}
}
