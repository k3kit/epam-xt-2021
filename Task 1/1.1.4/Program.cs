using System;

namespace _1._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter num:");
            int a = int.Parse(Console.ReadLine());

            for(int k = 1; k <= a ; k++)
            {
                for (int i = 0; i <= k; i++)
                {

                    for (int j = a; j > i; j--)
                    {
                        Console.Write(" ");
                    }
                        for (int j = 0; j <= i * 2; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                }
            }

        }
    }
}