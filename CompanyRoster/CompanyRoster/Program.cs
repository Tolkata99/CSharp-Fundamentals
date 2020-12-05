using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Company> compa = new List<Company>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                double salary = double.Parse(tokens[1]);
                string position = tokens[2];

                Company company = new Company(name, salary, position);

                compa.Add(company);

            }

            double max = 0;
            string positio = string.Empty;
            double min = 0;
            string minpositio = string.Empty;
            string maxName = string.Empty;
            string minName = string.Empty;
            foreach (Company d in compa.OrderByDescending(n => n.Salary))
            {
                string firs = d.Position;
                if(firs == d.Position)
                {
                    Console.WriteLine($"Highest Average Salary: {d.Position}");
                    Console.WriteLine($"Ivan {d.Salary}");
                }
               
            }
            
        }
    }
    class Company
    {
        public Company(string name, double salary, string position)
        {
            Name = name;
            Salary = salary;
            Position = position;
        }

        public string Name { get; set; }
        public double Salary { get; set; }
        public string Position { get; set; }


    }
}
