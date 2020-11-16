using System;

namespace _0._2singOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            FindPositiveNum(n);
        }

        static void FindPositiveNum(int n)
        {
            if(n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else if(n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }
    }
}
