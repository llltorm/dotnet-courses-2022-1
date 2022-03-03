using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] masRandomValue = new int[2, 2, 2];
            Random random = new Random();
            //иницилизация и вывод массива
            for (int i = 0; i < masRandomValue.GetLength(0); i++)
            {
                for (int j = 0; j < masRandomValue.GetLength(1); j++)
                {
                    for (int k = 0; k < masRandomValue.GetLength(2); k++)
                    {
                        masRandomValue[i, j, k] = random.Next(100) -50;
                        Console.WriteLine(masRandomValue[i, j, k]);
                    }
                }
            }
            ReplacePositiveElementsWithZero(masRandomValue);
            //вывод изменнённого массива
            for (int i = 0; i < masRandomValue.GetLength(0); i++)
            {
                for (int j = 0; j < masRandomValue.GetLength(1); j++)
                {
                    for (int k = 0; k < masRandomValue.GetLength(2); k++)
                    {
                        Console.WriteLine(masRandomValue[i, j, k]);
                    }
                }
            }
        }

        static void ReplacePositiveElementsWithZero(int[,,] masRandomValue)
        {
            for (int i = 0; i < masRandomValue.GetLength(0); i++)
            {
                for (int j = 0; j < masRandomValue.GetLength(1); j++)
                {
                    for (int k = 0; k < masRandomValue.GetLength(2); k++)
                    {
                        if (masRandomValue[i, j, k] < 0)
                        {
                            masRandomValue[i, j, k] = 0;
                        }
                    }
                }
            }
        }
    }
}
