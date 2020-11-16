using System;
using System.Linq;

namespace MagichSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split(" ")
                               .Select(int.Parse)
                               .ToArray();
            int currNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                for (int J = i + 1; J < arr.Length; J++)
                {
                    int sum = arr[i] + arr[J];

                    if(sum == currNum)
                    {
                        Console.WriteLine(string.Join(" ",arr[i],arr[J]));
                    }


                }
            }





        }
    }
}
