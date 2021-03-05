using System;

namespace Task_1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("enter b:");
            int b = int.Parse(Console.ReadLine());

            if (a > 0 & b > 0)
            {
                Console.WriteLine(a*b);
            }
            else
            {
                Console.WriteLine("err");
            }

        }
    }
}
