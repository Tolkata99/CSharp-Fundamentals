using System;
using System.Collections.Generic;
using System.Linq;

namespace firstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOrder = int.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 0; i < numOrder; i++)
            {
                double capsulesPrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                double capsulesCount = double.Parse(Console.ReadLine());



                double result = ((days * capsulesCount) * capsulesPrice);
                Console.WriteLine($"The price for the coffee is: ${result:f2}");
                total += result;
            }
            Console.WriteLine($"Total: ${total:f2}");


        }
    }
}
