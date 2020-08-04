using System;
using System.Collections.Generic;

namespace Assessment1a
{
    class Program
    {
        static List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };


        static void Main(string[] args)
        {
            var vowelTest = IsVowel('i');
            var vowelCountTest = CountVowels("aaaaaaaeioubgbgsdkghsjkdhgskjdhgkjsd");
            var tooManyTest = TooManyVowels("This is a test eeeeeee");

            Console.WriteLine(vowelTest);
            Console.WriteLine(vowelCountTest);
            Console.WriteLine(tooManyTest);
        }

        public static bool IsVowel(char letter)
        {            
            return vowels.Contains(letter);
        }

        public static int CountVowels(string input)
        {
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i])) 
                    count++;               
            }

            return count;
        }

        public static string TooManyVowels(string input)
        {
            int vowelCount = CountVowels(input);

            if (vowelCount >= 8) return "too many vowels";
            else if (vowelCount >= 5 && vowelCount <= 7) return "right amount of vowels";
            else return "few vowels";
        }


    }
}
