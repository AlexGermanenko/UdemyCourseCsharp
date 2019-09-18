using System;

namespace HomeWork2_geron_formula_
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(GetNotEmptyString("Input side a: "));
            double sideB = double.Parse(GetNotEmptyString("Input side b: "));
            double sideC = double.Parse(GetNotEmptyString("Input side c: "));

            double p = (sideA + sideB + sideC)/2;
            double square = Math.Round(Math.Sqrt(p*(p-sideA)*(p - sideB)*(p - sideC)), 2);

            Console.WriteLine();
            Console.WriteLine($"S = {square}");

            Console.Read();
        }

        private static string GetNotEmptyString(string question)
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
