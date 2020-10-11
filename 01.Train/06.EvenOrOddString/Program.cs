using System;
using System.Linq;

namespace _06.EvenOrOddString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            

            if(input.Length % 2 == 0)
            {
                string evenOutput = GetCharEvenLenght(input);
                Console.WriteLine(evenOutput);
            }
            else
            {
                string oddOutput = GetCharOddLenght(input);
                Console.WriteLine(oddOutput);
            }
        }

        private static string GetCharOddLenght(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index, 1);
            return chars;

        }

        private static string GetCharEvenLenght(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index - 1, 2);
            return chars;
        }
    }
}
