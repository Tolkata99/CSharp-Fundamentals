using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
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
                    .ToUpper()
                    .Split()
                    .ToList();

                
                if(comand[0] == "END")
                {
                    break;
                }
                else if(comand[0] == "ADD")
                {
                    numbers.Add(int.Parse(comand[1]));
                }
                else if (comand[0] == "INSERT")
                {
                    int index = int.Parse(comand[2]);
                    int number = int.Parse(comand[1]);
                                 //Index
                    if(IsValidIndex(index, numbers.Count))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, number);
                    }

                }
                else if (comand[0] == "REMOVE")
                {
                    int index = (int.Parse(comand[1]));
                    if (IsValidIndex(index, numbers.Count))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                     
                    
                }
                else if (comand[0] == "SHIFT" )
                {
                    int rotation = (int.Parse(comand[2]));
                    if (comand[1] == "RIGHT")
                    {
                        for (int i = 0; i < rotation; i++)
                        {
                            int firstListNumber = numbers[0];
                            for (int j = 0; j < numbers.Count - 1; j++)
                            {
                                numbers[j] = numbers[j + 1];
                            }
                            numbers[numbers.Count - 1] = firstListNumber;
                        }
                    }
                    else if(comand[1] == "LEFT")
                    {

                        for (int i = 0; i < rotation; i++)
                        {
                            int lastNumber = numbers[numbers.Count - 1];
                            for (int j = numbers.Count - 1; j > 0; j--)
                            {
                                numbers[j] = numbers[j - 1];

                            }
                            numbers[0] = lastNumber;
                        }
                    }
                    
                }
                

            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        

        public static bool IsValidIndex(int index, int count)
        {
            return index > count || index < 0;
        }

    }
}
