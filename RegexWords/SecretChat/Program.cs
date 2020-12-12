using System;
using System.Linq;
using System.Text;

namespace SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string text = Console.ReadLine();

            string comands = Console.ReadLine();
            while (comands != "Reveal")
            {
                string[] tokens = comands
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string comandIf = tokens[0];
                if (comandIf == "InsertSpace")
                {

                    string n = " ";
                    text = text.Insert(int.Parse(tokens[1]), n);
                    Console.WriteLine(text);
                }
                else if (comandIf == "Reverse")
                {
                    if (text.Contains(tokens[1]))
                    {
                        string rev = tokens[1];
                        int n = text.IndexOf(tokens[1]);





                        text = text.Remove(n, tokens[1].Length);
                        sb.Clear();
                        for (int i = rev.Length - 1; i >= 0; i--)
                        {
                            sb.Append(rev[i]);
                        }


                        



                         text = text.Insert(text.Length, sb.ToString());

                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                else if (comandIf == "ChangeAll")
                {
                    text = text.Replace(tokens[1], tokens[2]);
                    Console.WriteLine(text);
                }


                comands = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {text}");
        }
    }
}
