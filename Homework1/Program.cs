using System;
using System.Text;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = GetNotEmptyString("What's your name?");

            Console.WriteLine();
            Console.WriteLine($"Hello, {name}!");

            Console.WriteLine();

            string aString = GetNotEmptyString("Input number a: ");
            string bString = GetNotEmptyString("Input number b: ");

            int aNumber = int.Parse(aString);
            int bNumber = int.Parse(bString);

            Console.WriteLine();
            Console.WriteLine( $"Number a: {aNumber}, number b: {bNumber}");

            int tempNumber = aNumber;
            aNumber = bNumber;
            bNumber = tempNumber;

            Console.WriteLine($"Number a: {aNumber}, number b: {bNumber}");

            Console.WriteLine();

            aString = GetNotEmptyString("Input number: ");
            Console.WriteLine( $"Numeral count: {aString.Length}" );

            Console.Read();
        }

        public static string GetNotEmptyString(string question)
        {
            string result = "";
            while (string.IsNullOrWhiteSpace(result))
            {
                Console.WriteLine(question);
                result = Console.ReadLine();
            }
            return result;
        }
    }
}
