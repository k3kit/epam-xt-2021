using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ВВОД: ");
            string input = Console.ReadLine();
            string[] word = input.Split(new char[] { ' ', '.', ',', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            string[] CloneWords = new string[word.Length];
            int[] WordsRepeat  = new int[word.Length];
            int count = 0;

            for(int i = 0; i < WordsRepeat.Length; i++)
            {
                WordsRepeat[i] = 1;
            }
            

            for(int i = 0; i < word.Length; i++)
            {
                CloneWords[i] = word[i].ToLower();

            }


            for(int i = 0; i<CloneWords.Length; i++)
            {
                if(CloneWords[i] != "")
                {
                    for(int j = i+1; j< CloneWords.Length; j++)
                    {
                        if (CloneWords[i] == CloneWords[j])
                        {
                            WordsRepeat[i]++;
                            CloneWords[j] = "";
                        }
                    }
                }
            }


            for(int i= 0; i < word.Length; i++)
            {
                Console.WriteLine($"Слово - {word[i]}, в тексте встречается {WordsRepeat[i]} раз.");
            }

            count = WordsRepeat.Max();
            for (int i = 0; i < WordsRepeat.Length; i++)
            {
                if (WordsRepeat[i] == count)
                {
                    Console.WriteLine($"Любимое слово - {word[i]}, в тексте встречается {count} раз.");
                    Console.ReadLine();
                }
            }
        }
    }
}
