using System;
using System.Linq;

namespace RetakeExamMid
{
    class Program
    {
        static void Main(string[] args)
        {
            var shelfBook = Console.ReadLine()
                .Split("&", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string comands = Console.ReadLine();
            while (comands != "Done")
            {
                string[] tokens = comands.Split(" | ");
                string comandIf = tokens[0];
                if (comandIf == "Add Book")
                {
                    if (shelfBook.Contains(tokens[1]) == false)
                    {
                        shelfBook.Insert(0,tokens[1]);
                    }
                }
                else if (comandIf == "Take Book")
                {
                    if (shelfBook.Contains(tokens[1]))
                    {
                        shelfBook.Remove(tokens[1]);
                    }
                }
                else if (comandIf == "Swap Books")
                {
                    string first = tokens[1];
                    string second = tokens[2];
                    if (shelfBook.Contains(first) && shelfBook.Contains(second))
                    {
                        int index1 = shelfBook.IndexOf(first);
                        int index2 = shelfBook.IndexOf(second);

                        shelfBook.RemoveAt(index1);
                        shelfBook.Insert(index1, second);

                        shelfBook.RemoveAt(index2);
                        shelfBook.Insert(index2, first);
                    }
                    
                }
                else if (comandIf == "Insert Book")
                {
                    shelfBook.Insert(shelfBook.Count, tokens[1]);

                }
                else if (comandIf == "Check Book")
                {
                    int count = int.Parse((tokens[1]));
                    if(count >= 0 && count <= shelfBook.Count)
                    {
                        Console.WriteLine(shelfBook[count]);
                    }
                   
                }
                comands = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",shelfBook));
        }
    }
}
