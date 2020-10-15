using System;
using System.Collections.Generic;
using System.Linq;

namespace _03Concaten
{
    class Program
    {
        

        static void Main(string[] args)
        {
            List<int> numbersSum = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxIndex = numbersSum.Count  / 2;

            for (int i = 0; i < maxIndex; i++)
            {
                numbersSum[i] += numbersSum[numbersSum.Count - 1];
                numbersSum.Remove(numbersSum[numbersSum.Count - 1]);
            }
            Console.Write(string.Join(" ", numbersSum));






        }
    }
}
