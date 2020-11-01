using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exams2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<people> peoples = new List<people>();

            StringBuilder sb = new StringBuilder();
            while (true)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                string p1 = input[0];
                if(p1 == "end")
                {
                    break;
                }
                int p2 = int.Parse(input[1]);
                int p3 = int.Parse(input[2]);

                people peopless = new people(p1, p2, p3);

                peoples.Add(peopless);

                Console.WriteLine($"{p1} with ID: {p2} is {p3} years old.");
                
            }


            


        }
    }
    class people
    {
        public people(string firstName, int id, int age)
        {
            this.FirstName = firstName;
            this.Id = id;
            this.Age = age;
        }

        public string FirstName { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }



    }
}
