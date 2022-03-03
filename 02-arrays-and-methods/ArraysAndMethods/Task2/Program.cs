using System;

namespace Task2
{
    class Program
    {
        static int[,,] MasRandomValue = new int[2, 2, 2];
        static void Main(string[] args)
        {
            Random random = new Random();
            //иницилизация и вывод массива
            for (int i = 0; i < MasRandomValue.GetLength(0); i++)
            {
                for (int j = 0; j < MasRandomValue.GetLength(1); j++)
                {
                    for (int k = 0; k < MasRandomValue.GetLength(2); k++)
                    {
                        MasRandomValue[i, j, k] = random.Next(100) -50;
                        Console.WriteLine(MasRandomValue[i, j, k]);
                    }
                }
            }
            ReplacePositiveElementsWithZero();
            //вывод изменнённого массива
            for (int i = 0; i < MasRandomValue.GetLength(0); i++)
            {
                for (int j = 0; j < MasRandomValue.GetLength(1); j++)
                {
                    for (int k = 0; k < MasRandomValue.GetLength(2); k++)
                    {
                        Console.WriteLine(MasRandomValue[i, j, k]);
                    }
                }
            }
        }

        static void ReplacePositiveElementsWithZero()
        {
            for (int i = 0; i < MasRandomValue.GetLength(0); i++)
            {
                for (int j = 0; j < MasRandomValue.GetLength(1); j++)
                {
                    for (int k = 0; k < MasRandomValue.GetLength(2); k++)
                    {
                        if (MasRandomValue[i, j, k] < 0)
                        {
                            MasRandomValue[i, j, k] = 0;
                        }
                    }
                }
            }
        }
    }
}
