using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2_ss
{
    class Circle : Figure
    {
        protected double radius;

        public Circle(double x, double y, double radius)
        {
            X = x;
            Y = y;
            this.radius = radius;
        } 

        public override  double Area() => Math.PI * Math.Pow(radius, 2);

        public double LangthCircle() => 2 * Math.PI * radius;

        public override double Perimeter()
        {
            throw new NotImplementedException();
        }

        public override void Show()
        {
            Console.WriteLine("Тип фигуры окружность.{0}" +
                "Центер X:{1}, Y:{2}{0}" +
                "Радиус:{3}, Длина {4}" 
                ,Environment.NewLine,
                X, Y, radius, LangthCircle());
        }

      

        
    }
}
