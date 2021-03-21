using System;


namespace _2._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int width = 25;
            const int height = 10;
            Console.CursorVisible = false;
            Map map = new Map();
            Player player = new Player();
            Bonus bonus = new Bonus(width, height);
            Bot bot = new Bot(width, height);
            
            while (player.Hp > 0)
            {
                bonus.TakeBonus(player, bonus,bot);
                bot.BBot(player, bot);
                map.Draw(width, height, player, bonus, bot);
                player.Move(width, height);
            }

            Console.WriteLine("Game Over");
            Console.ReadKey(true);
        }
    }
}