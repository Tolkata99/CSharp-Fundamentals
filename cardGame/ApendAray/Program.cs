using System;
using System.Collections.Generic;
using System.Linq;

namespace ApendAray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            list.Reverse();

            string[] reversArrayFromList = new string[list.Count];
            foreach (var item in list)
            {
                int currentNumber = list[item];

                reversArrayFromList[item] = list[item];
            }
            

            Console.WriteLine(string.Join("", reversArrayFromList));
                
        }
    }
}
