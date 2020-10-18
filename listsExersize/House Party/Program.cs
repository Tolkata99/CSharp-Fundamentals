using System;
using System.Collections.Generic;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> peopleFromList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                string guesName = cmdArgs[0];

                if (cmdArgs.Length > 3)
                {
                    if (peopleFromList.Contains(guesName))
                    {
                        peopleFromList.Remove(guesName);
                    }
                    else
                    {
                        Console.WriteLine($"{guesName} is not in the list!");
                    }
                }
                else
                {
                    if (!peopleFromList.Contains(guesName))
                    {
                        peopleFromList.Add(guesName);
                    }
                    else
                    {
                        Console.WriteLine($"{guesName} is already in the list!");
                    }
                }

            }
            Console.WriteLine(string.Join(Environment.NewLine, peopleFromList));
        }
    }
}
