using System;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            FindMinNumber(n1,n2,n3);
        }
        static void FindMinNumber(int n1, int n2, int n3)
        {
            double a = Math.Min(n1, n2);
            double minNumber = Math.Min(a, n3);
            Console.WriteLine(minNumber);
        }
    }
}
