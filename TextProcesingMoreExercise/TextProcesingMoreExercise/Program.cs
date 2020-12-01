using System;
using System.Text.RegularExpressions;

namespace TextProcesingMoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //            2
            //Here is a name @George | and an age #18*
            //Another name @Billy | #35* is his age

            int n = int.Parse(Console.ReadLine());

            string text = Console.ReadLine();
            string pattern = @"@(\w+)";
            string patternAge = @"#(\d+)";

            

            for (int i = 0; i < n; i++)
            {
                Match matchName = Regex.Match(text,pattern);
                Match matchAge = Regex.Match(text,patternAge);

                




                Console.WriteLine($"{matchName.Groups[1].Value} is {matchAge.Groups[1].Value} years old.");


                text = Console.ReadLine();
            }



        }
    }
}
