using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._1
{
    class Map
    {
        public void Draw(int width, int height, Player player, Bonus bonus,Bot bot)
        {
            Console.Clear();
            for (int i = 0; i < width + 1; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j == 0 || j == width - 1)
                    {
                        Console.Write("#");
                    }
                    if (player.Draw(i, j))
                    {
                        Console.Write("P");
                    }
                    else if (bonus.Draw(i, j))
                    {
                        Console.Write("B");
                    }
                    else if (bot.Draw(i, j))
                    {
                        Console.Write("E");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }


            for (int i = 0; i < width + 1; i++)
            {
                Console.Write("#");
            }


            Console.WriteLine();
            Console.WriteLine($"Score: {player.Score}");
            Console.WriteLine($"Hp: {player.Hp}");
            Console.WriteLine("{0}P-player;{0}E-enemy;{0}B-bonus;", Environment.NewLine);
                
                
        }
    }
}
