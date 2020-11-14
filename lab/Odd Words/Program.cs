using System;
using System.Collections.Generic;

namespace Odd_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordToLower = word.ToLower();
                if(counts.ContainsKey(wordToLower))
                {
                    counts[wordToLower]++;
                }
                else
                {
                    counts.Add(wordToLower, 0);
                }

            }

            List<string> printWords = new List<string>();

            foreach (var item in counts)
            {
                if(item.Value % 2 == 0)
                {
                   
                    printWords.Add(item.Key);
                }
               
                
            }

            Console.WriteLine(string.Join(" ", printWords));


        }
    }
}
