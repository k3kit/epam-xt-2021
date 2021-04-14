using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
			double[] array = new double[] { 1, 2, 3, 3, 3, 6, 7, 8};
			array = array.Modify(n => n * n).ToArray();
			foreach (var item in array)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine("сумма всех элементов - {0}.", array.SumOfElements());

			Console.WriteLine("среднего значения в массиве - {0}.", Math.Round(array.AvarageOfElements(), 2));

			Console.WriteLine("самого часто повторяемого элемента - {0}.", array.RepeatedElement());
			Console.ReadLine();
		}
    }
}
