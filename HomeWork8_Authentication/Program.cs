using System;
using System.Threading;
using static CommonLibrary.StringLibrary;

namespace HomeWork8_Authentication
{
    class Program
    {
        static void Main(string[] args)
        {
            string result  = "The number of available tries have been exceeded";

            for (int i = 0; i < 3; i++)
            {
                string login = GetNotEmptyString("Enter login: ");
                string password = GetNotEmptyString("Enter password: ");

                if (login == "Alexander" && password == "qwerty")
                {
                    result = "Enter the System";
                    break;
                }
            }

            Console.WriteLine(result);
            Console.Read();
        }

        
    }
}
