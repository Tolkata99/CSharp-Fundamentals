using System;

namespace MathPow
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            MathPow(a, b);
        }

        static void MathPow(int a,int b)
        {
            double result = Math.Pow(a, b);
            Console.WriteLine(result);
        }
        
    }
}
