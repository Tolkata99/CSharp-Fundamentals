using System;
using System.Text.RegularExpressions;

namespace RegexFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\||\#)(?<name>[A-Za-z]+\s*[A-z]+)\1(?<date>[0-3][0-9]\/[0-1][0-9]\/[0-9]{2})\1(?<call>[0-9]{1,5})\1";
            Regex regex = new Regex(pattern);

            string text = Console.ReadLine();

            MatchCollection matchColl = regex.Matches(text);

            int resultCall = 0;
            foreach (Match item in matchColl)
            {
                
                resultCall += int.Parse(item.Groups[4].Value);
            }


            int days = resultCall / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match item in matchColl)
            {
                Console.WriteLine($"Item: {item.Groups[2].Value}, Best before: {item.Groups[3].Value}, Nutrition: {item.Groups[4].Value}");
            }
        }
    }
}
