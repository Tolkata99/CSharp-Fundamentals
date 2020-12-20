using System;
using System.Text.RegularExpressions;

namespace EmailFind
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})[-.\/](?<month>\w{3})[-.\/](?<year>\d{4})\b";

            Regex regex = new Regex(pattern);
            string text = Console.ReadLine();

            MatchCollection matchCol = regex.Matches(text);

            foreach (Match item in matchCol)
            {
                Console.WriteLine($"{item.Groups["day"].Value}{item.Groups["month"].Value}{item.Groups["year"].Value}"); 
            }

        }
    }
}
