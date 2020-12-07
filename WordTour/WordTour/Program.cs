using System;

namespace WordTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string traveling = Console.ReadLine();


            string cmdArg = Console.ReadLine();
            while (cmdArg != "Travel")
            {
                string[] tokens = cmdArg.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string cmdIf = tokens[0];
                if (cmdIf == "Add Stop")
                {
                    traveling = traveling.Insert(int.Parse(tokens[1]), tokens[2]);
                    Console.WriteLine(traveling);
                }
                else if (cmdIf == "Remove Stop")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    if (startIndex <= traveling.Length 
                        && endIndex <= traveling.Length 
                        && startIndex >= 0
                        && endIndex >= 0)
                    {
                        int count = (endIndex - startIndex) + 1;
                        traveling = traveling.Remove(startIndex, count);
                    }


                    Console.WriteLine(traveling);
                }
                else if (cmdIf == "Switch")
                {
                    string oldString = tokens[1];
                    string NewString = tokens[2];

                    if (traveling.Contains(oldString))
                    {
                        traveling = traveling.Replace(oldString, NewString);
                        Console.WriteLine(traveling);
                    }
                }



                cmdArg = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {traveling}");
        }
    }
}
