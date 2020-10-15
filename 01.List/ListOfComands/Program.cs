using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfComands
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
                string[] comand = Console.ReadLine()
                    .ToUpper()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (comand[0] == "END")
                {
                    break;
                }


                if (comand[0] == "ADD")
                {
                    numbers.Add(int.Parse(comand[1]));
                }
                else if (comand[0] == "REMOVE")
                {
                    numbers.Remove(int.Parse(comand[1]));
                }
                else if (comand[0] == "REMOVEAT")
                {
                    numbers.RemoveAt(int.Parse(comand[1]));
                }
                else if (comand[0] == "INSERT")
                {
                    numbers.Insert(int.Parse(comand[2]), (int.Parse(comand[1])));
                }
                

            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
