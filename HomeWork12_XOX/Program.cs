using System;
using System.Collections.Generic;

namespace HomeWork12_XOX
{
    class Program
    {
        static void Main(string[] args)
        {
            GameXOX game = new GameXOX();
            game.Start();
        }
    }

    public class GameXOX
    {
        private readonly char[] elements;
        private Dictionary<int, char> xo;

        public GameXOX()
        {
            elements = new char[9]{' ',' ',' ',' ',' ',' ',' ',' ',' '};
            xo = new Dictionary<int, char>()
            {
                {0,'X'},
                { 1,'O'}
            };
        }

        public void Start()
        {
            for (int i = 0; i < elements.Length; i++)
            {
                Draw();

                xo.TryGetValue(i%2,out char element);
                int index = 0;

                do
                {
                    Console.WriteLine($"Enter number of seek: {element}");
                    index = int.Parse(Console.ReadLine());

                } while (elements[index] != ' ');

                elements[index] = element;

                if (CheckForWinner())
                {
                    Draw();
                    Console.WriteLine("You Win!!!");
                    Console.Read();
                    break;
                }
            }

            
        }

        private bool CheckForWinner()
        {
            bool result = false;

            List<int[]> varList =  new List<int[]>()
            {
                new int[]{1,1,1,0,0,0,0,0,0},
                new int[]{0,0,0,1,1,1,0,0,0},
                new int[]{0,0,0,0,0,0,1,1,1},
                new int[]{1,0,0,1,0,0,1,0,0},
                new int[]{0,1,0,0,1,0,0,1,0},
                new int[]{0,0,1,0,0,1,0,0,1},
                new int[]{1,0,0,0,1,0,0,0,1},
                new int[]{0,0,1,0,1,0,1,0,0},
            };

            foreach (int[] items in varList)
            {
                char element = ' ';
                int count = 0;

                for (int i = 0; i < items.Length; i++)
                {
                    if(items[i] == 0) continue;

                    char elementTemp = elements[i];
                    if (element != elementTemp && element != ' ' || elementTemp == ' ')
                    {
                        break;
                    }
                    element = elements[i];
                    count++;
                    if (count == 3)
                    {
                        break;
                    }
                }

                if (count == 3)
                {
                    result = true;
                }
            }

            return result;
        }

        private void Draw()
        {
            Console.Clear();
            Console.WriteLine($" {elements[0]} | {elements[1]} | {elements[2]} ");
            Console.WriteLine("-----------");
            Console.WriteLine($" {elements[3]} | {elements[4]} | {elements[5]} ");
            Console.WriteLine("-----------");
            Console.WriteLine($" {elements[6]} | {elements[7]} | {elements[8]} ");
        }
    }
}
