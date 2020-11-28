using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();

            string[] racers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < racers.Length; i++)
            {
                dic.Add(racers[i], 0);
            }




            string digitsPatern = @"([\DA-Za-z])";
            string namePatern = @"[\W\d]";
            

            string input = Console.ReadLine();
            while (input != "end of race")
            {
                string name = Regex.Replace(input, namePatern, "");
                string distance = Regex.Replace(input, digitsPatern, "");
                int result = 0;
                if (dic.ContainsKey(name))
                {
                    foreach (var digits in distance)
                    {
                        int currDigits = int.Parse(digits.ToString());
                        result += currDigits;
                    }
                    dic[name] += result;

                }

                input = Console.ReadLine();
            }
          
            int count = 1;
            foreach (var item in dic.OrderByDescending(n => n.Value))
            {
                string text = count == 1 ? "st": count == 2 ? "nd" : "rd";
                Console.WriteLine($"{count}{text}  {item.Value}");
                if (count == 3)
                    break;
                count++;
            }





        }
    }
}
