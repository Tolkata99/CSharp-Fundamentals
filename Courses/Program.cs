using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] comands = Console.ReadLine().Split(" : ");
                string study = comands[0];
                if (study == "end")
                {
                    break;
                }
                string user = comands[1];

                if (courses.ContainsKey(study) == false)
                {
                    courses.Add(study, new List<string>());
                }
                courses[study].Add(user);


            }


            foreach (var item in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");


                foreach (var user in item.Value.OrderBy(x => x))
                {

                    Console.WriteLine($"-- {user}");
                }


            }
        }
    }
}
