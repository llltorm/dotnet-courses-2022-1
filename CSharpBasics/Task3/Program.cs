using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Приветствую! Данная программа рисует пирамиду(число ступенек определяется введённым значением) . Для корректной работы программы необходимо вводить положительные числа.");
            Console.Write("Введите число ступенек: ");
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
                Console.Write("Неверный ввод! Введите положительное число, больше 0: ");
            for (int i = 1; i <= size; i++)
                Console.WriteLine(new string(' ', size - i) + new string('*', i * 2 - 1));
        }
    }
}
