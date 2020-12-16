using System;
using System.Collections.Generic;
using System.Linq;

namespace TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWait = int.Parse(Console.ReadLine());

            int[] placesWagon = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < placesWagon.Length && peopleWait > 0; i++)
            {
                int seats = Math.Min(4 - placesWagon[i], peopleWait);
                placesWagon[i] += seats;


                peopleWait -= seats;
                
            }
            
            if(placesWagon[placesWagon.Length - 1] < 4)
            {
                Console.WriteLine("The lift has empty spots!");
            }    
            else if(peopleWait > 0)
            {
                Console.WriteLine($"There isn't enough space! {peopleWait} people in a queue!");
            }


            Console.WriteLine(string.Join(" ",placesWagon));

        }
    }
}
