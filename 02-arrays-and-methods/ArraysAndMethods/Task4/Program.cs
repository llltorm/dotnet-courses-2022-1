using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] masRandomValue = new int[4,4];
            Random random = new Random();
            //иницилизация и вывод массива
            for (int i = 0; i < masRandomValue.GetLength(0); i++)
            {
                for (int j = 0; j < masRandomValue.GetLength(1); j++)
                {
                        masRandomValue[i, j] = random.Next(10) - 5;
                        Console.WriteLine(masRandomValue[i, j]);
                }
            }
            Console.WriteLine(GetSumOfElementsOnEvenPositions(masRandomValue));
        }

        static int GetSumOfElementsOnEvenPositions(int[,] masRandomValue)
        {
            int sum = 0;
            for (int i = 0; i < masRandomValue.GetLength(0); i++)
            {
                for (int j = 0; j < masRandomValue.GetLength(1); j++)
                {
                    if (((i + j) % 2 == 0) & (masRandomValue[i, j] > 0))
                    {
                        sum += masRandomValue[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
