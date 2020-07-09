using System;
using System.Linq;

namespace July7Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercise 1
             * 
             * Console.WriteLine("Please enter a string!");
             string input = Console.ReadLine();
             Console.WriteLine($"You entered: {input}");*/



            /* Exercise 2
             * 
             * Console.WriteLine("Please enter a number");
            var input = Console.ReadLine();
            int x = int.Parse(input) + 1;
            Console.WriteLine(x);

            */

            /* Exercise 3
             * 
            Console.WriteLine("Please enter a number");
            double input = double.Parse(Console.ReadLine()) + 0.5;
            Console.WriteLine(input);

            */


            Console.WriteLine("Please enter a number: \n");
            double numOne = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter another number: \n");
            double numTwo = double.Parse(Console.ReadLine());

            Console.WriteLine("The sum of your numbers is:\n" + (numOne + numTwo));


        }
    }
}
