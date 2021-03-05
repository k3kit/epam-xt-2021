using System.Collections.Generic;
using System;

namespace _1._1._6
{
	
    class Program
    {
        static void Main(string[] args)
        {
            string str = "None";
            string count = "";
            while (count != "4")
            {
                Console.Write("Параметры надписи: {0}\n", str);
                if (str == "None")
                {
                    str = "";
                }
                Console.Write("Введите:\n\t1: Bold\n\t2: Italic\n\t3: Underline\n");
                count = Console.ReadLine();

                switch (count)
                {

                    case "1":
                        if (str.Contains("Bold"))
                        {
                            str = str.Replace("Bold, ", "");
                        }
                        else
                        {
                            str = str.Insert(str.Length, "Bold, ");
                        }
                        break;
                    case "2":
                        if (str.Contains("Italic"))
                        {
                            str = str.Replace("Italic, ", "");
                        }
                        else
                        {
                            str = str.Insert(str.Length, "Italic, ");
                        }
                        break;
                    case "3":
                        if (str.Contains("Underline"))
                        {
                            str = str.Replace("Underline, ", "");
                        }
                        else
                        {
                            str = str.Insert(str.Length, "Underline, ");
                        }
                        break;
                }
                if (str == "")
                {
                    str = "None";
                }

            }


        }
    }
}
