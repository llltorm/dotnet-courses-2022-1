using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numericSideA;
            int numericSideB;
            int result;
            Console.WriteLine("Приветствую! Данная программа определяет площадь прямоугольника. Для корректной работы программы необходимо вводить положительные стороны фигуры.");
            while(true)
            {  
                Console.WriteLine("Введите первую сторону прямоугольника:");
                string string_sideA = Console.ReadLine();
                numericSideA = int.Parse(string_sideA);
                if (numericSideA > 0) break;
                else Console.WriteLine("Введите положительное число, больше 0");
            }
            while (true)
            {
                Console.WriteLine("Введите вторую сторону прямоугольника:");
                string stringSideB = Console.ReadLine();
                numericSideB = int.Parse(stringSideB);
                result = numericSideB * numericSideA;
                if (numericSideB > 0) break;
                else Console.WriteLine("Введите положительное число, больше 0");
            }
            Console.WriteLine(result);
        }
    }
}
