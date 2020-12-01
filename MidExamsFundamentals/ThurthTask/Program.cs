using System;
using System.Collections.Generic;
using System.Linq;

namespace ThurthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lists = Console.ReadLine()
                                     .Split()
                                     .Select(int.Parse)
                                     .ToList();
            

            int[] left = new int[lists.Count];
            int[] right = new int[lists.Count];



            int entryPoint = int.Parse(Console.ReadLine());
            int entryPoints = 0;
            string typeOfItems = Console.ReadLine();
            double totalLeft = 0;
            double totalRihth = 0;
            int counter = 0;
            for (int i = entryPoint; i < lists.Count; i++)
            {
               
                if(counter == 0)
                {
                    entryPoints = lists[i];
                }
                counter++;
                for (int j = 0; j < lists.Count; j++)
                {
                    left[j] = lists[i];
                }
               
            }
            int counter1 = 0;
            for (int i = lists.Count - 1; i > entryPoint; i--)
            {
                
                if (counter1 == 0)
                {
                    entryPoints = lists[i];
                }
                counter++;
                for (int b = 0; b < lists.Count; b++)
                {
                    right[b] = lists[i];
                }
                
            }

           ///Console.WriteLine(string.Join(" ",left));
           ///Console.WriteLine(string.Join(" ",right));
           ///



            if (typeOfItems == "cheap")
            {
             
            }
            else if (typeOfItems == "expensive")
            {
                
            }
            string typePriceRating = Console.ReadLine();
            if (typePriceRating == "positive")
            {

            }
            else if(typePriceRating == "negative")
            {

            }
            else if(typePriceRating == "all")
            {

            }

            if(totalLeft < totalRihth)
            {
                  Console.WriteLine("Left - 1");
            }
            else
            {
              Console.WriteLine("Left - 1");
            }
        }
    }
}
