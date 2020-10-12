using System;

namespace _03.CharactersinRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char seconds = char.Parse(Console.ReadLine());

            PrintInBetween(first, seconds);
        }

        private static void PrintInBetween(char first, char seconds)
        {
            if (first > seconds)
            {
                char one = first;
                first = seconds;
                seconds = one;
            }
            for (int i = first + 1; i < seconds; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
