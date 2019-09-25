using System;

namespace HomeWork14_StickGame
{
    public enum Players
    {
        Human,
        Computer
    }

    class Program
    {
        private static Players currentPlayer = Players.Human;
        private static StickGame stickGame;

        static void Main(string[] args)
        {
            stickGame = new StickGame();
            stickGame.OnLoseEvent += OnLoseAction;
            stickGame.OnStartEvent += OnStartAction;
            stickGame.OnChangePlayerEvent += OnChangePlayerAction;

            Drawer.DrawSticks(stickGame.StickCount);
            stickGame.Start();

            Console.Read();
        }



        private static void OnChangePlayerAction()
        {
            if (currentPlayer == Players.Human)
            {
                currentPlayer = Players.Computer;
                ComputerMoves();
            }
            else
            {
                currentPlayer = Players.Human;
                HumanMoves();
            }
        }

        private static void ComputerMoves()
        {
            Console.Clear();
            Drawer.DrawSticks(stickGame.StickCount);

            Console.WriteLine("Computer moves...");

            stickGame.DecreaseStickCount(); 
            // TODO computer logic
        }

        private static void HumanMoves()
        {
            Console.Clear();
            Drawer.DrawSticks(stickGame.StickCount);
            Console.WriteLine("Human moves...");
            Console.WriteLine("Enter quantity of sticks from 1 to 3:");
            stickGame.DecreaseStickCount(int.Parse(Console.ReadLine()));
        }

        private static void OnStartAction()
        {
            HumanMoves();
        }

        private static void OnLoseAction()
        {
            stickGame.OnLoseEvent -= OnLoseAction;
            stickGame.OnStartEvent -= OnStartAction;
            stickGame.OnChangePlayerEvent -= OnChangePlayerAction;
            Console.WriteLine($"Player {(Program.currentPlayer == Players.Computer?"Computer":"Human")} is lose.");
        }
    }

    public class StickGame
    {
        public event Action OnLoseEvent;
        public event Action OnStartEvent; 
        public event Action OnChangePlayerEvent;

        public int StickCount { get; private set; }

        public StickGame(int stickCount = 10)
        {
            StickCount = stickCount;
        }

        public void Start()
        {
            OnStartEvent?.Invoke();
        }

        public void DecreaseStickCount(int stickCount = 1)
        {
            if (stickCount < 1 && stickCount > 3)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (stickCount > StickCount)
            {
                stickCount = StickCount;
            }

            StickCount -= stickCount;

            if (StickCount == 0)
            {
                OnLoseEvent?.Invoke();
            }

            OnChangePlayerEvent?.Invoke();
        }
    }

    public static class Drawer
    {
        public static void DrawSticks(int stickCount)
        {
            DrawLineStick(" __    ", stickCount);
            DrawLineStick("|  |   ", stickCount, 9);
            DrawLineStick("|__|   ", stickCount);

            Console.WriteLine();
        }

        private static void DrawLineStick(string element, int stickCount, int quantity = 1)
        {
            for (int i = 0; i < quantity; i++)
            {
                for (int j = 0; j < stickCount - 1; j++)
                {
                    Console.Write(element);
                }
                Console.WriteLine(element);
            }
        }
    }
}
