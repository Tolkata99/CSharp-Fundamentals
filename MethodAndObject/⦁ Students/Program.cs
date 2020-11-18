using System;
using System.Collections.Generic;
using System.Linq;

namespace __Students
{

    public class Startup
    {


        public static void Main()
        {
            List<Student> students = new List<Student>();
            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] tokens = line.Split();
                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string city = tokens[3];

                Student student = new Student(firstName, lastName, age, city);
                

                students.Add(student);
                line = Console.ReadLine();


            }
            string filterSity = Console.ReadLine();

            //foreach (Student student in students)
            //{
            //    if(student.City == filterSity)
            //    {
            //        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            //    }

            //}

            List<Student> filterStudents = students
                .Where(a => a.City == filterSity)
                .ToList();

            foreach (Student student in filterStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }


        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}

