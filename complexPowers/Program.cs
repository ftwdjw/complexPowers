using System;
using System.Numerics;//add in references

namespace complexPowers
{
    class MainClass
    {
        public struct complex
        {
            public double r, j;

            public complex(double r1, double j1)
            {
                r = r1;
                j = j1;
            }
        }

        public static void Main(string[] args)
        {
            complex c11 = new complex();

            c11.r = 0.0;
            c11.j = 0.0;

            Console.WriteLine("r={0},j={1}",c11.r,c11.j);

            complex c12 = new complex(3.0,4.0);

            Console.WriteLine("{0:N}+j{1:N}", c12.r, c12.j);

            complex c13 = new complex(1.0, 4.0);

            Console.WriteLine("{0:N}+j{1:N}", c13.r, c13.j);

            // Create a complex number by calling its class constructor.
            Complex c1 = new Complex(12, 6); Console.WriteLine(c1);
            // Assign a Double to a complex number.
            Complex c2 = 3.14; Console.WriteLine(c2);
            // Cast a Decimal to a complex number.
            Complex c3 = (Complex)12.3m; Console.WriteLine(c3);
            // Assign the return value of a method to a Complex variable.
            Complex c4 = Complex.Pow(Complex.One, -1); Console.WriteLine(c4);
            // Assign the value returned by an operator to a Complex variable.
            Complex c5 = Complex.One + Complex.One; Console.WriteLine(c5);
            // Instantiate a complex number from its polar coordinates.
            Complex c6 = Complex.FromPolarCoordinates(10, .524); Console.WriteLine(c6);
            Console.ReadLine();
        }
    }
}
