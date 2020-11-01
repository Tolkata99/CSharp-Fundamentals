using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veihical_Cataloge
{

    class Program
    {
        public class Veihical
        {
            public Veihical(string type, string model, string color, int hp)
            {
                this.Type = type;
                this.Model = model;
                this.Color = color;
                this.HorsePower = hp;

            }

            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }
        }

        static void Main(string[] args)
        {
            List<Veihical> veihicals = new List<Veihical>();

            string input = Console.ReadLine().ToLower();
            while (input != "end")
            {
                List<string> comands = input.Split().ToList();
                
                string type = comands[0];
                string model = comands[1];
                
                string color = comands[2];
                int hp = int.Parse(comands[3]);

                Veihical veihical = new Veihical(type, model, color, hp);

                veihicals.Add(veihical);

                input = Console.ReadLine().ToLower();
            }
            string inputTwo = Console.ReadLine().ToLower();

            StringBuilder sb = new StringBuilder();

            while (inputTwo != "close the catalogue")
            {
                List<Veihical> currentCars = veihicals.Where(x => x.Model == inputTwo).ToList();
                foreach (Veihical car in currentCars)
                {
                    sb.AppendLine($"Type: {car.Type}");
                    sb.AppendLine($"Model: {car.Model}");
                    sb.AppendLine($"Color: {car.Color}");
                    sb.AppendLine($"Horsepower: {car.HorsePower}");
                    Console.WriteLine(sb.ToString());
                    sb.Clear();
                }


                inputTwo = Console.ReadLine().ToLower();
            }

            List<Veihical> cars = veihicals.Where(x => x.Type == "car").ToList();
            List<Veihical> truck = veihicals.Where(x => x.Type == "truck").ToList();

            double avgHorsPowerCars = cars.Average(x => x.HorsePower);
            double avgHorsPowertruck = truck.Average(x => x.HorsePower);

            
            Console.WriteLine($"Cars have average horsepower of: {avgHorsPowerCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avgHorsPowertruck:f2}.");
        }
    }
}
