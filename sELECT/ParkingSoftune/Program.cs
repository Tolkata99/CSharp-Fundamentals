using System;
using System.Collections.Generic;

namespace ParkingSoftune
{
    class Program
    {
        static void Main(string[] args)
        {
            var parkingUsers = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] comands = Console.ReadLine().Split();
                string register = comands[0];
                string user = comands[1];

                if(register == "register")
                {
                    if(parkingUsers.ContainsKey(user) == false)
                    {
                        parkingUsers.Add(user, comands[2]);
                        Console.WriteLine($"{user} registered {comands[2]} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {comands[2]}");
                    }
                }
                else if(register == "unregister")
                {
                    if (parkingUsers.ContainsKey(user) == false)
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{user} unregistered successfully");
                        //TODO 
                        parkingUsers.Remove(user);
                    }
                }



                
            }

            foreach (var item in parkingUsers)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

        }
    }
}
