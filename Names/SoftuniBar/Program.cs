using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SoftuniBar
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%([A-Z][a-z]+)%[^|$%.]*<(\w+)>[^|$%.]*\|(\d+)\|[^|$%.]*?(\d+\.?\d*)\$";

            string name = string.Empty;
            string product = string.Empty;
            int quantity = 0;
            double price = 0.00;
            Dictionary<string, Dictionary<string, double>> result = new Dictionary<string, Dictionary<string, double>>();

            string input = Console.ReadLine();
            while (input != "end of shift")
            {
                Match match = Regex.Match(input, pattern);

                if(match.Success)
                {
                    name = match.Groups[1].Value;
                    product = match.Groups[2].Value;
                    quantity = int.Parse(match.Groups[3].Value);
                    price = double.Parse(match.Groups[4].Value);
                    double totPrice = quantity * price;
                    if (result.ContainsKey(name) == false)
                    {
                        result.Add(name, new Dictionary<string, double>());
                    }
                    result[name].Add(product, totPrice);
                }
                


                input = Console.ReadLine();
            }
            double totalIncome = 0.00;
            foreach (var itemKey in result)
            {
                
               // var namew = itemKey;
                foreach (var kv in itemKey.Value)
                {
                    Console.WriteLine($"{itemKey.Key}: {kv.Key} - {kv.Value:f2}");
                    totalIncome += kv.Value;
                }
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");


        }
    }
}
