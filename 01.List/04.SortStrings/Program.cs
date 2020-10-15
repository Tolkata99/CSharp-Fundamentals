using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SortStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = new List<string>(n);
            for (int i = 0; i < n; i++)
            {
                

                string currProduct = Console.ReadLine();
                names.Add(currProduct);
            }
            names.Sort();
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{names[i]}");
            }
        }
    }
}
