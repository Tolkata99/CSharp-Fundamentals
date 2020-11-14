using System;
using System.Collections.Generic;
using System.Linq;

namespace OneTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nmbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            SortedDictionary<double, int> counts = new SortedDictionary<double,int>();

            foreach (int number in nmbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts.Add(number,1);
                }
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }



        }
    }
}
