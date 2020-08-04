using System;

namespace July23ArrayExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Array
            //int[] arrayOne = new int[4];
            //arrayOne[0] = 1;
            //arrayOne[1] = 2;
            //arrayOne[2] = 3;
            //arrayOne[3] = 4;

            //int[] arrayTwo = new int[] { 1, 2, 3, 4, 4, 5, 6 };

            //char[] charArray =  { 'D', 'E'};

            //int[] arrayThree = arrayTwo;
            //arrayThree[1] = 100;

            //var nestedArrays = GetNestedArray();

            //PrintedNestedArrays(nestedArrays);
            const int INPUTS = 5;

            while (true)
            {
                var userNumbers = GetUserNumbers(INPUTS);
                PrintArray(userNumbers);

                Console.WriteLine("Would you like to run again? (y/n)");
                var userInput = Console.ReadLine();

                if (userInput == "n") return;
            }
            
           
        }

        private static int[] GetUserNumbers(int numberOfInputs)
        {
            int[] inputsArray = new int[numberOfInputs];

            for (int i = 0; i < inputsArray.Length; i++)
            {
                Console.WriteLine("Please enter a number: ");
                int input = int.Parse(Console.ReadLine());
                inputsArray[i] = input;
            }
            return inputsArray;
        }

        private static int SumArray(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        private static void PrintArray(int[] array)
        {
            Console.WriteLine("\n---------------------");
            Console.WriteLine("Your numbers are: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            
            int arraySum = SumArray(array);
            Console.WriteLine($"\nYour array sum is: \n{arraySum}");
        }

        //private static void PrintedNestedArrays(int[][] nestedArrays)
        //{
        //    for (int i = 0; i < nestedArrays.Length; i++)
        //    {
        //        for (int j = 0; j < nestedArrays[i].Length; j++)
        //        {
        //            Console.WriteLine($"{nestedArrays[i][j]}");
        //        }
        //    }
        //}

        //private static int[][] GetNestedArray()
        //{
        //    int[][] nestedArray = new[]
        //    {          //J 0  1  2  3  4
        //        new int[] {1, 2, 3, 4, 5 },           //1
        //        new int[] {6, 7, 8, 9 },              //2
        //        new int[] {10, 11, 12, 13, 14, 15}    //3
        //    };

        //    return nestedArray;
        //}
    }
}
