using System;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());

            if(product == "coffee")
            {
                printCoffe(price);
            }
            else if(product == "water")
            {
                printWater(price);
            }
            else if (product == "coke")
            {
                printCoke(price);
            }
            else if (product == "snacks")
            {
                printSnaks(price);
            }
        }

        private static void printSnaks(double price)
        {
            price *= 2.00;
            Console.WriteLine($"{price:f2}");
        }

        private static void printCoke(double price)
        {
            price *= 1.40;
            Console.WriteLine($"{price:f2}");
        }

        private static void printWater(double price)
        {
            price *= 1;
            Console.WriteLine($"{price:f2}");
        }

        private static void printCoffe(double price)
        {
            price *= 1.50;
            Console.WriteLine($"{price:f2}");
        }

        
    }
}
