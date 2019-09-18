using System;
using CommonLibrary;

namespace HomeWork5_Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthFibonachi = int.Parse(StringLibrary.GetNotEmptyString("Input Fibonachi length: "));
            ulong[] f = new ulong[lengthFibonachi];

            f[0] = 1;
            f[1] = 1;

            for (int i = 2; i < f.Length; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }

            string result = "";

            foreach (ulong i in f)
            {
                result += $"{i} ";
            }

            Console.WriteLine(result);
            Console.Read();

        }
    }
}
