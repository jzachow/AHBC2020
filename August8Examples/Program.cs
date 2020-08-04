using System;

namespace August3Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Circle circle = new Circle(120);
            Triangle triangle = new Triangle(3, 4, 5);


            Console.WriteLine($"Area of circle: {circle.CalculateArea()}");
            Console.WriteLine($"Area of triangle: {triangle.CalculateArea()}");
        }
    }
}
