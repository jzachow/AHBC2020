using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;

namespace July27thExamples
{
    class Program
    {

        //    private static bool UserContinueSelection { get; set; } = true;

        //    //static void Main(string[] args)
        //    //{
        //    //    var stringList = new List<string>() { "Jason" };
        //    //    stringList.Add("Cory");
        //    //    stringList.RemoveAt(2);
        //    //    var cory = stringList.ElementAt(2);
        //    //    var result = stringList.Where(entry => entry.Contains("Jason"));

        //    //    var stringList = new List<string>();


        //    //    Console.WriteLine("Hello input some string!");

        //    //    while (UserContinueSelection)
        //    //    {
        //    //        var userInput = Console.ReadLine();
        //    //        var userInput2 = Console.ReadLine();
        //    //        stringList.AddRange(new List<string> { userInput, userInput2 });


        //    //        foreach (var item in stringList)
        //    //        {
        //    //            Console.WriteLine(item);
        //    //        }
        //    //        UserContinue();
        //    //    }
        //    //}

        //    static void Main(string[] args)
        //    {

        //        //var dictionaryForUserInput = new Dictionary<int, string>() { { 1, "Sandy" }, { 2, "Bernard" } };
        //        //dictionaryForUserInput.Add(0, "Shari");

        //        //dictionaryForUserInput.TryGetValue(1, out string bernard);
        //        //var bernardKey = dictionaryForUserInput.First(entry => entry.Value.Contains("Bernard")).Key;

        //        //foreach (var item in dictionaryForUserInput)
        //        //{
        //        //    if (item.Value.Contains("Bernard"))
        //        //    {
        //        //        var bernardKeyInLoop = item.Key;
        //        //    }
        //        //}
        //        //Console.WriteLine($"We found {bernard}");


        //        while (UserContinueSelection)
        //        {
        //            var dictionaryOfUserInput = new Dictionary<int, string>();
        //            Console.WriteLine("Hello input some string"!);
        //            var userInput = Console.ReadLine();
        //            Console.WriteLine("Input another string!");
        //            var userInput2 = Console.ReadLine();

        //            var listOfUserInputs = new List<string>();
        //            listOfUserInputs.AddRange(new List<string> { userInput, userInput2 });

        //            foreach (var item in listOfUserInputs)
        //            {
        //                dictionaryOfUserInput.Add(listOfUserInputs.FindIndex(entry => entry.Contains(item)), item);
        //            }


        //            UserContinue();
        //        }
        //    }

        //    private static void UserContinue()
        //    {
        //        Console.WriteLine("Do you desire to continue?");
        //        var userDesire = Console.ReadLine();


        //        if (userDesire.Contains("Y", StringComparison.CurrentCultureIgnoreCase))
        //        {
        //            UserContinueSelection = true;
        //        }
        //        else
        //        {
        //            UserContinueSelection = false;
        //        }
        //    }
        //}

        static void Main(string[] args)
        {

            IEnumerable<int> userNumbers = new List<int>();
            bool userContinue = true;

            while (userContinue)
            {
                Console.WriteLine("Please enter a number: ");
                int userInput = int.Parse(Console.ReadLine());
                userNumbers = userNumbers.Concat(new List<int> { userInput});

                Console.WriteLine("Press 'n' to quit, any other key to continue");
                string userDesire = Console.ReadLine();

                if (userDesire.Contains("n", StringComparison.CurrentCultureIgnoreCase))
                {
                    userContinue = false;
                }
                
            }

            int sum = 0;
            foreach (var item in userNumbers)
            {
                Console.WriteLine(item);
                sum += item;
            }

            Console.WriteLine($"Your sum is {sum}");

        }
    }
}
