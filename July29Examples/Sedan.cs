using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace July29Examples
{
    public class Sedan : Automobile
    {
        public override string Make { get; set; }
        protected override string Model { get; set; }
        public int Tires { get; set; }

        public override void Build()
        {
            var numberOfTires = CreateTires();
            Console.WriteLine($"I have built a sedan with: {Make} and {Model}, with tires : {Tires}");
        }

        public Sedan(string make, string model, int tires)
        {
            Make = make;
            Model = model;
            Tires = tires;
        }

        public Sedan(string make)
        {
            Make = make;
        }

        private int CreateTires()
        {
            return Tires + 1;
        }
    }
}
