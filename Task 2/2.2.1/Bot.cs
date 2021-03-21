using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._1
{
    class Bot : GameObj
    {
        public int ShowPositionX => positionX;
        public int ShowPositionY => positionY;
        public Bot(int wight, int height)
        {
            this.wigth = wight;
            this.height = height;
            AddObject();
        }

        public override void AddObject()
        {
            positionX = rnd.Next(1, wigth - 2);
            positionY = rnd.Next(1, height - 2);
        }

        public bool Draw(int i, int j)
        {
            if (i == positionY && j == positionX)
            {
                return true;
            }
            return false;
        }

        public void BBot(Player player, Bot bot)
        {
            if (player.ShowPositionX == bot.ShowPositionX && player.ShowPositionY == bot.ShowPositionY)
            {
                Console.Write(" ");
                player.Hp -= 5;
                bot.AddObject();
            }
        }
    }
}
