using System;

namespace _05.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            PrintTriangle(start, end);
        }
        static void PrintTriangle(int start, int end)
        {
            int counter = 1;
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i + " ");
                
            }
            Console.WriteLine();
            for (int i = 1; i <= counter; i++)
            {
                PrintTriangle(1, i);
            }
            for (int i = counter - 1; i <= 1; i--)
            {
                PrintTriangle(1, i);
            }
        }
    }
}
