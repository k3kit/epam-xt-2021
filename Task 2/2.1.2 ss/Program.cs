using System;
using System.Collections.Generic;
namespace _2._1._2_ss
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> Flist = new List<Figure>();
            while (true)
            {
                Console.WriteLine("Выберите действие {0} 1.Добавить фигуру{0} 2.Вывести фигуры{0} 3.Очистить холст {0} 4.Выход",
                Environment.NewLine);

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine();
                        Figure Input = InputFigure();
                        Flist.Add(Input);
                        break;
                    case "2":
                        Console.WriteLine();
                        Figure Show = ShowFigures();
                        Flist.Add(Show);
                        break;
                    case "3":
                        Console.WriteLine();
                        Figure c = Clear();
                        Flist.Add(c);
                        break;
                    case "4":
                        Console.WriteLine();
                        break;
                }
            }


            Figure ShowFigures()
            {
                if (Flist.Count > 0)
                {
                    foreach (Figure item in Flist)
                    {
                        item.Show();
                    }
                }
                else
                {
                    Console.WriteLine("Пусто");
                }
                return null;
            }


            Figure Clear()
            {
                Flist.Clear();
                Console.WriteLine("Чисто");
                return null;
            }


            static Figure InputFigure()
            {
                Console.WriteLine("Выберите тип фигуры:{0} 1.Линия{0} 2.Окружность{0} 3.Кольцо{0} 4.Прямоугольник{0} 5.Квадрат {0} 6.Треугольник",
                     Environment.NewLine);
                switch (Console.ReadLine())
                {
                    case "1": return CreateLine();
                    case "2": return CreateCircle();
                    case "3": return CreateRing();
                    case "4": return CreateRec();
                    case "5": return CreateSq();
                    case "6": return CreateTri();
                    default:
                    return null;
                }
            }


            static Line CreateLine()
            {
                double start_X, start_Y, end_X, end_Y;
                Console.WriteLine("Введите параметры фигуры Линия");
                Console.Write("Введите координаты начальной точки Х: ");
                start_X = double.Parse(Console.ReadLine());
                Console.Write("Введите координаты начальной точки Y: ");
                start_Y = double.Parse(Console.ReadLine());
                Console.Write("Введите координаты конечной точки Х: ");
                end_X = double.Parse(Console.ReadLine());
                Console.Write("Введите координаты конечной точки Y: ");
                end_Y = double.Parse(Console.ReadLine());
                Console.WriteLine("Фигура линия создана!");
                return new Line(start_X, start_Y, end_X, end_Y);
            }


            static Circle CreateCircle()
            {
                double X, Y, radius;
                Console.WriteLine("Введите параметры фигуры Окружность");
                Console.Write("Введите координаты начальной точки Х: ");
                X = double.Parse(Console.ReadLine());
                Console.Write("Введите координаты начальной точки Y: ");
                Y = double.Parse(Console.ReadLine());
                Console.Write("Введите  радиус: ");
                radius = double.Parse(Console.ReadLine());
                Console.WriteLine("Фигура Окружность создана!");
                return new Circle(X, Y, radius);
            }


            static Ring CreateRing()
            {
                double X, Y, radius, innerRadius;
                Console.WriteLine("Введите параметры фигуры Кольцо ");
                Console.Write("Введите координаты начальной точки Х: ");
                X = double.Parse(Console.ReadLine());
                Console.Write("Введите координаты начальной точки Y: ");
                Y = double.Parse(Console.ReadLine());
                Console.Write("Введите внутренний радиус: ");
                innerRadius = double.Parse(Console.ReadLine());
                Console.Write("Введите радиус: ");
                radius = double.Parse(Console.ReadLine());
                Console.WriteLine("Фигура Кольцо создана!");
                return new Ring(X, Y, radius, innerRadius);
            }


            static Rectangle CreateRec()
            {
                double X, Y, A, B;
                Console.WriteLine("Введите параметры фигуры Прямоугольник ");
                Console.Write("Введите координаты центра точки Х: ");
                X = double.Parse(Console.ReadLine());
                Console.Write("Введите координаты центра точки Y: ");
                Y = double.Parse(Console.ReadLine());
                Console.Write("Расчет длины стороны A: ");
                A = double.Parse(Console.ReadLine());
                Console.Write("Расчет длины стороны В: ");
                B = double.Parse(Console.ReadLine());
                Console.WriteLine("Фигура прямогульник создана!");
                return new Rectangle(X, Y, A, B);
            }


            static Square CreateSq()
            {
                double X, Y, A;
                Console.WriteLine("Введите параметры фигуры Квадрат ");
                Console.Write("Введите координаты центра точки Х: ");
                X = double.Parse(Console.ReadLine());
                Console.Write("Введите координаты центра точки Y: ");
                Y = double.Parse(Console.ReadLine());
                Console.Write("Длина стороны A: ");
                A = double.Parse(Console.ReadLine());
                Console.WriteLine("Фигура квадрат создана!");
                return new Square(X, Y, A);
            }


            static Triangle CreateTri()
            {
                double x, y;
                Console.WriteLine("Введите координаты центра фигуры треугольник ");
                Console.Write(" Х: ");
                x = double.Parse(Console.ReadLine());
                Console.Write(" Y: ");
                y = double.Parse(Console.ReadLine());
                Console.Write("Сторона А: ");
                Line sideA = CreateLine();
                Console.Write("Сторона В");
                Line sideB = CreateLine();
                Console.Write("Сторона С");
                Line sideC = CreateLine();
                Console.WriteLine("Фигура Треугольник создана!");
                return new Triangle(x, y, sideA, sideB, sideC);
            }
        }
    }
}

