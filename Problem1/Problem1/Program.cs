using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string comand = Console.ReadLine();
            while (comand != "End")
            {
                string[] tokens = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string comandIf = tokens[0];
                if (comandIf == "Translate")
                {
                    var chara = tokens[1];
                    var replacement = tokens[2];

                    text = text.Replace(chara, replacement);
                    Console.WriteLine(text);
                }
                else if (comandIf == "Includes")
                {
                    bool fl = text.Contains(tokens[1]);
                    Console.WriteLine(fl);
                }
                else if (comandIf == "Start")
                {
                    bool za = text.StartsWith(tokens[1]);
                    Console.WriteLine(za);
                }
                else if (comandIf == "Lowercase")
                {
                    text = text.ToLower();
                    Console.WriteLine(text);
                }
                else if (comandIf == "FindIndex")
                {
                    int index = text.LastIndexOf(tokens[1]);
                    Console.WriteLine(index);
                }
                else if (comandIf == "Remove")
                {
                    text = text.Remove(int.Parse(tokens[1]), int.Parse(tokens[2]));
                    Console.WriteLine(text);

                }


                comand = Console.ReadLine();
            }
            

        }
    }
}
