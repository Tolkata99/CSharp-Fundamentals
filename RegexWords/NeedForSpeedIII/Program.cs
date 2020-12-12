using System;
using System.Collections.Generic;
using System.Linq;

namespace NeedForSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> nameAndMile = new Dictionary<string, int>();
            Dictionary<string, int> nameAndFuel = new Dictionary<string, int>();

            int maxfuell = 75;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                int mile = int.Parse(tokens[1]);
                int fuel = int.Parse(tokens[2]);

                nameAndFuel.Add(name, fuel);
                nameAndMile.Add(name, mile);
            }

            string comands = Console.ReadLine();
            while (comands != "Stop")
            {
                string[] tokens = comands
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string comandIf = tokens[0];
                string name = tokens[1];
                if (comandIf == "Drive")
                {
                    int distance = int.Parse(tokens[2]);
                    int fuelEnd = int.Parse(tokens[3]);
                    if (nameAndFuel[name] >= fuelEnd)
                    {
                        nameAndFuel[name] -= fuelEnd;
                        nameAndMile[name] += distance;
                        Console.WriteLine($"{name} driven for {distance} kilometers. {fuelEnd} liters of fuel consumed.");
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }


                    if (nameAndMile[name] >= 100000)
                    {
                        nameAndFuel.Remove(name);
                        nameAndMile.Remove(name);
                        Console.WriteLine($"Time to sell the {name}!");
                    }

                }
                else if (comandIf == "Refuel")
                {
                    int reFuel = int.Parse(tokens[2]);

                    if (nameAndFuel[name] + reFuel >= 75)
                    {
                        int a = maxfuell - nameAndFuel[name];
                        nameAndFuel[name] = maxfuell;
                        Console.WriteLine($"{name} refueled with {a} liters");
                    }
                    else
                    {
                        nameAndFuel[name] += reFuel;
                        Console.WriteLine($"{name} refueled with {reFuel} liters");
                    }

                }
                else if (comandIf == "Revert")
                {
                    int mile = int.Parse(tokens[2]);
                    if (nameAndMile[name] >= mile)
                    {
                        nameAndMile[name] -= mile;
                        Console.WriteLine($"{name} mileage decreased by {mile} kilometers");
                    }


                    if (nameAndMile[name] < 10000)
                    {
                        nameAndMile[name] = 10000;
                    }
                }

                comands = Console.ReadLine();
            }

            foreach (var item in nameAndMile.OrderByDescending(n => n.Value).ThenBy(m => m.Key))
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value} kms, Fuel in the tank: {nameAndFuel[item.Key]} lt.");
            }
        }
    }
}
