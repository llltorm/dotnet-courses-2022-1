using System;

namespace MathLibrary
{
    public static  class MathFunctions
    {
        public static long Factorial(int number)
        {
            long factorial = 1;
            for (int i = 2; i <= number; ++i)
            {
                factorial *= i;
            }
            return factorial;
        }

        public static double Power(double x, double y)
        {

            return (Math.Pow(x, y));
        }
    }
}
