using System;
using System.Collections.Generic;
using System.Linq;

namespace listsExersize
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int capacityOfPeople = int.Parse(Console.ReadLine());

            string comand = Console.ReadLine();
            while (comand != "end")
            {
                string[] cmdArk = comand.Split();


                if (cmdArk[0] == "Add")
                {
                    wagons.Add(int.Parse(cmdArk[1]));
                }
                else
                {
                    if (cmdArk[0] == "end")
                    {
                        break;
                    }

                    int passagers = int.Parse(Console.ReadLine());

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int currWagon = wagons[i];
                        bool isEnoughSpace = currWagon + passagers <= capacityOfPeople;

                        if (isEnoughSpace)
                        {
                            wagons[i] += passagers;
                            break;
                        }
                    }

                }
                comand = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
