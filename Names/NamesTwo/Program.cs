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

            double totalTotPrice = 0;
            string input = Console.ReadLine();
            while (input != "end of shift")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    name = match.Groups[1].Value;
                    product = match.Groups[2].Value;
                    quantity = int.Parse(match.Groups[3].Value);
                    price = double.Parse(match.Groups[4].Value);
                    double totPrice = quantity * price;

                    Console.WriteLine($"{name}: {product} - {totPrice}");
                    totalTotPrice += totPrice;
                }



                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalTotPrice}");
            


        }
    }
}
