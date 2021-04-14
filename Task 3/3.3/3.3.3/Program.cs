using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
			string name = "";
			string pizza = "";
			int money = 100;

			var pizzeria = new Pizzeria();
			var buyer1 = new Pizza("Leonardo", 20);
			var buyer2 = new Pizza("Rafael", 20);
			var buyer3 = new Pizza("Donatello", 20);
			var buyer4 = new Pizza("Michelangelo", 20);

			pizzeria.Order(buyer1);
			pizzeria.Order(buyer2);
			pizzeria.Order(buyer3);
			pizzeria.Order(buyer4);

			Console.WriteLine("{0}Здравствуйте, вы хотите сделать заказ?{0}1.Да{0}2.Нет", Environment.NewLine);
				
			if (Console.ReadLine() == "1")
			{
				Console.Write("Как вас зовут? ");
				while (name.Length == 0)
				{
					name = Console.ReadLine();
				}

				Console.WriteLine("Здравствуйте {1}!{0} Какую пиццу вы хотите заказать? {0}1.Margarita = 10.99${0}2.Sicilian = 15.99${0}3.Diabola = 12.49$ {0}4.Four Cheeses = 12.99${0}5.Carbonara = 9.99$", Environment.NewLine, name);
					
				switch (Console.ReadLine())
				{
					case "1":
						{
							pizza = "Margarita";
							break;
						}
					case "2":
						{
							pizza = "Sicilian";
							break;
						}
					case "3":
						{
							pizza = "Diabola";
							break;
						}
					case "4":
						{
							pizza = "Four Cheeses";
							break;
						}
					case "5":
						{
							pizza = "Carbonara";
							break;
						}
					default:
						break;
				}

				var newBuyer = new Pizza(name, money, pizza);
				pizzeria.Order(newBuyer);

				name = "";
				pizza = "";
			}
			else
			{
				Console.WriteLine("Спасибо за визит");
			}
			Console.ReadKey();
		}
    }
}
