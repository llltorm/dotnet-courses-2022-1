using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoDPointWithHash Point1 = new TwoDPointWithHash(1, 10);
            TwoDPointWithHash Point2 = new TwoDPointWithHash(10, 1);
            TwoDPointWithHash Point3 = new TwoDPointWithHash(1, 1);
            TwoDPointWithHash Point4 = new TwoDPointWithHash(10, 10);
            TwoDPointWithHash Point5 = new TwoDPointWithHash(1, 10);
            Console.WriteLine(Point1.Equals(Point2));
            Console.WriteLine(Point3.Equals(Point4));
            Console.WriteLine(Point1.Equals(Point5));
        }
    }
}
