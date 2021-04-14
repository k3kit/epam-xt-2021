using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("ВВОД: ");

			string inputString = Console.ReadLine();
			if (inputString.Length == 0)
			{
				throw new ArgumentException();
			}

			Regex RussianRegex = new Regex(@"[a-z]|[0-9]|([!@#$%^&*()_+\-=?.,\\|\/№;:])", RegexOptions.IgnoreCase);
			Regex EngRegex = new Regex(@"[а-я]|[0-9]|([!@#$%^&*()_+\-=?.,\\|\/№;:])", RegexOptions.IgnoreCase);
			Regex NumRegex = new Regex(@"[а-я]|[a-z]|([!@#$%^&*()_+\-=?.,\\|\/№;:])", RegexOptions.IgnoreCase);

			MatchCollection RuMatches = RussianRegex.Matches(inputString);
			MatchCollection EngMatches = EngRegex.Matches(inputString);
			MatchCollection NumMatches = NumRegex.Matches(inputString);

			if (RuMatches.Count == 0)
			{
				Console.WriteLine("Russian");
			}
			else if (EngMatches.Count == 0)
			{
				Console.WriteLine("English");
			}
			else if (NumMatches.Count == 0)
			{
				Console.WriteLine("Number");
			}
			else
			{
				Console.WriteLine("Mixed");
			}
			Console.ReadKey();
		}
    }
}
