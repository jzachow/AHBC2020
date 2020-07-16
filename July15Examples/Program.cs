using System;
using System.Dynamic;

namespace July15Examples
{

    public class Program
    {
        static void Main(string[] args)
        {
            //Concat
            Console.WriteLine("HI" + "I'M" + "TAYLORE");

            string somethingFunky = string.Concat("HI", "bye");
            Console.WriteLine(somethingFunky);

            Console.WriteLine($"Here is {somethingFunky}");

            //Split
            var sidSpeaks = "Sid, has a nice voice, great.";
            var sidSpeaksSplit = sidSpeaks.Split(',');
            for (int i = 0; i < sidSpeaksSplit.Length; i++)
            {
                Console.WriteLine($"Index{i}: {sidSpeaksSplit[i]}");
            }

            // Whitespace examples
            string whitespace = "               hello     world                 ";
            Console.WriteLine(whitespace.Trim());

            Console.WriteLine(whitespace.Trim().Replace("  ", " "));


            //String
            var multiTeacher = "Kori my name Elizabeth";
            var firstIndex = multiTeacher.IndexOf("Elizabeth");
            Console.WriteLine(firstIndex);
            var secondIndex = multiTeacher.IndexOf("beth");
            Console.WriteLine(secondIndex);


            //String Comparison
            var userInput = Console.ReadLine();
            if (userInput.Equals("KORI", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("HEY IT DOES EQUAL!!!");
            }

        }
    }
}
