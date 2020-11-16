using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] train = new int[n];
            int sumPeople = 0;
            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                train[i] += currentNum;


                sumPeople += currentNum;
                
            }
            
            Console.WriteLine(string.Join(" ", train));
            Console.WriteLine(sumPeople);
            
        }
    }
}
