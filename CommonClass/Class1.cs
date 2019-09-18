using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
