using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ring oneRing = new Ring(0, 0, 8, 5);
            Console.WriteLine(oneRing.Radius);
            Console.WriteLine(oneRing.InnerRadius);
            Console.WriteLine(oneRing.Area());
            Console.WriteLine(oneRing.Circumference());
        }
    }
}
