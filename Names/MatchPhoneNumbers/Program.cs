using System;
using System.Text.RegularExpressions;

namespace MatchPhoneNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @"^|[+359]+(-| )[2]\1[\d]{3}\1[\d]{4}\b";

            Regex regex = new Regex(patern);

            string phoneNumber = Console.ReadLine();

            var match = regex.Matches(phoneNumber);

            Console.Write(string.Join(", ",match));

        }
    }
}
