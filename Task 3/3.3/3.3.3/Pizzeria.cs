using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._3
{
    class Pizzeria
    {
		List<string> orders = new List<string>();
		private const double Margarita = 10.99,
			Sicilian = 15.99,
			Diabola = 12.49,
			FourCheeses = 12.99,
			Carbonara = 9.99;

		public Pizzeria()
		{

		}

		public void Order(Pizza pizza)
		{
			string order = pizza.OrderPizza();
			int orderID = pizza.ShowBuyerID();
			bool payment = false;

			switch (order)
			{
				case "Margarita":
					{
						payment = pizza.PayForPizza(Margarita);
						break;
					}
				case "Sicilian":
					{

						payment = pizza.PayForPizza(Sicilian);
						break;
					}
				case "Diabola":
					{
						payment = pizza.PayForPizza(Diabola);
						break;
					}
				case "Four cheeses":
					{
						payment = pizza.PayForPizza(FourCheeses);
						break;
					}
				case "Carbonara":
					{
						payment = pizza.PayForPizza(Carbonara);
						break;
					}
				default:
					return;
			}

			order = $"Заказ №{orderID} - пицца {order}";

			if (payment)
			{
				Console.WriteLine($"\n{pizza.ShowBuyerName()},пицца будет готова через 8 минут, спасибо за заказ! \n Номер заказа :{orderID}");
				orders.Add(order);
				ShowOrderList();
			}
			else
			{
				Console.WriteLine($"Извините, {pizza.ShowBuyerName()}, на  счету недостаточно средств для оплаты.");
			}
		}

		private void ShowOrderList()
		{
			Console.WriteLine("Список заказов:");
			foreach (var item in orders)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();
		}
	}
}
