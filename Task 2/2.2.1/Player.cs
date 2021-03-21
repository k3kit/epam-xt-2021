using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._1
{
	class Player : Person
	{
		protected int hp;
		public int Score { get; set; } = 0;
		public int Hp { get; set; } = 20;
		public int ShowPositionX => positionX;
		public int ShowPositionY => positionY;
		

		public Player()
		{
			positionX = 3;
			positionY = 3;
		}

		public Player(int posX, int posY)
		{
			positionX = posX;
			positionY = posY;
		}

		
		public override void Move(int width, int height)
		{
			var key = Console.ReadKey();
			switch (key.Key)
			{
				case ConsoleKey.UpArrow:
					{
						if (positionY > 0)
						{
							positionY--;
						}
					}
					break;
				case ConsoleKey.DownArrow:
					{
						if (positionY < height - 1)
						{
							positionY++;
						}
					}
					break;
				case ConsoleKey.LeftArrow:
					{
						if (positionX > 0)
						{
							positionX--;
						}
					}
					break;
				case ConsoleKey.RightArrow:
					{
						if (positionX < width - 2)
						{
							positionX++;
						}
					}
					break;
				default:
					break;
			}
		}

		public bool Draw(int i, int j)
		{
			if (i == positionY && j == positionX)
			{
				return true;
			}
			return false;
		}
	}
}


