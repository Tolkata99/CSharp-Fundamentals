using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.NegativeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split(" ")
                                       .Select(int.Parse)
                                       .ToList();
            List<int> result = numbers
                .Where(n => n >= 0)
                .Reverse()
                .ToList();

            Console.WriteLine(string.Join(" ", result));

            

        }
    }
}
