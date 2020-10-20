using System;
using System.Collections.Generic;
using System.Linq;

namespace ApendAray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split("|")
                .ToList();

            list.Reverse();

            List<string> result = new List<string>();
            foreach (string currItems in list)
            {
                string[] numbers = currItems
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                foreach (var numbersToadd in numbers)
                {
                    result.Add(numbersToadd);
                }
                
            }


            Console.WriteLine(string.Join(" ", result));

        }
    }
}
