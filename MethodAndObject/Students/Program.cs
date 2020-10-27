using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Students> students = new List<Students>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string firstName = tokens[0];
                string lastName = tokens[1];
                double grade = double.Parse(tokens[2]);

                Students student = new Students(firstName, lastName, grade);

                students.Add(student);
                

            }
            students = students.OrderByDescending(x => x.Grade).ToList();

            foreach (Students item in students)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Students
    {
        public Students(string firstName,string lastName,double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}
