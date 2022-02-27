using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeric_sideA;
            int numeric_sideB;
            int result;
            Console.WriteLine("Приветствую! Данная программа определяет площадь прямоугольника. Для корректной работы программы необходимо вводить положительные стороны фигуры.");
            while(true)
            {  
                Console.WriteLine("Введите первую сторону прямоугольника:");
                string string_sideA = Console.ReadLine();
                numeric_sideA = int.Parse(string_sideA);
                if (numeric_sideA > 0) break;
                else Console.WriteLine("Введите положительное число, больше 0");
            }
            while (true)
            {
                Console.WriteLine("Введите вторую сторону прямоугольника:");
                string string_sideB = Console.ReadLine();
                numeric_sideB = int.Parse(string_sideB);
                result = numeric_sideB * numeric_sideA;
                if (numeric_sideB > 0) break;
                else Console.WriteLine("Введите положительное число, больше 0");
            }
            Console.WriteLine($"Площадь фигуры = {result}");
        }
    }
}
