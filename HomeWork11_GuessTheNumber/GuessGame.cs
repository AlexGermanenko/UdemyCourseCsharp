using System;
using System.Collections.Generic;
using System.Text;
using static CommonLibrary.StringLibrary;

namespace HomeWork11_GuessTheNumber
{
    class GuessGame
    {
        private readonly int maxNumber;
        private readonly int tryes;
        private readonly GuessingPlayer guessingPlayer;


        public enum GuessingPlayer
        {
            human,
            computer
        }

        public GuessGame(int maxNumber = 100, int tryes = 7, GuessingPlayer guessingPlayer = GuessingPlayer.human)
        {
            this.maxNumber = maxNumber;
            this.tryes = tryes;
            this.guessingPlayer = guessingPlayer;
        }

        public void Start()
        {
            if (guessingPlayer == GuessingPlayer.human)
            {
                HumanGuesses();
            } 
            else
            {
                PCGuesses();
            }
        }

        private void PCGuesses()
        {
            bool isWin = false;
            int number = int.Parse(GetNotEmptyString($"guess the number from 0 to {maxNumber}:"));

            if (number < 0 || number > maxNumber)
            {
                Console.WriteLine($"Your number={number} out of range 0 - {maxNumber}");
                return;
            }

            int CompNumber = 0;
            int minValue = 0;
            int maxValue = maxNumber;

            for (int i = 0; i < tryes; i++)
            {
                CompNumber = minValue + (maxValue - minValue) / 2;
                if (CompNumber > number)
                {
                    Console.WriteLine($"Your number={CompNumber} more than guess number");
                    maxValue = CompNumber;
                }
                else if (CompNumber < number)
                {
                    Console.WriteLine($"Your number={CompNumber} less than guess number");
                    minValue = CompNumber;
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

        private void HumanGuesses()
        {
            bool isWin = false;
            //int number = int.Parse(GetNotEmptyString("guess the number from 0 to 100:"));
            int number = new Random().Next(0, maxNumber);

            if (number < 0 || number > 100) return;

            for (int i = 0; i < tryes; i++)
            {
                int number_ = int.Parse(GetNotEmptyString($"Enter the number from 0 to {maxNumber}:"));
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
    }
}
