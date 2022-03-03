using System;

namespace Task1
{
    class Program
    {
        static int[] MasRandomValue = new int[10];
        static void Main(string[] args)
        {
            int maxValue;
            int minValue;
            GenerateArray();
            SortAndGetMinAndMaxValues(MasRandomValue, out maxValue, out minValue) ;
            PrintArray(MasRandomValue, maxValue, minValue);
        }

        static int[] GenerateArray()
        {
            Random random = new Random();
            for (int i = 0; i < MasRandomValue.Length; i++)
            {
                MasRandomValue[i] = random.Next(100);
            }
            return MasRandomValue;
        }

        static int[] SortAndGetMinAndMaxValues(int[] masRandomValue, out int maxValue, out int minValue)
        {
            maxValue = 0;
            minValue = 100;
            //поиск минимального и максимального значений
            for (int i = 0; i < masRandomValue.Length; i++)
            {
                if (masRandomValue[i] > maxValue)
                {
                    maxValue = masRandomValue[i];
                }
                if (masRandomValue[i] < minValue)
                {
                    minValue = masRandomValue[i];
                }
            }
            //сортировка массива
            for (int i = 0; i < masRandomValue.Length; i++)
            {
                for (int j = 0; j < masRandomValue.Length - 1; j++)
                {
                    if (masRandomValue[j] > masRandomValue[j + 1])
                    {
                        int temp = masRandomValue[j];
                        masRandomValue[j] = masRandomValue[j + 1];
                        masRandomValue[j + 1] = temp;
                    }
                }
            }
            return masRandomValue;
        }
        
        static void PrintArray(int[] masRandomValue, int maxValue, int minValue) 
        {
            for (int i = 0; i < masRandomValue.Length; i++)
            {
                Console.WriteLine(masRandomValue[i]);
            }
            Console.WriteLine(minValue);
            Console.WriteLine(maxValue);
        }

    }
}
