using System;
using System.Collections.Generic;
using System.Linq;

namespace movingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> movingTar = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string comad = Console.ReadLine();
            while (comad != "End")
            {
                string[] tokens = comad.Split();
                string comandIf = tokens[0];
                if (comandIf == "Shoot")
                {
                    int index = int.Parse(tokens[1]);
                    int power = int.Parse(tokens[2]);
                    if (movingTar.Count >= index && 0 <= index)
                    {
                        movingTar[index] -= power;
                    }
                    for (int i = 0; i < movingTar.Count; i++)
                    {
                        if (movingTar[i] <= 0)
                        {
                            movingTar.Remove(movingTar[i]);
                        }
                    }
                }
                else if (comandIf == "Add")
                {
                    int index = int.Parse(tokens[1]);
                    int value = int.Parse(tokens[2]);
                    if (movingTar.Count >= index && 0 <= index)
                    {
                        movingTar.Insert(index, value);///greshka
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (comandIf == "Strike")
                {
                    int index = int.Parse(tokens[1]);
                    int radius = int.Parse(tokens[2]);
                    int left = index - radius;
                    int right = index + radius;
                    
                    int start = index - radius;
                    int end = index + radius;
                    if (start >= 0 && end < movingTar.Count)
                    {
                        movingTar.RemoveRange(start, end - start + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                    //if (left >= 0 && right <= movingTar.Count)
                    //{
                    //    int count = (right - left) + 1;
                    //    movingTar.RemoveRange(left, count);
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Strike missed!");
                    //}
                }
                comad = Console.ReadLine();
            }
            Console.WriteLine(string.Join("|", movingTar));
        }
    }
}
