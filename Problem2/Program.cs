using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysAdventures = int.Parse(Console.ReadLine());
            int numPlayers = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());

            double water = double.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());

            double totalWater = daysAdventures * water * numPlayers;
            double totalFood = daysAdventures * food * numPlayers;

            for (int i = 1; i < daysAdventures + 1; i++)
            {
                double currEnergy = double.Parse(Console.ReadLine());
                energy -= currEnergy;
                if(energy <= 0)
                {
                    break;
                }
                if(i % 2 == 0)
                {
                    energy += energy * 0.05;
                    totalWater -= totalWater * 0.30;
                }
                if(i % 3 == 0)
                {
                    totalFood -= totalFood / numPlayers;
                    energy += energy * 0.10;

                }


            }

            if(energy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
            }


        }
    }
}
