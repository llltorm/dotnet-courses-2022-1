using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masRandomValue = new int[10];
            Random random = new Random();
            for (int i = 0; i < masRandomValue.Length; i++)
            {
                masRandomValue[i] = random.Next(10) - 5;
                Console.WriteLine(masRandomValue[i]);
            }
            Console.WriteLine(GetSumOfNonNegativeElements(masRandomValue));
        }

        static int GetSumOfNonNegativeElements(int[] masRandomValue)
        {
            int sum = 0;
            for (int i = 0; i < masRandomValue.Length; i++)
            {
                if(masRandomValue[i]>0)
                {
                    sum += masRandomValue[i];
                }
            }
            return sum;
        }
    }
}
