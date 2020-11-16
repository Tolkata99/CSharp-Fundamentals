using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double a = double.Parse(Console.ReadLine());
            string comand = Console.ReadLine();
            double b = double.Parse(Console.ReadLine());

            if(comand == "-")
            {
                subtract(a, b);
            }
            else if(comand == "/")
            {
                divide(a, b);
            }
            else if(comand == "+")
            {
                add(a, b);
            }
            else if(comand == "*")
            {
                multiply(a, b);
            }
        }

        static void subtract(double a, double b)
        {
            double result = a - b;
            Console.WriteLine($"{Math.Ceiling(result):f2}");
        }

        static void divide(double a ,double b)
        {
            double result = a / b;
            Console.WriteLine($"{Math.Ceiling(result):f2}");
        }

        static void add(double a, double b)
        {
            double result = a + b;
            Console.WriteLine($"{Math.Ceiling(result):f2}");
        }

        static void multiply(double a, double b)
        {
            double result = a * b;
            Console.WriteLine($"{Math.Ceiling(result):f2}");
        }
    }
}
