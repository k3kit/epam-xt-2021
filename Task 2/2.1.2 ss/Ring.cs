using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2_ss
{
     class Ring : Circle
    {
        protected double innerRadius;


        public Ring(double x, double y, double radius, double innerRadius) : base(x, y, radius)
        {
            this.innerRadius = innerRadius;
        }

        public override double Area()
        {
            return Math.PI * (Math.Pow(radius, 2) - Math.Pow(innerRadius, 2));
        }

        public double SumLength ()
        {
           return  2 * Math.PI * (radius + innerRadius);
        }
        public override void Show()
        {
            Console.WriteLine("Тип фигуры кольцо.{0}" +
                "Центер X:{1}, Y:{2}{0}" +
                "Внешний радиус:{3}, Внутрений радиус {4}:{0}" +
                "Площадь: {5}", Environment.NewLine,
                X, Y, radius, innerRadius, Area());
        }
    }
}
