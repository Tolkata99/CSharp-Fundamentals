using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> craft = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();


            while (true)
            {
                List<string> comands = Console.ReadLine()
                .Split("-")
                .ToList();
                string[] comand1 = comands[0].Split(":");

                if(comand1 == "Craft!")
                {
                    break;
                }
                else if(comand1 == "Collect")
                {
                    bool isHave = craft.Contains(comands[1]);
                    if(!isHave)
                    {
                        craft.Add(comands[1]);
                    }

                }
                else if (comand1 == "Combine Items  ")
                {
                    bool isHave = craft.Contains(comands[1]);
                    if(isHave)
                    {

                        craft.Insert(1, comands[2]);
                    }
                }
                else if (comand1 == "Renew ")
                {
                    bool isHave = craft.Contains(comands[1]);
                    if(isHave)
                    {
                        craft.Remove(comands[1]);
                        craft.Add(comands[1]);

                    }

                }
                else if (comand1 == "Drop")
                {
                    bool isHave = craft.Contains(comands[1]);
                    if(isHave)
                    {
                        craft.Remove(comands[1]);
                    }
                }


            }
            Console.WriteLine(string.Join(" ",craft));
        }
    }
}
