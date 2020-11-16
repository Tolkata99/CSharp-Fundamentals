using System;
using System.Linq;

namespace EvenOrOddAray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] firstArray = new string[n];
            string[] secondsArray = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] arays = Console.ReadLine()
                                        .Split()
                                        .ToArray();

                string indexZero = arays[0];
                string indexOne = arays[1];

                if(i % 2 == 0)
                {
                    firstArray[i] = indexZero;
                    secondsArray[i] = indexOne;
                }
                else if(i % 2 == 1)
                {
                    secondsArray[i] = indexZero;
                    firstArray[i] = indexOne;
                    
                }
                

            }
            Console.Write(string.Join(" ", firstArray));
            Console.WriteLine();
            Console.Write(string.Join(" ", secondsArray));
        }
    }
}
