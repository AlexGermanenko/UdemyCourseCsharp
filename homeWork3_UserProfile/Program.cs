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
            double weight = double.Parse(GetNotEmptyString("What's your weight?"));
            double height = double.Parse(GetNotEmptyString("What's your height?"));

            Console.WriteLine();

            double IMT = Math.Round(weight / (height * height), 2);
            
            Console.WriteLine($"Your profile:{Environment.NewLine}" +
                              $"Full Name: {surname}, {name}{Environment.NewLine}" +
                              $"Age: {age}{Environment.NewLine}" +
                              $"Weight: {weight}{Environment.NewLine}" +
                              $"Height: {height}{Environment.NewLine}" +
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
