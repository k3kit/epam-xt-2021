using System;

namespace _1._1
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] nums = new int[8];
            Random rnd = new Random();
            for (int i = 0; i < nums.Length; i++)

                nums[i] = rnd.Next(0, 30);
            Console.WriteLine("рандомный массив");
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
            int max = nums[0];
            int min = nums[0];
            for(int i = 1; i<nums.Length; i++)
            {
                if (nums[i] > max) max = nums[i];
                if (nums[i] < min) min = nums[i];
            }
            Console.WriteLine( "максимальный элемент: " + max + "," + "минимальный элемент: " + min);

            int temp;
            for(int i = 0; i< nums.Length; i++)
            {
                for(int j = i+1; j <nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            Console.WriteLine("отсортированный массив ");
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
