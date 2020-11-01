using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> craft = Console.ReadLine().Trim()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();


            while (true)
            {

                List<string> comands = Console.ReadLine()
                .Split("-")
                .ToList();
                string comand0 = comands[0].Trim();
                //string comand1 = comands[1].Trim();
                //string comand2 = comands[2].Trim();
                if (comand0 == "Craft!")
                {
                    break;
                }

                List<string> comand = comands[1].Split(":").ToList();


                if (comand0 == "Collect")
                {
                    bool isHave = craft.Contains(comands[1].Trim());
                    if (!isHave)
                    {
                        craft.Add(comands[1].Trim());
                    }

                }
                else if (comand0 == "Combine Items")
                {
                    bool isHave = craft.Contains(comand[0].Trim());
                    int index = craft.IndexOf(comand[0].Trim());
                    if (isHave)
                    {

                        craft.Insert(index, comand[1]);
                    }
                }
                else if (comand0 == "Renew")
                {
                    bool isHave = craft.Contains(comands[1].Trim());
                    if (isHave)
                    {
                        craft.Remove(comands[1].Trim());
                        craft.Add(comands[1].Trim());

                    }

                }
                else if (comand0 == "Drop")
                {
                    bool isHave = craft.Contains(comands[1].Trim());
                    if (isHave)
                    {
                        craft.Remove(comands[1].Trim());
                    }
                }


            }
            Console.WriteLine(string.Join(" ", craft));
        }
    }
}
