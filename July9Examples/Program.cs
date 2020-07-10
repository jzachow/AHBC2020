using System;
using System.Text;

namespace July9Examples
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Exercise 1
            * 
            * Console.WriteLine("How old are you?");
           string userInput = Console.ReadLine();

           Console.WriteLine("How tall are you?");
           var userHeight = Console.ReadLine();


           bool success = int.TryParse(userInput, out int number);
           bool success2 = int.TryParse(userHeight, out int height);

           if (number >= 21 && height > 6)
               Console.WriteLine("You are old enough to drink!");
           else
           {
               Console.WriteLine("You are not old enough to drink!");
           }

           if (number >=21)
           {
               Console.WriteLine("Hey what drink will you have?");
           }
           else if (number < 21)
           {
               Console.WriteLine("Hey you are too young....get outta here");
           }
           else if (number <10)
           {
               Console.WriteLine("Hey you are a baby");
           }
           else
           {
               Console.WriteLine("I don't even know");
           }


           switch (number)
           {
               case int num when number >= 21 && number < 30:
                   Console.WriteLine("You are old enough to drink");
                   break;
               case 15:
                   Console.WriteLine("Not old enough");
                   break;
               case 10:
                   Console.WriteLine("Where are your parents");
                   break;
               default:
                   Console.WriteLine("I have no clue");
                   break;
           } */






            /* Exercise 2
             * 
             * Console.WriteLine("Please enter your age: ");
            string userInput = Console.ReadLine();

            bool success = int.TryParse(userInput, out int age);

            if(age < 16)
            {
                Console.WriteLine("You are too young to drive");
            }
            else if (age >= 16 && age < 18)
            {
                Console.WriteLine("You are allowed to drive on a learner's permit with an adult in the vehicle.");
            }

            else if (age >= 18)
            {
                Console.WriteLine("You are old enough to drive!");
            }

            else
            {
                Console.WriteLine("What are you?");
            }

            */


            // Exercise 3
            bool cont = false;
            do
            {
                Console.WriteLine("Please enter a number: ");
                int number = int.Parse(Console.ReadLine());


                for (int i = number; i >= 0; i--)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("Would you like to continue? (y/n)");
                string userPrompt = Console.ReadLine();

                if (userPrompt == "y")
                {
                     cont = true;
                }
                else
                {
                    cont = false;
                }


            } while(cont);
        }
    }
}
