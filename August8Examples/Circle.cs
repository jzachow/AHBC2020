using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace August3Examples
{

    class Circle : Shape
    {
        public double Radius { get; set; }

        private double radius;


        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.Round(Math.PI * Radius * Radius, 2);
        }
    }
}
