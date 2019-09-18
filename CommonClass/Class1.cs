using System;

namespace CommonClass
{
    public static class Class1
    {
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
