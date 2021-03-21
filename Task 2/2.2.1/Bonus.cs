using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._1
{
    class Bonus : GameObj
    {
        public int ShowPositionX => positionX;
        public int ShowPositionY => positionY;

        public Bonus(int wight, int height)
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

        public void TakeBonus(Player player, Bonus bonus, Bot bot)
        {
            if (player.ShowPositionX == bonus.ShowPositionX && player.ShowPositionY == bonus.ShowPositionY)
            {
                Console.Write(" ");
                player.Score += 10;
                player.Hp += 5;
                bonus.AddObject();
            }
        }
    }
}
