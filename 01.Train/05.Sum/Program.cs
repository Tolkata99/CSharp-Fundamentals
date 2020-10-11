using System;

namespace _05.Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int sum = Sum(n1, n2, n3);
            Console.WriteLine(sum);
        }

        private static int Sum(int n1, int n2, int n3)
        {
            int  firtsAndSeconds = n1 + n2;
            return subtract(firtsAndSeconds, n3);
        }

        private static int subtract(int firtsAndSeconds, int n3)
        {
            return firtsAndSeconds - n3;
        }
    }
}
