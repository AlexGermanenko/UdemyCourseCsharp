using System;

namespace HomeWork10_ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(1, 1);
            Complex c2 = new Complex(1,2);

            Console.WriteLine(c1.Plus(c2).ToString());
            Console.WriteLine(c1.Minus(c2).ToString());

            Console.Read();
        }

        private class Complex
        {
            public int A { get; private set; }
            public int B { get; private set; }

            private Complex()
            {
                
            }

            public Complex(int a, int b)
            {
                A = a;
                B = b;
            }

            public Complex Plus(Complex complex)
            {
                return new Complex(A + complex.A, B + complex.B);
            }

            public Complex Minus(Complex complex)
            {
                return new Complex(A - complex.A, B - complex.B);
            }

            public override string ToString()
            {
                return $"Value {A}:{B}";
            }
        }
    }
}
