using System;

namespace ChooseADrink2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var profession = Console.ReadLine();
			var quantity = int.Parse(Console.ReadLine());
			double price = 0;
			var total = price * quantity;

			if (profession == "Athlete")
			{
				price = 0.70;
				total = price * quantity;
			}
			else if (profession == "Businessman" || profession == "Businesswoman")
			{
				price = 1.00;
				total = price * quantity;
			}
			else if (profession == "SoftUni Student")
			{
				price = 1.70;
				total = price * quantity;
			}
			else
			{
				price = 1.20;
				total = price* quantity;
			}
			Console.WriteLine($"The {profession} has to pay {total:F2}.");
		}
	}
}
