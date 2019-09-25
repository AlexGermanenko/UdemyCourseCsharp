using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using static HomeWork13_WordGame.WordGameWithDelegates;

namespace HomeWork13_WordGame
{
    class Program
    { 
        static void Main(string[] args)
        {
            WordGameWithDelegates wordGame = new WordGameWithDelegates();
            wordGame.WinLoseHandler(WinLoseHandler);
            wordGame.GenerateNextWord();

            while (wordGame.GetWinner() == GameState.inGame)
            {
                Console.Clear();

                /*foreach (char c in wordGame.Word)
                {
                    Console.Write(c);
                }
                Console.WriteLine();*/

                foreach (char c in wordGame.CheckedLetters)
                {
                    Console.Write($"{c}, ");
                }
                Console.WriteLine();

                Console.WriteLine(wordGame.GetWord());
                Console.WriteLine($"attempts left: {wordGame.Tries}");

                wordGame.CheckLetter(char.Parse(Console.ReadLine()));
            }

            
        }

        static void WinLoseHandler(GameState gameState, char[] word)
        {
            Console.Clear();
            foreach (char c in word)
            {
                Console.Write(c);
            }
            Console.WriteLine();

            Console.WriteLine(gameState == WordGameWithDelegates.GameState.win ? "You win!!!" : "You lose :-(");

            Console.Read();
        }

        #region without



        /*static void Main(string[] args)
        {
            WordGame wordGame = new WordGame();
            wordGame.GenerateNextWord();

            while (wordGame.GetWinner() == WordGame.GameState.inGame)
            {
                Console.Clear();*/

        /*foreach (char c in wordGame.Word)
        {
            Console.Write(c);
        }
        Console.WriteLine();*/

        /*foreach (char c in wordGame.CheckedLetters)
        {
            Console.Write($"{c}, ");
        }
        Console.WriteLine();

        Console.WriteLine(wordGame.GetWord());
        Console.WriteLine($"attempts left: {wordGame.Tries}");

        wordGame.CheckLetter(char.Parse(Console.ReadLine()));
    }

    Console.Clear();
    foreach (char c in wordGame.Word)
    {
        Console.Write(c);
    }
    Console.WriteLine();

    Console.WriteLine(wordGame.GetWinner() == WordGame.GameState.win ? "You win!!!" : "You lose :-(");

    Console.Read();
}*/
        #endregion
    }

    public class WordGame
    {
        public char[] Word { get; private set; }
        private string ResultWord { get; set; }
        public int Tries { get;private set; }
        public string CheckedLetters { get; private set; }

        public enum GameState
        {
            inGame,
            win,
            lose
        }

        public WordGame(int tries = 6)
        {
            Tries = tries;
            CheckedLetters = "";
        }

        public void GenerateNextWord()
        {

            string[] words = File.ReadAllLines("WordsStockRus.txt");

            Word = words[new Random().Next(0, words.Length - 1)].ToCharArray();
            foreach (var letter in Word)
            {
                ResultWord += '?';
            }
        }

        public void CheckLetter(char letter)
        {
            if (!Word.Contains(letter))
            {
                Tries--;
            }

            CheckedLetters += letter;

            ResultWord = "";
            foreach (char letter_ in Word)
            {
                if (CheckedLetters.Contains(letter_))
                {
                    ResultWord += letter_;
                }
                else
                {
                    ResultWord += '?';
                }
            }
        }

        public string GetWord()
        {
            return ResultWord;
        }

        public GameState GetWinner()
        {
            GameState gameState = GameState.inGame;


            if (Tries == 0)
            {
                gameState = GameState.lose;
            }
            else if (!ResultWord.Contains('?'))
            {
                gameState = GameState.win;
            }
            
            return gameState;
        }
    }

    public class WordGameWithDelegates
    {
        public delegate void WinLose(GameState gameState, char[] word);

        private WinLose winLose;

        public char[] Word { get; private set; }
        private string ResultWord { get; set; }
        public int Tries { get; private set; }
        public string CheckedLetters { get; private set; }

        public enum GameState
        {
            inGame,
            win,
            lose
        }

        public WordGameWithDelegates(int tries = 6)
        {
            Tries = tries;
            CheckedLetters = "";
        }

        public void GenerateNextWord()
        {

            string[] words = File.ReadAllLines("WordsStockRus.txt");

            Word = words[new Random().Next(0, words.Length - 1)].ToCharArray();
            foreach (var letter in Word)
            {
                ResultWord += '?';
            }
        }

        public void CheckLetter(char letter)
        {
            if (!Word.Contains(letter))
            {
                Tries--;
            }

            CheckedLetters += letter;

            ResultWord = "";
            foreach (char letter_ in Word)
            {
                if (CheckedLetters.Contains(letter_))
                {
                    ResultWord += letter_;
                }
                else
                {
                    ResultWord += '?';
                }
            }
        }

        public string GetWord()
        {
            return ResultWord;
        }

        public GameState GetWinner()
        {
            GameState gameState = GameState.inGame;


            if (Tries == 0)
            {
                gameState = GameState.lose;
                winLose(gameState, Word);
            }
            else if (!ResultWord.Contains('?'))
            {
                gameState = GameState.win;
                winLose(gameState, Word);
            }

            return gameState;
        }

        public void WinLoseHandler(WinLose winLose)
        {
            this.winLose += winLose;
        }
    }
}


