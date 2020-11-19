using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyId = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] comand = Console.ReadLine().Split(" -> ");
                if (comand[0] == "End")
                {
                    break;
                }
                string ID = comand[1];
                if (companyId.ContainsKey(comand[0]) == false)
                {
                    companyId.Add(comand[0], new List<string>());
                }

                if (companyId[comand[0]].Contains(ID) == false)
                {
                    companyId[comand[0]].Add(ID);
                }



            }

            foreach (var item in companyId.OrderBy(n => n.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var employees in item.Value)
                {
                    Console.WriteLine($" -- {employees}");
                }
            }


        }
    }
}
