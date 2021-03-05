using System;


namespace _1._1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            int[] nums = new int[8];
            Random rnd = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(-30, 30);
                
                if(nums[i] > 0)
                {
                    res += nums[i];
                }
            }
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("sum: " + res);
        }
    }
}
