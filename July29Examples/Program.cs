using System;
using System.Collections.Generic;
using System.Threading;

namespace July29Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal("Red", "Tiger", "Fred", 10);         
            var animal = new Animal();
            var dog = new Dog();
            dog.Bark();
            dog.Color = "Blue";


            var sedan = new Sedan("Ford", "Focus", 3);
            sedan.Build();

            Console.WriteLine(animal.Color);
            Automobile automobile = new Sedan("Chevy", "Malibu", 4);
            Automobile automobile2 = new Wagon();

            List<Wagon> wagons = new List<Wagon>();

            List<Automobile> automobiles = new List<Automobile>()
            {
                new Wagon(),
                new Sedan("Buick", "Encore", 5),
                new Mustang("Chevy", "Malibu", 4),
            };

            foreach (var auto in automobiles)
            {
                Console.WriteLine(auto.Make);
            }


            //Exercise 42
            Console.WriteLine("Exter X coordinate: ");
            var xPoint = Console.ReadLine();
            Console.WriteLine("Enter Y coordinate: ");
            var YPoint = Console.ReadLine();

            var point = new Point(xPoint, YPoint);
            Console.WriteLine($"Here is the XPoint {point.X}. Here is the Y Point {point.Y}");

            var mustang = new Mustang("Ford", "Focus", 3);
            mustang.Build();
        }
    }
}
