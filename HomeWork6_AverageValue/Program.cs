using System;
using  static CommonLibrary.StringLibrary;

namespace HomeWork6_AverageValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int i = 0;
            int value = 0;

            Console.WriteLine("Enter values: ");

            do
            {
                value = int.Parse(GetNotEmptyString(""));
                array[i] = value;
                i++;
            } while (i <= 10 && value != 0);

            int result = 0;

            for (int j = 0; j < array.Length; j++)
            {
                result += array[j];
                if (array[j] == 0)
                {
                    result = result / j;
                    break;
                }
            }

            Console.WriteLine(result);
            Console.Read();
        }
    }
}
