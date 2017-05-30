using System;

namespace RestaurantDiscount
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var people = int.Parse(Console.ReadLine());
			var package = Console.ReadLine();
			var re = 0.00;
			var packageDiscount = 0.00;
			var hallPrice = 0.00;
			var total = hallPrice + re;
			double perPerson = (total - (total * packageDiscount / 100)) / people;

			if (package == "Normal")
			{
				re = 500;
				packageDiscount = 5;
				if (people <= 50)
				{
					var hallType = "Small Hall";
					hallPrice = 2500;
					total = hallPrice + re;
					perPerson = (total - (total * packageDiscount / 100)) / people;
					Console.WriteLine($"We can offer you the {hallType}");
					Console.WriteLine($"The price per person is {perPerson:F2}$");
				}
				else if (people > 50 && people <= 100)
				{
					var hallType = "Terrace";
					hallPrice = 5000;
					total = hallPrice + re;
					perPerson = (total - (total * packageDiscount / 100)) / people;
					Console.WriteLine($"We can offer you the {hallType}");
					Console.WriteLine($"The price per person is {perPerson:F2}$");
				}
				else if (people > 100 && people <= 120)
				{
					var hallType = "Great Hall";
					hallPrice = 7500;
					total = hallPrice + re;
					perPerson = (total - (total * packageDiscount / 100)) / people;
					Console.WriteLine($"We can offer you the {hallType}");
					Console.WriteLine($"The price per person is {perPerson:F2}$");
				}
				else if (people >120)
				{
					Console.WriteLine("We do not have an appropriate hall.");
				}
			}
			else if (package == "Gold")
			{
				re = 750;
				packageDiscount = 10;
				if (people <= 50)
				{
					var hallType = "Small Hall";
					hallPrice = 2500;
					total = hallPrice + re;
					perPerson = (total - (total * packageDiscount / 100)) / people;
					Console.WriteLine($"We can offer you the {hallType}");
					Console.WriteLine($"The price per person is {perPerson:F2}$");
				}
				else if (people > 50 && people <= 100)
				{
					var hallType = "Terrace";
					hallPrice = 5000;
					total = hallPrice + re;
					perPerson = (total - (total * packageDiscount / 100)) / people;
					Console.WriteLine($"We can offer you the {hallType}");
					Console.WriteLine($"The price per person is {perPerson:F2}$");
				}
				else if (people > 100 && people <= 120)
				{
					var hallType = "Great Hall";
					hallPrice = 7500;
					total = hallPrice + re;
					perPerson = (total - (total * packageDiscount / 100)) / people;
					Console.WriteLine($"We can offer you the {hallType}");
					Console.WriteLine($"The price per person is {perPerson:F2}$");
				}
				else if (people >120)
				{
					Console.WriteLine("We do not have an appropriate hall.");
				}
			}
			else if (package == "Platinum")
			{
				re = 1000;
				packageDiscount = 15;
				if (people <= 50)
				{
					var hallType = "Small Hall";
					hallPrice = 2500;
					total = hallPrice + re;
					perPerson = (total - (total * packageDiscount / 100)) / people;
					Console.WriteLine($"We can offer you the {hallType}");
					Console.WriteLine($"The price per person is {perPerson:F2}$");
				}
				else if (people > 50 && people <= 100)
				{
					var hallType = "Terrace";
					hallPrice = 5000;
					total = hallPrice + re;
					perPerson = (total - (total * packageDiscount / 100)) / people;
					Console.WriteLine($"We can offer you the {hallType}");
					Console.WriteLine($"The price per person is {perPerson:F2}$");
				}
				else if (people > 100 && people <= 120)
				{
					var hallType = "Great Hall";
					hallPrice = 7500;
					total = hallPrice + re;
					perPerson = (total - (total * packageDiscount / 100)) / people;
					Console.WriteLine($"We can offer you the {hallType}");
					Console.WriteLine($"The price per person is {perPerson:F2}$");
				}
				else if (people >120)
				{
					Console.WriteLine("We do not have an appropriate hall.");
				}
			}

		}
	}
}
