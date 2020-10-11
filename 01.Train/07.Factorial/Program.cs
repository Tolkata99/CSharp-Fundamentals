using System;

namespace _07.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int firtsNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            double factorialFirstNum = CalculateFactorial(firtsNum);
            double factorialSecondsNum = CalculateFactorial(secondNum);
            double result = factorialFirstNum / factorialSecondsNum;

            Console.WriteLine($"{result:f2}");

        }

        private static double CalculateFactorial(int number)
        {
            double result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }
    }
}
