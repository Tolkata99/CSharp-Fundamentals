using System;
using System.Collections.Generic;
using System.Linq;

namespace bomGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] bombProb = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bobm = bombProb[0];
            int power = bombProb[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumbers = numbers[i];
                if(currentNumbers == bobm)
                {
                    int startIndex = i - power;
                    int endIndex = i + power;

                    if(startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if(endIndex > numbers.Count - 1)
                    {
                        endIndex = numbers.Count - 1;
                    }

                    int endIndexToremove = endIndex - startIndex + 1;
                    numbers.RemoveRange(startIndex, endIndexToremove);

                    i = startIndex - 1;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
