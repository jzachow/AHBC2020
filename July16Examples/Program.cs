using System;
using System.Text;

namespace July16Examples
{
    public class Program
    {
        static void Main(string[] args)
        {

            //StringBuilder
            //var stringBuilder = new StringBuilder("Darion is teaching");
            //stringBuilder.Append(" but we don't understand.");
            //Console.WriteLine(stringBuilder);
            //Console.WriteLine(stringBuilder.ToString());

            //Exceptions
            var userInput = Console.ReadLine();
            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            finally
            {
                var hi = "hi";
            }

        }
    }
}
