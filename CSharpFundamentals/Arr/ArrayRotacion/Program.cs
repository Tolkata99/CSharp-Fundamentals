using System;
using System.Linq;
namespace ArrayRotacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arays = Console.ReadLine().Split(" ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string elementToRotate = arays[0];

                for (int j = 1; j < arays.Length; j++)
                {
                    string curentElement = arays[j];
                    arays[j - 1] = curentElement;
                }
                arays[arays.Length - 1] = elementToRotate;
            }
            Console.WriteLine(string.Join(" ", arays));
        }
    }
}
