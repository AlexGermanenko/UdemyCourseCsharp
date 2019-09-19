using System;
using System.Collections.Generic;
using static CommonLibrary.StringLibrary;

namespace HomeWork9_ParsingRomanNumbers
{
    class Program
    {
        private static Dictionary<char, int> RomanMap_ = new Dictionary<char, int>()
        {
            {'i', 1},
            {'v', 5},
            {'x', 10},
            {'l', 50},
            {'c', 100},
            {'d', 500},
            {'m', 1000}
        };


        static void Main(string[] args)
        {
            char[] romanNumbers = GetNotEmptyString("Enter roman numbers: ").ToLower().ToCharArray();
            int number = 0;
            for (int i = 0; i < romanNumbers.Length; i++)
            {
                if (i + 1 < romanNumbers.Length && RomanMap_[romanNumbers[i]] < RomanMap_[romanNumbers[i + 1]])
                {
                    number -= RomanMap_[romanNumbers[i]];
                }
                else
                {
                    number += RomanMap_[romanNumbers[i]];
                }
            }

            Console.WriteLine(number);
            Console.Read();
        }

        private static int GetArabicNumber(char romanNumber)
        {
            int result = 0;
            switch (romanNumber)
            {
                case 'i':
                    result = 1;
                    break;
                case 'v':
                    result = 5;
                    break;
                case 'x':
                    result = 10;
                    break;
                case 'l':
                    result = 50;
                    break;
                case 'c':
                    result = 100;
                    break;
                case 'd':
                    result = 500;
                    break;
                case 'm':
                    result = 1000;
                    break;
                default:
                    result = -1;
                    break;

            }
            return result;
        }
    }
}
