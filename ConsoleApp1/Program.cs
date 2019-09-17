using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Arithmetics();

            //Overflow();

            //Scope();

            //Variables();

            //Literals();

            Console.Read();
        }

        private static void Arithmetics()
        {
            int x = 1;

            x++;
            Console.WriteLine(x);

            Console.WriteLine(++x);
            Console.WriteLine(x++);

            Console.WriteLine();

            Console.WriteLine(x += 2);
            Console.WriteLine(x -= 2);
            Console.WriteLine(x *= 3);
            Console.WriteLine(x /= 3);

            Console.WriteLine();
        }

        private static void Overflow()
        {
            checked
            {
                uint x = UInt32.MaxValue;
                Console.WriteLine(x);

                x++;
                Console.WriteLine(x);

                x--;
                Console.WriteLine(x);
            }
        }

        #region scope

        private static void Scope()
        {
            int a = 1;
            {
                int b = 2;
                {
                    int c = 3;

                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }

                Console.WriteLine(a);
                Console.WriteLine(b);
                //Console.WriteLine(c);
            }

            Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
        }

        #endregion

        #region literals
        private static void Literals()
        {
            #region 2x

            int x = 0b101;
            int y = 0b1011;
            int z = 0b10001;
            int k = 0b10001111;    //the same
            int kk = 0b1000_1111;  //the same

            Console.WriteLine($"literals 2x: {x}, {y}, {z}, {k}, {kk}");

            #endregion

            #region 16x

            x = 0x1b1;
            y = 0x10c1;
            z = 0x1ad01;
            k = 0x1adc1111;    //the same
            kk = 0x1adc_1111;  //the same

            Console.WriteLine($"literals 16x: {x}, {y}, {z}, {k}, {kk}");

            #endregion

            Console.WriteLine();

            Console.WriteLine(4.5E3);
            Console.WriteLine(6.2E-2);

            Console.WriteLine();

            Console.WriteLine('\x78');
            Console.WriteLine('\x5A');

            Console.WriteLine('\u0420');
            Console.WriteLine('\u0421');
        }
        #endregion

        #region vars
        private static void Variables()
        {
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

            Console.WriteLine($"object: {obj_}");
        }
        #endregion

    }
}
