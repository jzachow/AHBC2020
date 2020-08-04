using System;
using System.Collections.Generic;
using System.Text;

namespace August3Examples
{
    class Triangle : Shape
    {
        public double S1Length { get; set; }
        public double S2Length { get; set; } 
        public double S3Length { get; set; } 

        public override double CalculateArea()
        {
            var semiPerim = CalculatePerimeter() / 2;
            var triArea = Math.Sqrt(semiPerim * (semiPerim - S1Length) * (semiPerim - S2Length) * (semiPerim - S3Length));
            return triArea;
        }

        public Triangle(double s1Length, double s2Length, double s3Length)
        {
            S1Length = s1Length;
            S2Length = s2Length;
            S3Length = s3Length;
        }

        public double CalculatePerimeter()
        {
            return S1Length + S2Length + S3Length;
        }
    }
}
