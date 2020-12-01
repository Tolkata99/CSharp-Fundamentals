using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            //string pattern = @"(?<niz1>\D+)(?<number1>\d+)";
            string pattern = @"(?<niz1>\D+)((?<number1>\d+))";
            string pattern1 = @"(\D+)(\d+)";
            Regex regex = new Regex(pattern);
            Regex regex1 = new Regex(pattern1);
            MatchCollection match = regex.Matches(text);

            // StringBuilder sb = new StringBuilder();
            //StringBuilder sb1 = new StringBuilder();
            char[] sb = new char[100];
            char[] sb1 = new char[100];


            foreach (Match item in match)
            {

                string text2 = item.Value;
                Match matchniz = regex1.Match(text2);
                int index = int.Parse(matchniz.Groups[2].Value);

                for (int i = 0; i < index; i++) 
                {
                    char print = matchniz.Groups[1].Value.ToUpper().ToCharArray();
                    sb[i] = print[i];
                }


            }
            sb1[0] = sb[0];
            foreach (char ch in sb)
            {
                for (int i = 0; i < sb.Count(); i++)
                {
                    if(sb1.ToString().Contains(ch) == false)
                    {
                        sb1[i] = ch;
                        
                        break;
                    }
                        
 
                    
                }
            }
            Console.WriteLine($"Unique symbols used: {sb1.Length}");
            Console.WriteLine(sb);


        }
    }
}
