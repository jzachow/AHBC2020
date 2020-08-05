using System;
using System.Collections.Generic;
using System.Text;

namespace August5Examples
{
    abstract class Shape
    {
        public abstract int NumberOfSides { get; set; }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();             
       
    }
}
