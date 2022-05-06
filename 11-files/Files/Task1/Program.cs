using System;
using System.Collections.Generic;
using System.IO;


namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine("..", "..", "..", "..", "..", "disposable_task_file.txt");
            string[] lines = File.ReadAllLines(path);
            using (StreamWriter writer = new StreamWriter(path))
            {
                int number;
                foreach (string line in lines)
                {
                    if (int.TryParse(line, out number))
                        writer.WriteLine(Pow(number));

                }
            }
        }

        static int Pow(int number)
        {
            return number * number;
        }


    }
}

