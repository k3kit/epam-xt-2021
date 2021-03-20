using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2_ss
{
     class Line : Figure
    {
        private double start_X;
        private double start_Y;
        private double end_X;
        private double end_Y;

        public Line (double start_X, double start_Y, double end_X, double end_Y)
        {
            this.start_X = start_X;
            this.start_Y = start_Y;
            this.end_X = end_X;
            this.end_Y = end_Y;
        }
        public double Length() => Math.Sqrt(Math.Pow(start_X - end_X, 2) + Math.Pow(start_Y - end_Y, 2));

        public override double Perimeter()
        {
            throw new NotImplementedException();
        }

        public override void Show()
        {
            Console.WriteLine("Тип фигуры Линия {1} Длина: {0}",
                Length(), Environment.NewLine);
        }

        public override double Area()
        {
            throw new NotImplementedException();
        }
    }
}
