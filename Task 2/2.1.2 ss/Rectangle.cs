using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2_ss
{
    class Rectangle : Figure
    {
        public double A;
        public double B;

        public Rectangle(double centerX, double centerY, double lineA, double lineB)
        {
            X = centerX;
            Y = centerY;
            A = lineA;
            B = lineB;
        }

        public override void Show()
        {
            Console.WriteLine("Тип фигуры прямоугольник.{0}" +
                "Центер X: {1}, Y: {2}{0}" +
                "Cторона А: {3}, Cторона B: {4}{0}" +
                "Площадь: {5}, Периметр: {6}", 
                Environment.NewLine,
                X, Y, A, B, Area(), Perimeter());
        }

        public override double Area()
        {
            return A * B;
        }

        public override double Perimeter()
        {
            return 2 * A + B;
        }
    }
}
