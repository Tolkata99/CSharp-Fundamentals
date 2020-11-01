using System;
using System.Collections.Generic;
using System.Text;

namespace Veihical_Cataloge
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
}
