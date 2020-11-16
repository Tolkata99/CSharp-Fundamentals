using System;
using System.Linq;

namespace Arayss
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] secondArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();


            int counter = 0;
            int firsSum = 0;
            
            for (int i = 0; i < firstArray.Length; i++)
            {
                
                
                if (firstArray[i] != secondArray[i])
                {
                    
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    
                    break;
                }
                else
                {
                    
                    firsSum += firstArray[i];
                    
                }
                counter++;
                



            }
            if(firstArray.Length == counter) 
            {
                Console.WriteLine($"Arrays are identical. Sum: {firsSum}");
            }
            

        }
    }
}
