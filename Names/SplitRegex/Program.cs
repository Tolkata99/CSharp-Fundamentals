using System;
using System.Text.RegularExpressions;

namespace SplitRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "1   2  3      0";
            string patern = @"\s+";
            


            string[] result = Regex.Split(text, patern);
            Console.WriteLine(string.Join(" ",result));

        }
    }
}
