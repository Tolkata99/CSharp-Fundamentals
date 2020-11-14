using System;
using System.Collections.Generic;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruits = new SortedDictionary<string, double>();

            fruits["kiwi"] = 4.5;
            fruits["vesni"] = 5558888222.2;
            fruits["aziti"] = 88778;

            foreach (var item in fruits)
            {
                Console.WriteLine($"{item.Value}too {item.Key}");
            }

            fruits.Add("kixwi", 8585);
            fruits.Add("vcesni", 8585);

            foreach (var item in fruits)
            {
                Console.WriteLine($"{item.Value}too {item.Key}");
            }
        }
    }
}
