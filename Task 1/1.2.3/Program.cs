using System;

namespace _1._2._3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("ВВОД: ");
            string input = Console.ReadLine();
            string[] word = input.Split(new char[] { ' ', '.', ',', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
            for(int  i = 0; i < word.Length; i++)
            {
                if (word[i] == word[i].ToLower())
                {
                    sum++;
                }
                
            }
            Console.WriteLine("ВЫВОД: "+sum);
        }       
    }
}
