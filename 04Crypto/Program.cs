using System;

namespace _04Crypto
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string crypto = string.Empty;
            foreach (char ch in text)
            {
                var currChar = (char)(ch + 3);
                crypto += currChar;
            }
            Console.WriteLine(crypto);
        }
    }
}
