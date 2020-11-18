using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;
using System;
using System.Collections.Generic;
using System.Linq;

namespace item
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isbreak = false;
            Dictionary<string, int> result = new Dictionary<string, int>();
            Dictionary<string, int> junkes = new Dictionary<string, int>();
            result["motes"] = 0;
            result["shards"] = 0;
            result["fragments"] = 0;


            while (true)
            {
                int countScore = 0;
                int countStones = 1;
                string[] input = Console.ReadLine()
                    .ToLower()
                    .Split()
                    .ToArray();
                int forCount = input.Length / 2;
                for (int i = 0; i < forCount; i++)
                {
                    string stones = string.Empty;
                    int score = 0;




                    score = int.Parse(input[countScore]);
                    countScore += 2;



                    stones = input[countStones];
                    countStones += 2;






                    if (stones == "fragments" || stones == "shards" || stones == "motes")
                    {
                        result[stones] += score;
                    }
                    else
                    {
                        junkes.Add(stones, 0);
                        junkes[stones] += score;
                    }

                    foreach (var item in result)
                    {
                        if (item.Key == "fragments")
                        {
                            if (item.Value >= 250)
                            {
                                Console.WriteLine("Valanyr obtained!");
                                result["fragments"] -= 250;
                                isbreak = true;
                                break;

                            }

                        }
                        else if (item.Key == "motes")
                        {
                            if (item.Value >= 250)
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                                result["motes"] -= 250;
                                isbreak = true;
                                break;
                            }
                        }
                        else if (item.Key == "shards")
                        {
                            if (item.Value >= 250)
                            {
                                Console.WriteLine("Shadowmourne  obtained!");
                                result["shards"] -= 250;
                                isbreak = true;
                                break;
                            }
                        }

                    }
                    if (isbreak)
                    {
                        break;
                    }
                }

                if (isbreak)
                {
                    break;
                }





            }
            Dictionary<string, int> resultFiltered = result
                .OrderByDescending(v => v.Value )
                .ThenBy(k => k.Key)
                .ToDictionary(a => a.Key,a => a.Value);

            Dictionary<string, int> resultJunkes = junkes
                .OrderBy(n => n.Key)
                .ThenBy(v => v.Value)
                .ToDictionary(d => d.Key, v => v.Value);
            foreach (var item in resultFiltered)
            {


                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in resultJunkes)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
