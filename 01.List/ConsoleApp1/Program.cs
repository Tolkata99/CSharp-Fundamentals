using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            numbers.Add(500);
            numbers.Add(555);
            numbers.Add(777);

            numbers.Remove(4);

            numbers.Insert(2, 997979797);
            numbers.Sort(2, 77, 2 == 3);


            bool isEResult = numbers.Contains(777);

            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(isEResult);
        }
    }
}
