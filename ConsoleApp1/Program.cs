using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region vars

            int x = 1;
            int y;
            y = 2;

            int x1 = 0;//same
            int x2 = new int();//same

            var a = 1.1;

            Dictionary<string, int> dict = new Dictionary<string, int>(); // the same
            var dict_ = new Dictionary<string, int>(); // the same

            decimal money = 2.1m;

            char character = 's';
            string name = "Alex";

            bool canJump = false;

            object obj = 1; //can but don't
            object obj_ = "qwerty"; //can but don't

            #endregion
            
            Console.WriteLine($"object {obj_}");
            Console.ReadLine();
        }
    }
}
