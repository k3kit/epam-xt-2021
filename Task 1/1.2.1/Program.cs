using System;
using System.Linq;
namespace _1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ВВОД:");
            string input = Console.ReadLine();
            string []word = input.Split(new char[] { ' ', '.', ',', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            int length = word.Aggregate(0,(a, b) => a += b.Length) / word.Length;
            Console.WriteLine(length);
        }
    }
}
