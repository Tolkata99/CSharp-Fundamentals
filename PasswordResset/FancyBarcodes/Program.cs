using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternName = @"@\#+(?<name>[A-Z][A-Za-z0-9]{4,}[A-Z])@\#+";
            string patternNumber = @"\d";

            Regex regexName = new Regex(patternName);
            Regex regexNumber = new Regex(patternNumber);

            string sb = string.Empty;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                Match matchName = regexName.Match(text);
                if(matchName.Success)
                {
                    MatchCollection matchNum = regexNumber.Matches(matchName.Groups[0].Value);
                    
                    if(matchNum.Count >= 1 )
                    {
                        for (int j = 0; j < matchNum.Count; j++)
                        {
                            sb += matchNum[j];
                        }
                    }
                    else
                    {
                        sb = "00";
                    }
                   
                    Console.WriteLine($"Product group: {sb}");
                    sb = string.Empty;
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
