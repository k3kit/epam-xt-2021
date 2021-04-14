using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._3
{
    class Pizza
    {
		private static Random rng = new Random();
		private string name;
		private int userID;
		private double money;
		private string pizza = "";


		public Pizza(string Name, double Money)
		{
			name = Name;
			money = Money;
			userID = rng.Next(1, 20);
		}


		public Pizza(string Name, double Money, string Pizza)
		{
			name = Name;
			money = Money;
			pizza = Pizza;
			userID = rng.Next(1, 20);
		}

		public string OrderPizza()
		{
			if (pizza.Length == 0)
			{
				switch (rng.Next(1, 6))
				{
					case 1:
						{
							return "Margarita";
						}
					case 2:
						{

							return "Sicilian";
						}
					case 3:
						{

							return "Diaboli";
						}
					case 4:
						{

							return "FourCheeses";
						}
					case 5:
						{

							return "Carbonara";
						}
					default:
						return "No pizza";
				}
			}
			else
			{
				return pizza;
			}
		}
		

		public bool PayForPizza(double pizzaPrice)
		{
			if (money - pizzaPrice >= 0)
			{
				money -= pizzaPrice;
				return true;
			}
			else
			{
				return false;
			}
		}


		public string ShowBuyerName() => name;
		public int ShowBuyerID() => userID;
		public double ShowBuyerMoney() => money;

	}
}
