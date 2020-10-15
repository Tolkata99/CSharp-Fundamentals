using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Murch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                                     .Split()
                                     .Select(int.Parse)
                                     .ToList();
            List<int> seconds = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < Math.Min(first.Count, seconds.Count); i++)
            {
                result.Add(first[i]);
                result.Add(seconds[i]);

            }
            for (int i = Math.Min(first.Count, seconds.Count);
                i < Math.Max(first.Count, seconds.Count); i++)
            {
                if(i >= first.Count)
                {
                    result.Add(seconds[i]);
                }
               else
                {
                    result.Add(first[i]);
                }

            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
