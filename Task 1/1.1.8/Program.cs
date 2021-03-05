using System;

namespace _1._1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] nums = new int[5,5,5];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            
                for (int j = 0; j< 5; j++)
                
                    for(int k = 0; k < 5; k++)
                    {
                        nums[i, j, k] = rnd.Next(0, 30);
                    }

            Console.WriteLine("рандомный массив");
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < 5; i++)

                for (int j = 0; j < 5; j++)

                    for (int k = 0; k < 5; k++)
                    {
                        if( nums [i, j, k] > 0)
                        {
                            nums[i, j, k] = 0;
                            Console.Write(" "+nums[i, j, k]);
                        }
                    }

        }
    }
}
