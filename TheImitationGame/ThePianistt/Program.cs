using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> pieceAndComposer = new Dictionary<string, string>();
            
            Dictionary<string, string> pieceAndKey = new Dictionary<string, string>();
           

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string piece = tokens[0];
                string composer = tokens[1];
                string key = tokens[2];

                pieceAndComposer[piece] = composer;
                pieceAndKey[piece] = key;
            }

            string comand = Console.ReadLine();
            while (comand != "Stop")
            {
                string[] tokens = comand
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string ifComand = tokens[0];
                string piece = tokens[1];

                if (ifComand == "Add")
                {
                    string key = tokens[3];
                    string composer = tokens[2];
                    if (pieceAndComposer.ContainsKey(piece) == false)
                    {
                        pieceAndComposer[piece] = composer;
                        pieceAndKey[piece] = key;
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (ifComand == "Remove")
                {
                    if (pieceAndComposer.ContainsKey(piece) == false)
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                    else
                    {
                        pieceAndComposer.Remove(piece);
                        pieceAndKey.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                }
                else if (ifComand == "ChangeKey")
                {
                    string newKey = tokens[2];

                    if (pieceAndComposer.ContainsKey(piece) == false)
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                    else
                    {

                        pieceAndKey[piece] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                }
                comand = Console.ReadLine();
            }

            pieceAndComposer = pieceAndComposer
                .OrderBy(n => n.Key)
                .ThenBy(c => c.Value)
                .ToDictionary(t => t.Key, k => k.Value);

            foreach (var k in pieceAndComposer)
            {
                Console.WriteLine($"{k.Key} -> Composer: {k.Value}, Key: {pieceAndKey[k.Key]}");
                
            }


        }
    }
}
