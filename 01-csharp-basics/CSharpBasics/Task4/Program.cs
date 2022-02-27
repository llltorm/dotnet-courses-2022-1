using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Приветствую! Данная программа рисует пирамидки(число ступенек определяется введённым значением) . Для корректной работы программы необходимо вводить положительные числа.");
            Console.Write("Введите число пирамидок: ");
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
                Console.Write("Неверный ввод! Введите положительное число, больше 0: ");
            for (int i = 1; i <= size; i++)
                for (int j = 1; j <= i; j++)
                    Console.WriteLine(new string(' ', size - j) + new string('*', j * 2 - 1));
        }
    }
}
