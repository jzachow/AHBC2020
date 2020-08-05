using System;
using System.Collections.Generic;
using System.Text;

namespace August5Examples
{
    class Square : Shape
    {
        public override int NumberOfSides { get; set; }

        public double SideLength { get; set; }

        public override double CalculateArea()
        {
            return SideLength * SideLength;
        }

        public override double CalculatePerimeter()
        {
            return SideLength * 4;
        }

        public Square(double sideLength)
        {
            SideLength = sideLength;
            NumberOfSides = 4;
        }
    }
}
