using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopingList
{
    class Program
    {
        static void Main(string[] args)
        {
             List<string> listsFood = Console.ReadLine()
                .Split("!")
                .ToList();
            string input = Console.ReadLine();
            while (input != "Go Shopping!")
            {
                string[] tokens = input.Split(" "); 
                string comandFirst = tokens[0];              
                string comandSecond = tokens[1];

                if (comandFirst == "Urgent")
                {
                    bool isHave = listsFood.Contains(comandSecond);
                    if (!isHave)
                    {
                        listsFood.Insert(0, comandSecond);
                    }
                    
                }
                else if (comandFirst == "Unnecessary")
                {
                    bool isHave = listsFood.Contains(comandSecond);
                    if (isHave)
                    {
                        listsFood.Remove(comandSecond);
                    }
                }
                else if (comandFirst == "Correct")
                {
                    bool isHave = listsFood.Contains(comandSecond);
                    
                    if (isHave)
                    {
                        int index = listsFood.IndexOf(comandSecond);
                        listsFood.Remove(comandSecond);
                        listsFood.Insert(index, tokens[2]);
                    }

                    
                }
                else if (comandFirst == "Rearrange")
                {
                    bool isHave = listsFood.Contains(comandSecond);
                    if(isHave)
                    {
                        listsFood.Remove(comandSecond);
                        listsFood.Add(comandSecond);

                    }
                    
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",listsFood));
        }
    }
}
