using System;

namespace _1._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter num:");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {

                for(int j = a; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i*2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}