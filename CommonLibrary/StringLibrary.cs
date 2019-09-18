using System;

namespace CommonLibrary
{
    public static class StringLibrary
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
