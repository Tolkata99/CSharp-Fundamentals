using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> productsAndPrices = new Dictionary<string, List<double>>();

           while (true)
           {
               string[] input = Console.ReadLine().Split().ToArray();
               string product = input[0];
               if (product == "buy")
               {
                   break;
               }
               double price = double.Parse(input[1]);
               int number = int.Parse(input[2]);

                List<double> totalPrice = new List<double> { price, number };
               if (productsAndPrices.ContainsKey(product) == false)
               {
                    
                   productsAndPrices.Add(product, totalPrice);
               }
               else
               {
                   productsAndPrices[product][0] = price;
                    productsAndPrices[product][1] += number;
                }
           
           
           
           
           
           
           }
           foreach (var item in productsAndPrices)
           {
               string product = item.Key;
               double totPrice = item.Value[0] * item.Value[1];
           
               Console.WriteLine($"{product} -> {totPrice:f2}");
           }
        }  
    }      
}          
