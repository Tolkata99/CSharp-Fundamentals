using System;
using System.Linq;

namespace sELECT
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .Select(w => w + "2wweaz")
                .ToArray();
            Console.WriteLine(string.Join("' ",words));
        }
    }
}
