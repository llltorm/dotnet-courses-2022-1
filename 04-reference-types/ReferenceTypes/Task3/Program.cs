using System;

namespace Task3
{
    class Program
    {


        static void Main(string[] args)
        {
            Triangle triangleABC = new Triangle(5, 10, 12);
            double sideA = triangleABC.GetArea();
            Console.WriteLine(sideA);
            double P = triangleABC.GetPerimeter();
            Console.WriteLine(P);
        }
    }
}
