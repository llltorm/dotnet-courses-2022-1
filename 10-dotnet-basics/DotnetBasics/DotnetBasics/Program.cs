using System;
using MathLibrary;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberFactorial = 20;
            int numberPow = 5;
            int degreePow = 3;
            Console.WriteLine($"факториал {numberFactorial} равен: {MathFunctions.Factorial(numberFactorial)}");
            Console.WriteLine($"число {numberPow} в {degreePow} степени будет равно: {MathFunctions.Power(numberPow, degreePow)}");

        }
    }
}
