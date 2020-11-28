using System;
using System.Text.RegularExpressions;

namespace Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ \b[A-Z][a-z]+\b";

            Regex regex = new Regex(pattern);

            string text = Console.ReadLine();
            var matches = regex.Matches(text);

            Console.Write(string.Join(" ",matches));
        }
    }
}
