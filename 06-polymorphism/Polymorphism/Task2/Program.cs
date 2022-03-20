using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ISeries progression = new GeometricProgression(2, 2);
            Console.WriteLine("Progression:");
            PrintSeries(progression, 5);
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
    }
}
