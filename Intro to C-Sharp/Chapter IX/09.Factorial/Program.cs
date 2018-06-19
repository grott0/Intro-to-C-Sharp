using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _09.Factorial
{
    class Program
    {
        static BigInteger factorial(int n)
        {

            BigInteger fac = 1;

            if (n == 0)
            {
                return 1;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    fac *= i;
                }
                return fac;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number where, 0 <= n <= 100: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}! = {1}", n, factorial(n));

        }
    }
}
