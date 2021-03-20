using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2_ss
{
    class Triangle : Figure
    {
        private Line A;
        private Line B;
        private Line C;

        public Triangle(double x, double y, Line a, Line b, Line c)
        {
            X = x;
            Y = y;
            A = a;
            B = b;
            C = c;
        }
        public override double Area() => Math.Sqrt((Perimeter() / 2) * (Perimeter() / 2 - A.Length()) * (Perimeter() / 2 - B.Length()) * (Perimeter() / 2 - C.Length()));

        public override double Perimeter()
        {
            return A.Length() + B.Length() + C.Length();
        }

        public override void Show()
        {
            Console.WriteLine("Тип фигуры треугольник.{0}" +
              "Центер X: {1}, Y: {2}{0}" +
              "Cторона А: {3}, Cторона B: {4}, Cторона C: {5}{0}" +
              "Площадь: {6}, Периметр: {7}",
              Environment.NewLine,
              X, Y, A.Length(), B.Length(), C.Length(), Area(), Perimeter());
        }
    }
}

