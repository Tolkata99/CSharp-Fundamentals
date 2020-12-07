using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> plantNameAverageRating = new Dictionary<string, List<double>>();

            Dictionary<string, int> plantNameRarity = new Dictionary<string, int>();

            var plantn = new Dictionary<int, double>();



            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plantName = tokens[0];
                int rarity = int.Parse(tokens[1]);

                plantNameRarity.Add(plantName, rarity);

            }

            string cmdArg = Console.ReadLine();
            while ("Exhibition" != cmdArg)
            {
                string[] tokens = cmdArg
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string[] comand = tokens[0].Split(":");
                string comandIf = comand[0];
                string plant = comand[1].Trim();

                if (comandIf == "Rate")
                {
                    int rating = int.Parse(tokens[1]);
                    if (plantNameAverageRating.ContainsKey(plant) == false)
                    {
                        plantNameAverageRating.Add(plant, new List<double>());
                    }
                    plantNameAverageRating[plant].Add(rating);
                }
                else if (comandIf == "Update")
                {
                    int rarity = int.Parse(tokens[1]);
                    plantNameRarity[plant] = rarity;

                }
                else if (comandIf == "Reset")
                {
                    plantNameAverageRating[plant].RemoveAll(c => c == c);
                    plantNameAverageRating[plant].Add(0);
                }
                else
                {
                    Console.WriteLine("error");
                }



                cmdArg = Console.ReadLine();
            }


            Console.WriteLine("Plants for the exhibition:");
            double average = 0;
            foreach (var item in plantNameRarity)
            {
                average = plantNameAverageRating[item.Key].Average();
                plantn.Add(item.Value, average);
            }
            List<string> ress = new List<string>();
            foreach (var item in plantNameRarity)
            {
                ress.Add(item.Key);
            }

            ress.OrderBy(x => x);
            int n1 = 0;
            string result = string.Empty;
            foreach (var iddtem in plantNameRarity)
            {
                foreach (var item in plantn.OrderByDescending(x => x.Key).ThenByDescending(s => s.Value))
                {
                    Console.WriteLine($"- {iddtem.Key}; Rarity: {item.Key}; Rating: {item.Value:f2}");
                    break
                }
                
               
            }
        }
    }
}
