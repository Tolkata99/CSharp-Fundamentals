using System;
using System.Linq;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int oddSum = 0;
            int EvenSum = 0; 
            for (int i = 0; i < array.Length; i++)
            {
                int currentNumber = array[i];
                if(currentNumber % 2 == 0)
                {
                    EvenSum += currentNumber;
                }
                else
                {
                    oddSum += currentNumber;
                }
            }

            int differene = EvenSum - oddSum;

            Console.WriteLine(string.Join("$", array.Reverse()));
        }
    }
}
