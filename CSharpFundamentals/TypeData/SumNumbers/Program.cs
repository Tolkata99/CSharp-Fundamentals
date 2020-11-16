using System;
using System.Linq;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

           
            int[] arr = new int[array.Length - 1];
            int[] arr2 = new int[array.Length - 1];
            int sum2 = 0;
            int total2 = 0;
            int sum = 0;
            int total = 0;
            while (true)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i == array.Length - 1)
                    {
                        break;
                    }
                    sum = array[i] + array[i + 1];

                    arr[i] += sum;

                    total += sum;
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == arr.Length - 1)
                    {
                        break;
                    }
                    sum2 = arr[i] + arr[i + 1];
                    total2 += sum;

                }

            }
            if (array.Length <= 1)
            {
                Console.WriteLine("1 is already condensed to number");
            }
            else
            Console.WriteLine(total + total2);
        }
    }
}
