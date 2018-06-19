using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace twelvethProblem
{
    class fibonacciFirstHundredNumbers
    {
        static void Main()
        {


            BigInteger a = 0;
            BigInteger b = 1;
            BigInteger c = 0;


            Console.WriteLine("The first 100 numbers of the Fibonacci sequence are: ");


            for (int i = 0; i < 100; i++)
            {
                c = a + b;
                Console.WriteLine(c + " ");
                a = b;
                b = c;
            }
            Console.WriteLine();

        }
    }
}
