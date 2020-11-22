using System;

namespace _03ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("\\");
            int length = input.Length;
            string file = input[length - 1];

            string[] files = file.Split(".");

            string first = files[0];
            string seconds = files[1];


            Console.WriteLine($"File name: {first}");
            Console.WriteLine($"File extension: {seconds}");
        }
    }
}
