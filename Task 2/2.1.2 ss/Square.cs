using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2_ss
{
    class Square : Rectangle
    {
        public Square(double centerX, double centerY, double lineA) : base(centerX, centerY, lineA, lineA)
        {

        }
        public override double Perimeter()
        {
            return 4 * A;
        }
        public override void Show()
        {
            Console.WriteLine("Тип фигуры квадрат.{0}" +
                "Центер X: {1}, Y: {2}{0}" +
                "Cторона А: {3}, Cторона B: {4}{0}" +
                "Площадь: {5}, Периметр: {6}",
                Environment.NewLine,
                X, Y, A, B, Area(), Perimeter());
        }

    }
}
