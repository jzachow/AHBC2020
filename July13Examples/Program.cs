using System;

namespace July13Examples
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Exercise 19
             * 
             * Console.WriteLine("Please input a number");
            var inputOne = Console.ReadLine();
            Console.WriteLine("Please input a second number");
            var inputTwo = Console.ReadLine();

            var result = SumUserInputs(int.Parse(inputOne), int.Parse(inputTwo));

            Console.WriteLine($"Here is the sum of numbers: {result}");
            */


            bool userContinue = true;
            do
            {
                Console.WriteLine("Please input a number: ");
                var inputOne = int.Parse(Console.ReadLine());

                
                int sumNumber = SumNumbers(inputOne);


                Console.WriteLine("Sum equals: " + sumNumber);

                Console.WriteLine("\nWould you like to continue? y/n");
                var userResponse = Console.ReadLine().ToLower();
                Console.WriteLine("\n~~~~~~~~~~~~~~~\n");

                while (userResponse != "y" && userResponse != "n")
                {
                    Console.WriteLine("\nIncorrect entry. Please try again");
                    Console.WriteLine("Would you like to run again? (y/n)");
                    userResponse = Console.ReadLine().ToLower();
                    Console.WriteLine("\n~~~~~~~~~~~~~~~\n");
                }
                if (userResponse == "n")
                {
                    Console.WriteLine("Goodbye");
                    userContinue = false;
                }
            }
            while (userContinue);

        }

        

        private static int SumNumbers(int value)
        {
            int sum = 0;

            for (int i = 1; i <= value; i++)
            {
                sum += i;
            }

            return sum;
        }

        
    }
}
