using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegexExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(\d)";
            string patternName = @"([:]{2}|[*]{2})(?<name>[A-Z][a-z]{2,})\1";

            List<String> names = new List<string>();


            MatchCollection matchCol = Regex.Matches(text, pattern);
            double coldNumber = 1;

            for (int i = 0; i < matchCol.Count; i++)
            {
               coldNumber *= int.Parse(matchCol[i].Value);
            }
            Console.WriteLine($"Cool threshold: {coldNumber}");

            


            MatchCollection name = Regex.Matches(text, patternName);
            
            for (int i = 0; i < name.Count; i++)
            {
                double sumName = 0;
                foreach (char item in name[i].Groups[2].Value)
                {
                    
                    sumName += item;
                }
                if(coldNumber < sumName)
                {
                    
                    names.Add(name[i].Groups[0].Value);
                }
               
            }
            Console.WriteLine($"{name.Count} emojis found in the text. The cool ones are:");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

        }
    }
}
