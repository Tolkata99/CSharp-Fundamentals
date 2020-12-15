using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayModificer
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string comands = Console.ReadLine();
            while (comands != "end")
            {
                string[] tokens = comands.Split();
                string comandIf = tokens[0];
                if (comandIf == "swap")
                {
                    int index1 = int.Parse(tokens[1]);
                    int index2 = int.Parse(tokens[2]);

                    int old = list[index1];
                    int newWord = list[index2];

                    list.RemoveAt(index1);
                    list.Insert(index1,newWord);

                    list.RemoveAt(index2);
                    list.Insert(index2, old);
                    //Console.WriteLine(string.Join(", ", list));
                }
                else if (comandIf == "multiply")
                {
                    int index1 = int.Parse(tokens[1]);
                    int index2 = int.Parse(tokens[2]);

                    int ind1 = list[index1];
                    int ind2 = list[index2];
                    int insert = ind1 * ind2; // greshka

                    list.RemoveAt(index1);
                    //list.RemoveAt(index2);

                    list.Insert(index1, insert);
                    //Console.WriteLine(string.Join(", ", list));

                }
                else if (comandIf == "decrease")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i] -= 1;
                    }
                }



                comands = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ",list));
        }

    }
}
