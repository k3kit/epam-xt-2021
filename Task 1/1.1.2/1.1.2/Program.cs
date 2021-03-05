using System;

namespace _1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter num:" );
            int a = int.Parse(Console.ReadLine());
            for( int i = 0; i < a; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
