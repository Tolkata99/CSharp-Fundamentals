using System;
using System.Text.RegularExpressions;

namespace ExersizeRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(\w[A-Za-z]+)<<(\d[(0.00-9.00|0-9)*]+)!(\d+)";
            Regex regex = new Regex(pattern);

            string text = Console.ReadLine();



            double total = 0.00;
           Console.WriteLine("Bought furniture:");
            while (text != "Purchase")
            {
                Match match = regex.Match(text);
                if(match.Success)
                {
                    string printName = match.Groups[1].Value;
                    Console.WriteLine(printName);

                    double result = double.Parse(match.Groups[2].Value) * double.Parse(match.Groups[3].Value);
                    total += result;
                }
                




                text = Console.ReadLine();
                
            }
            Console.WriteLine($"Total money spend: {total:f2}");
            
            
            
        }
    }
}
