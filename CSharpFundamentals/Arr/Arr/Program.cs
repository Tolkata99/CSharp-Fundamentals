using System;
using System.Linq;

namespace dayOfWeek
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] arr1 = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();
            int curNum = 0;
            bool isBigger = true;
            for (int i = 0; i < arr1.Length; i++)
            {
                int currentNumber = arr1[i];
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if(arr1[j] >= currentNumber)
                    {
                        isBigger = false;
                        break;
                    }
                    

                }
                if(isBigger)
                    Console.Write(currentNumber + " ");

                isBigger = true;
                
            }

        }
    }
}
