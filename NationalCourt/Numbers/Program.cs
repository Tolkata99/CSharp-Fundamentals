using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
              .Split(" ")
              .Select(int.Parse)
              .ToList();
            int[] topFive = new int[4];
            int startIndx = 0;
          
            double average = numbers.Average();
            while (true)
            {
                
                if (average >= numbers[startIndx])
                {
                    
                    numbers.RemoveAt(startIndx);
                    
                }
                else
                {
                    if(numbers.Count >= startIndx)
                    {
                        startIndx++;
                    }
                    else
                    {
                        break;
                    }
                    
                    
                }
            }

            

            //numbers.Sort();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
