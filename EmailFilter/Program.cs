using System;
using System.Text.RegularExpressions;

namespace EmailFind
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\S(\w+\.?\w*)[^.-_\/]\S(\w+\.?\w*)@(\w+)(\w+\.?\w*)(\w+\.?\w)";

            Regex regex = new Regex(pattern);
            string text = Console.ReadLine();

            MatchCollection match = regex.Matches(text);

            foreach (var item in match)
            {
                Console.WriteLine(item);
            }


        }
    }
}
