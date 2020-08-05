using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace August5Examples
{

    class Circle : Shape
    {
        public double Radius { get; set; }
        public override int NumberOfSides { get; set; }

        private double radius;


        public Circle(double radius)
        {
            Radius = radius;
            NumberOfSides = 0;
        }

        public override double CalculateArea()
        {
            return Math.Round(Math.PI * Radius * Radius, 2);
        }

        public override double CalculatePerimeter()
        {
            return Math.Round((2 * Math.PI * Radius), 2);
        }
    }
}
