using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Round figure = new Round(0, 0, 5);
            double length = figure.Circumference();
            double square = figure.Area();
            //Michail.Radius = 0;
            Console.WriteLine("Длина окружности - {0}", length);
            Console.WriteLine("Площадь окружности - {0}", square);

        }
    }
}
