using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                List<string> comand = Console.ReadLine()
                    .ToLower()
                    .Split()
                    .ToList();

                if(comand[0] == "end")
                {
                    break;
                }
                else if(comand[0] == "delete")
                {
                    numbers.RemoveAll(x => x == int.Parse(comand[1]));
                }
                else if(comand[0] == "insert")
                {
                    numbers.Insert(int.Parse(comand[2]), (int.Parse(comand[1])));
                }


            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
