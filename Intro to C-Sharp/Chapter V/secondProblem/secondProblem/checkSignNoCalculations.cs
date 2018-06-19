using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondProblem
{
    class checkSignNoCalculations
    {
        static void Main()
        {
            double a, b, c;
            bool first, second, third;

            do
            {
                Console.Write("Enter a real number: ");
                first = double.TryParse(Console.ReadLine(), out a);
            }
            while (first == false);

            do
            {
                Console.Write("Enter another real number: ");
                second = double.TryParse(Console.ReadLine(), out b);
            }
            while (second == false);

            do
            {
                Console.Write("Enter a third real number: ");
                third = double.TryParse(Console.ReadLine(), out c);
            }
            while (third == false);


            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("The prodct is zero.");
            }
            else if (a > 0)
            {
               if (b < 0 ^ c < 0)
                {
                    Console.WriteLine("The product of these numbers is negative.");
                }
               else if ((b > 0 && c > 0) || (b < 0 && c < 0))
                {
                    Console.WriteLine("The product of these numbers is positive.");
                }
                
            }
            else if (a < 0)
            {
                if (b < 0 ^ c < 0)
                {
                    Console.WriteLine("The product of these numbers is positive.");
                }
                else if ((b > 0 && c > 0) || (b < 0 && c < 0))
                {
                    Console.WriteLine("The product of these numbers is negative.");
                }
            }
           else if (b > 0)
            {
                if (a < 0 ^ c < 0)
                {
                    Console.WriteLine("The product of these numbers is negative.");
                }
                else if ((a > 0 && c > 0) || (a < 0 && c < 0))
                {
                    Console.WriteLine("The product of these numbers is positive.");
                }

            }
            else if (b > 0)
            {
                if (a < 0 ^ c < 0)
                {
                    Console.WriteLine("The product of these numbers is positive.");
                }
                else if ((a > 0 && c > 0) || (a < 0 && c < 0))
                {
                    Console.WriteLine("The product of these numbers is negative.");
                }

            }
            else if (c > 0)
            {
                if (a < 0 ^ b < 0)
                {
                    Console.WriteLine("The product of these numbers is negative.");
                }
                else if ((a > 0 && b > 0) || (a < 0 && b < 0))
                {
                    Console.WriteLine("The product of these numbers is positive.");
                }

            }
            else if (c > 0)
            {
                if (a < 0 ^ b < 0)
                {
                    Console.WriteLine("The product of these numbers is positive.");
                }
                else if ((a > 0 && b > 0) || (a < 0 && b < 0))
                {
                    Console.WriteLine("The product of these numbers is negative.");
                }

            }
            else
            {
                Console.WriteLine("There is no way you see this text. :D");
            }

        }
    }
}
