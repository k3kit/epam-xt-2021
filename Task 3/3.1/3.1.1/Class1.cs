using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1._1
{
    class Class1
    {   
        readonly List<Player> players = new List<Player>();
        private int Round = 1;
        private int PlayersCount;
        private int Delete;
        

        public void Start()
        {
            string value;
            Console.Write("Введите N ");
            value = Console.ReadLine();
            if(int.TryParse(value,out int number))
            {
                PlayersCount = Convert.ToInt32(value);
            }


            Console.Write("Введите, какой по счету человек будет" +
                " вычеркнут каждый раунд: ");
            value = Console.ReadLine();
            if (int.TryParse(value, out number))
            {
               Delete = Convert.ToInt32(value);
            }


            for(int i = 0; i< PlayersCount; i++)
            {
                players.Add(new Player());
            }


            Console.WriteLine($"Сгенерирован круг людей. Начинаем вычеркивать каждого {Delete}.");


            while (players.Count >= Delete)
            {
                for(int i = Delete -1; i<players.Count; i += Delete)
                {
                    if (i < players.Count)
                    {
                        players.RemoveAt(i);
                        Console.WriteLine($"Раунд {Round++}. Вычеркнут человек. Людей осталось: {players.Count}");
                    }
                }
            }
            Console.WriteLine("Игра окончена. Невозможно вычеркнуть больше людей");
        }


        public Class1()
        {
        }
        private class Player
        {
        }
    }

}
