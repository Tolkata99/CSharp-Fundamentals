using System;
using System.Collections.Generic;
using System.Linq;

namespace Archery_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> scoreIskren = Console.ReadLine()
                                           .Split("|")
                                           .Select(int.Parse)
                                           .ToList();

            string comand = Console.ReadLine();
            while (comand != "Game over")
            {
                string[] argComands = comand.Split("@");
                string shot = argComands[0];
                int Startindex = int.Parse(argComands[1]);
                int length = int.Parse(argComands[2]);

                if (shot == "Shoot Left")
                {
                    for (int i = Startindex; i < length; i++)
                    {

                        scoreIskren[i] -= 5;
                    }
                }
                else if (shot == "Shoot Right")
                {
                    for (int i = length - 1; i >= Startindex; i--)
                    {
                        scoreIskren[i] -= 5;
                    }
                }
                else if (shot == "Reverse")
                {
                    scoreIskren.Reverse();
                }


                comand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", scoreIskren));

        }
    }
}
