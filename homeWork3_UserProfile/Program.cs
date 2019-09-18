using System;

namespace homeWork3_UserProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = GetNotEmptyString("What's your name?");
            string surname = GetNotEmptyString("What's your surname?");
            int age = int.Parse(GetNotEmptyString("What's your age?"));
            double weight = double.Parse(GetNotEmptyString("What's your weight? kg"));
            double height = double.Parse(GetNotEmptyString("What's your height? meter"));

            Console.WriteLine();

            double IMT = Math.Round(weight / (height * height), 2);
            string nl = Environment.NewLine;

            Console.WriteLine($"Your profile:{nl}" +
                              $"Full Name: {surname}, {name}{nl}" +
                              $"Age: {age}{nl}" +
                              $"Weight: {weight}{nl}" +
                              $"Height: {height}{nl}" +
                              $"Body mass index: {IMT}");

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
