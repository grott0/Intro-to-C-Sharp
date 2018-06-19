using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourthProblem
{
    class sortThreeNumbersDecreasingOrder
    {
        static void Main()
        {
            double a, b, c;
            bool first, second, third;

            do
            {
                Console.Write("a = ");
                first = double.TryParse(Console.ReadLine(), out a);
            } while (first == false);
            do
            {
                Console.Write("b = ");
                second = double.TryParse(Console.ReadLine(), out b);
            } while (second == false);
            do
            {
                Console.Write("c = ");
                third = double.TryParse(Console.ReadLine(), out c);
            } while (third == false);

            if (a == b && a == c)
            {
                Console.WriteLine("{0} = {1} = {2}", a, b, c);
            }
            else if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("{0} > {1} > {2}", a, b, c);
                }
                else if ( b == c)
                {
                    Console.WriteLine("{0} > {1} = {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0} > {1} > {2}", a, c, b);
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("{0} > {1} > {2}", b, a, c);
                }
                else if (a == c)
                {
                    Console.WriteLine("{0} > {1} = {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0} > {1} > {2}", a, c, a);
                }
            }
            else if (c > a && c > b)
            {
                if (b > a)
                {
                    Console.WriteLine("{0} > {1} > {2}", c, b, a);
                }
                else if (b == a)
                {
                    Console.WriteLine("{0} > {1} = {2}", c, b, a);
                }
                else
                {
                    Console.WriteLine("{0} > {1} > {2}", c, a, b);
                }
            }
            else if (a == b && a > c)
            {
                Console.WriteLine("{0} = {1} > {2}", a, b, c);
            }
            else if (b == c && c > a)
            {
                Console.WriteLine("{0} = {1} > {2}", c, b, a);
            }
            else
            {
                Console.WriteLine("unreachable.");
            }
        }
    }
}
