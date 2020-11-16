using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());

            double area = GetRectangleArea(width, heigth);
            Console.WriteLine(area);
        }

        private static double GetRectangleArea(double width, double heigth)
        {
            return width * heigth;
        }
    }
}
