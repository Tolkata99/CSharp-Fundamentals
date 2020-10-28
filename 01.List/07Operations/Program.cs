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
                else if (comand[0] == "CONTAINS")
                {
                    Console.WriteLine((numbers.Contains(int.Parse(comand[1]))) ? "Yes" : "No such number");
                }
                else if (comand[0] == "PRINTEVEN")
                {
                    Console.WriteLine(string.Join(" ", numbers
                        .Where(n => n % 2 == 0)));
                }
                else if (comand[0] == "PRINTODD")
                {
                    Console.WriteLine(string.Join(" ", numbers
                        .Where(n => n % 2 == 1)));
                }
                else if (comand[0] == "GETSUM")
                {
                    Console.Write(numbers.Sum());
                    Console.WriteLine();
                }
                else if (comand[0] == "FILTER")
                {

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (comand[1] == ">=")
                        {
                            if (numbers[i] >= (int.Parse(comand[2])))
                            {
                                Console.Write(numbers[i] + " ");

                            }

                        }
                        else if (comand[1] == "<")
                        {
                            if (numbers[i] < (int.Parse(comand[2])))
                            {
                                Console.Write(numbers[i] + " ");

                            }

                        }
                        else if (comand[1] == ">")
                        {
                            if (numbers[i] > (int.Parse(comand[2])))
                            {
                                Console.Write(numbers[i] + " ");

                            }
                        }
                        else if (comand[1] == "<")
                        {
                            if (numbers[i] <= (int.Parse(comand[2])))
                            {
                                Console.Write(numbers[i] + " ");

                            }

                        }


                    }
                    Console.WriteLine();
                }



            }


        }
    }
}
