using System;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            StringBuilder sb = new StringBuilder();
            int N = 100;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            stopWatch.Stop();
            double strNumber = stopWatch.Elapsed.TotalMilliseconds;
            stopWatch.Restart(); 
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            stopWatch.Stop();
            double sbNumber = stopWatch.Elapsed.TotalMilliseconds;
            Console.WriteLine("String: {0}", strNumber);
            Console.WriteLine("StringBuilder: {0}", sbNumber);
        }
    }
}
