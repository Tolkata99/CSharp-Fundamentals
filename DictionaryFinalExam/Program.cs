using System;
using System.Collections.Generic;
using System.Linq;

namespace AnatoliForSoftuni
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<int, int>> pirates = new Dictionary<string, Dictionary<int, int>>();
            Dictionary<string, int> keyValue = new Dictionary<string, int>(); 
            string[] comands = Console.ReadLine()
                .Split("||", StringSplitOptions.RemoveEmptyEntries);

            while (comands[0] != "Sail")
            {
                if (pirates.ContainsKey(comands[0]) == false)
                {
                    int naselenie = int.Parse(comands[1]);
                    int gold = int.Parse(comands[2]);
                    pirates.Add(comands[0], new Dictionary<int, int>());
                    pirates[comands[0]].Add(naselenie, gold);
                    keyValue.Add(comands[0], naselenie;

                }
                else
                {
                    
                    int naselenie = int.Parse(comands[1]);
                    int gold = int.Parse(comands[2]);
                    int key = 0;

                    foreach (var item in pirates[comands[0]])
                    {
                        key = item.Key;

                    }

                    pirates[comands[0]][key] += gold;
                    keyValue[comands[1]] += naselenie;
                }
                comands = Console.ReadLine()
                .Split("||", StringSplitOptions.RemoveEmptyEntries);
            }
            string[] tokens = Console.ReadLine()
                .Split("=>", StringSplitOptions.RemoveEmptyEntries);

            while (tokens[0] != "End")
            {
                if (tokens[0] == "Plunder")
                {
                    string town = tokens[1];
                    int people = int.Parse(tokens[2]);
                    int gold = int.Parse(tokens[3]);

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    int key = 0;
                    int value = 0;
                    foreach (var item in pirates[town])
                    {
                        key = item.Key;
                        value = item.Value;
                    }
                   
                    pirates[town][key] -= gold;
                    keyValue[town] -= people;
                    if (key <= 0 || pirates[town][key] <= 0 || keyValue[town] <= 0)
                    {
                        pirates.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }

                }
                else if (tokens[0] == "Prosper")
                {
                    string town = tokens[1];
                    int gold = int.Parse(tokens[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                    else
                    {
                        int key = 0;
                        int totalGold = 0;
                        foreach (var item in pirates[town])
                        {
                            key = item.Key;
                        }
                        pirates[town][key] += gold;
                        foreach (var item in pirates[town])
                        {

                            totalGold = item.Value;
                        }

                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {totalGold} gold.");

                    }
                }



                tokens = Console.ReadLine()
                .Split("=>", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"Ahoy, Captain! There are {pirates.Count} wealthy settlements to go to:");

            pirates = pirates.OrderByDescending(x => x.Value.Values.Sum()).
    ToDictionary(x => x.Key,
    x => x.Value.OrderByDescending(y => y.Value).ToDictionary(y => y.Key, y => y.Value));

            foreach (var one in pirates)
            {
                string key = one.Key;
                foreach (var dic2 in pirates[key])
                {

                    foreach (var naselenie in keyValue)
                    {
                        Console.WriteLine($"{key} -> Population: {naselenie.Value} citizens, Gold: {dic2.Value} kg");
                    }
                }
            }

        }
    }
}