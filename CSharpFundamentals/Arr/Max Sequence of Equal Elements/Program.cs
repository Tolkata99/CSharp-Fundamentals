using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] longInteger = Console.ReadLine()
                .Split()
                .ToArray();
            int bestCount = 0;
            int bestIndex = 0;

            for (int i = 0; i < longInteger.Length; i++)
            {
                string currentElement = longInteger[i];
                int currCounter = 1;

                for (int j = i + 1; j < longInteger.Length; j++)
                {
                    if(currentElement == longInteger[i])
                    {
                        currCounter++;
                       
                    }
                    else
                    {
                        break;
                    }
                }
                if(currCounter > bestCount)
                {
                    bestCount = currCounter;
                    bestIndex = i;
                }
            }
            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(longInteger[bestIndex] + " ");
            }

        }
    }
}
