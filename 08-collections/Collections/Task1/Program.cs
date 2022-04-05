using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> krugPeople = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            LinkedList<int> linkedKrugPeople = new LinkedList<int>();
            //Console.Write("Введите количество человек: ");
            //int countPeople = int.Parse(Console.ReadLine());
/*            FillingList(krugPeople, countPeople);
            FillingList(linkedKrugPeople, countPeople);*/
            RemoveEachSecondItem(krugPeople);
            RemoveEachSecondItem(linkedKrugPeople);
            PrintPeopleFromList(krugPeople);
            PrintPeopleFromList(linkedKrugPeople);
        }

        static void RemoveEachSecondItem <T>(ICollection <T> krugPeople)
        {
            List<T> deletePeople = new List<T>();
            int step = 0;
            int countPeople = krugPeople.Count;
            //создание коллекции элементов под удаление
            while (countPeople > 1)
            {
                foreach (T element in krugPeople)
                {
                    if (!deletePeople.Contains(element))
                    {
                        step++;
                        if (step % 2 == 0)
                        {
                            deletePeople.Add(element);
                            countPeople--;
                        }
                    }

                }
            }
            //удаление людей, входящих в 
            foreach (T element in deletePeople)
            {
                krugPeople.Remove(element);
            }            
        }

/*        static void FillingList(ICollection<int> krugPeople, int countPeople)
        {
            for (int i = 0; i < countPeople; i++)
            {
                krugPeople.Add(i + 1); // Заполняем список
            }
        }*/

        static void PrintPeopleFromList<T>(ICollection<T> krugPeople)
        {
            foreach (T element in krugPeople)
            {
                Console.WriteLine($"Остался человек № {element}");
            }
        }
    }
}
