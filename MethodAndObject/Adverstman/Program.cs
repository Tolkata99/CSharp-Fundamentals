﻿using System;

namespace Adverstman
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Phrases = { "Excellent product."
                      , "Such a great product."
                      , "I always use that product."
                      , "Best product of its category."
                      , "Exceptional product."
                      , "I can’t live without this product."};

            string[] Events = { "Now I feel good."
                      , "I have succeeded with this product."
                      , "Makes miracles. I am happy of the results!"
                      , "I cannot believe but now I feel awesome."
                      , "Try it yourself, I am very satisfied."
                      , "I feel great!"};


            string[] Authors = { "Diana", "Petya", "Stella", "Elena"
                      , "Katya", "Iva", "Annie", "Eva" };


            string[] Cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Random rnd = new Random();

                string messige = Phrases[rnd.Next(0, Phrases.Length)];
                string evens = Events[rnd.Next(0, Events.Length)];
                string author = Authors[rnd.Next(0, Authors.Length)];
                string city = Cities[rnd.Next(0, Cities.Length)];

                Console.WriteLine($"{messige} {evens} {author} - {city}.");
            }


        }
    }
}
