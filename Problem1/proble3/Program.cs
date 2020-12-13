using System;
using System.Collections.Generic;
using System.Linq;

namespace proble3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> nameAndMessage = new Dictionary<string, List<string>>();

            string comand = Console.ReadLine();
            while (comand != "Statistics")
            {
                string[] tokens = comand.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string comandIf = tokens[0];
                if (comandIf == "Add")
                {
                    if (nameAndMessage.ContainsKey(tokens[1]) == false)
                    {
                        nameAndMessage.Add(tokens[1], new List<string>());
                    }
                    else
                    {
                        Console.WriteLine($"{tokens[1]} is already registered");
                    }
                }
                else if (comandIf == "Send")
                {
                    nameAndMessage[tokens[1]].Add(tokens[2]);
                }
                else if (comandIf == "Delete")
                {
                    if (nameAndMessage.ContainsKey(tokens[1]))
                    {
                        string remove = tokens[1];
                        nameAndMessage.Remove(remove);
                        
                    }
                    else
                    {
                        Console.WriteLine($"{tokens[1]} not found!");
                    }
                }


                comand = Console.ReadLine();
            }
            int count = nameAndMessage.Count;
            Console.WriteLine($"Users count: {count}");
            foreach (var item in nameAndMessage.OrderByDescending(k => k.Value.Count).ThenBy(n => n.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var email in item.Value)
                {
                    Console.WriteLine($" - {email}");
                }
            }

        }
    }
}
