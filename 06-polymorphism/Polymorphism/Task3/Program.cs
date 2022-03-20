﻿using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgression progression = new ArithmeticProgression(2, 2);
            Console.WriteLine("Progression:");
            PrintSeries(progression,5);

            List list = new List(new double[] { 5, 8, 6, 3, 1 });
            Console.WriteLine("List:");
            PrintSeries(list, 5);
        }

        public static void PrintSeries(ISeries series, int count)
        {
            series.Reset();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }

        public static void PrintIndexable(IIndexable series, int count)
        {
            
        }

    }
}
