using System;
using static CommonLibrary.StringLibrary;

namespace HomeWork7_FactorialCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Factorial number: ");
            int value = int.Parse(GetNotEmptyString(""));

            int result = 1;
            for (int i = 1; i <= value; i++)
            {
                result *= i;
            }

            Console.WriteLine();
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
