using System;

namespace _1._1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            int[,] nums = new int[3, 3];
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)

                for (int j = 0; j < 3; j++)
                    {
                    nums[i, j] = rnd.Next(0, 5);
                    Console.WriteLine($"nums[{i},{j}] = {nums[i, j]}");
                    if ((i+j) % 2==0)
                   
                    {
                        res += nums[i,j];
                    }
                }
           
            Console.WriteLine($"sum {res}");
        }
        
    }
}

