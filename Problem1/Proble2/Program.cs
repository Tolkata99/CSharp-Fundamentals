using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Proble2
{
    class Program
    {
        static void Main(string[] args)
        {
            string patters = @"(\*|\@)(?<name>[A-Z][a-z]{3,})\1\:\s{1}(\[[A-z]\]\|){3}$";
            Regex regex = new Regex(patters);
            string patChar = @"(\[([A-z])\]\|)";
            Regex regchar = new Regex(patChar);
            ArgumentOutOfRangeException 
            List<int> list = new List<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                Match match = regex.Match(text);

                string tag = match.Groups[3].Value;
                MatchCollection mat = regchar.Matches(text);

                list.Clear();
                if (match.Success && mat.Count <= 3)
                {

                    foreach (Match item in mat)
                    {
                        char f = char.Parse(item.Groups[2].Value);
                        int en = f;
                        list.Add(en);
                    }

                    Console.WriteLine($"{tag}: {string.Join(" ",list)}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }


            }
        }
    }
}
