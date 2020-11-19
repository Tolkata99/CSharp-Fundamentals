using System;
using System.Collections.Generic;
using System.Linq;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> students = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            while (input != "exam finished")
            {
                string[] cmd = input.Split("-");
                string name = cmd[0];
                string language = cmd[1];
                if (cmd.Length > 2)
                {
                    
                    int points = int.Parse(cmd[2]);
                    if(students.ContainsKey(name) == false)
                    {
                        students.Add(name, points);
                    }
                    else
                    {
                        if(students[name] < points)
                        {
                            students[name] = points;
                        }
                    }
                }
                else
                {
                    students.Remove(name);
                    
                }
                if(language != "banned")
                {
                    if (submissions.ContainsKey(language) == false)
                    {
                        submissions.Add(language, 0);
                    }
                    submissions[language]++;

                    
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");
            foreach (var item in students.OrderByDescending(n => n.Value).ThenBy(n =>n.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
                
            }
            Console.WriteLine("Submissions:");
            foreach (var item in submissions.OrderByDescending(n => n.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

        }
    }
}
