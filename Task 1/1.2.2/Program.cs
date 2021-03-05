using System;

namespace _1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ВВОД 1: ");
            string inputOne = Console.ReadLine();
            Console.Write("ВВОД 1: ");
            string inputTwo = Console.ReadLine();
            string result = "";

            foreach (char ch in inputOne)
                if (!inputTwo.Contains(ch)) result += ("" + ch);
                else
                {
                    result += ("" + ch + ch);
                }

            Console.WriteLine("ВЫВОД: {0}", result);
        }
    }
}
