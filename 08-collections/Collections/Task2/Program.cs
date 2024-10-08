﻿using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //var list = new List <int> { 1, 2, 3 };
            //DynamicArray<int> listInt = new List<int>();
            //DynamicArray<int> listInt = new DynamicArray<int>(new int[] { 5, 8, 6, 3, 1 });
            DynamicArray<int> listInt = new DynamicArray<int>((IEnumerable <int>)new int[] { 5, 8, 6, 3, 1 });
            listInt.Add(8);
            listInt.Add(9);
            listInt.Add(10);
            listInt.Remove(8);
            DynamicArray<string> listString = new DynamicArray<string>(new string[] { "привет", "мир", "!"});
            /*            IEnumerable<string> strings = new List<string>() { "привет", "мир" };
                        DynamicArray<string> listStrings = (DynamicArray<string>)strings;*/
            //var listStrings = strings;
            listString.Add("!!!!!!!");
            foreach (int elem in listInt)
            {
                Console.WriteLine(elem);
            }
            foreach (string elem in listString)
            {
                Console.WriteLine(elem);
            }
            /*listString.PrintSeries(listString);
            listInt.PrintSeries(listInt);*/
        }
    }
}
