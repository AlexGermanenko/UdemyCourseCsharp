using System;
using System.ComponentModel.Design;
using static CommonLibrary.StringLibrary;

namespace HomeWork11_GuessTheNumber
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int gameMode = int.Parse(GetNotEmptyString("Choose game mode. 0 - player guess a number, 1 - computer guess a number:"));

            switch (gameMode)
            {
                case 0:
                    PlayerVsComp();
                    break;
                case 1:
                    CompVsPlayer();
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        private static void CompVsPlayer()
        {
            bool isWin = false;
            //int number = int.Parse(GetNotEmptyString("guess the number from 0 to 100:"));
            int number = new Random().Next(0, 100);

            if (number < 0 || number > 100) return;

            for (int i = 0; i < 7; i++)
            {
                int number_ = int.Parse(GetNotEmptyString("Enter the number from 0 to 100:"));
                if (number == number_)
                {
                    isWin = true;
                    break;
                }
                else if (number_ < number)
                {
                    Console.WriteLine("Your number less than guess number");
                }
                else
                {
                    Console.WriteLine("Your number more than guess number");
                }
            }

            Console.WriteLine();
            Console.WriteLine(isWin ? $"You Win!!! Guess number is {number}" : $"You Lose!!! Guess number is {number}");
            Console.Read();
        }

        private static void PlayerVsComp()
        {
            bool isWin = false;
            int number = int.Parse(GetNotEmptyString("guess the number from 0 to 100:"));

            if (number < 0 || number > 100)
            {
                Console.WriteLine($"Your number={number} out of range 0 - 100");
                return;
            }

            int number_ = 50;
            int minValue = 0;
            int maxValue = 100;

            for (int i = 0; i < 7; i++)
            {
                if (number_ > number)
                {
                    Console.WriteLine($"Your number={number_} more than guess number");
                    maxValue = number_;
                    number_ = minValue + (maxValue - minValue) / 2;

                }
                else if (number_ < number)
                {
                    Console.WriteLine($"Your number={number_} less than guess number");
                    minValue = number_;
                    number_ = minValue + (maxValue - minValue) / 2;
                }
                else
                {
                    isWin = true;
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine(isWin ? $"You Win!!! Guess number is {number}" : $"You Lose!!! Guess number is {number}");
            Console.Read();
        }
    }
}
