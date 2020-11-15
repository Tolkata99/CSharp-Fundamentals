using System;
using System.Collections.Generic;

namespace MIner
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> result = new Dictionary<string, int>();

            while (true)
            {
                string resoures = Console.ReadLine();
                if(resoures == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (result.ContainsKey(resoures) == false)
                {
                    result.Add(resoures, quantity);
                }
                else
                {
                    result[resoures] += quantity;
                }
                




            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
