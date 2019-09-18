using System;
using static CommonClass.Class1;

namespace HomeWork4_FindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int aNumber = int.Parse(GetNotEmptyString("Input number a: "));
            int bNumber = int.Parse(GetNotEmptyString("Input number b: "));

            Console.WriteLine(aNumber>bNumber?$"max number is a = {aNumber}":$"max number is b = {bNumber}");
            Console.Read();
        }
    }
}
