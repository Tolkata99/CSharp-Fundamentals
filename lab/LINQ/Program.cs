using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .ToArray();

            int count = 0;

            if(numbers.Length <= 3)
            {
                count = numbers.Length;
            }
            else
            {
                count = 3;
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            
        }
    }
}
