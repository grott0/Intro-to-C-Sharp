using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ninthProblem
{
    class quadraticEquation
    {
        static void Main()
        {
            double a;
            double b;
            double c;

            Console.Write("a = ");
            bool first = double.TryParse(Console.ReadLine(), out a);
            while (first == false)
            {
                Console.WriteLine("invalid input.");
                Console.Write("a = ");
                first = double.TryParse(Console.ReadLine(), out a);
            }

            Console.Write("b = ");
            bool second = double.TryParse(Console.ReadLine(), out b);
            while (second == false)
            {
                Console.WriteLine("invalid input");
                Console.Write("b = ");
                second = double.TryParse(Console.ReadLine(), out b);
            }

            Console.Write("c = ");
            bool third = double.TryParse(Console.ReadLine(), out c);
            while (third == false)
            {
                Console.WriteLine("invalid input");
                Console.Write("c = ");
                third = double.TryParse(Console.ReadLine(), out c);
            }

            double D = (b * b) - 4 * a * c;
            double x1 = (-b + Math.Sqrt(D)) / 2.0;
            double x2 = (-b - Math.Sqrt(D)) / 2.0;
            
            if ( D > 0 )
            {
                Console.WriteLine("D > 0");
                Console.Write("x1 = {0}  ", x1);
                Console.Write("x2 = {0}", x2);
                Console.WriteLine();
            }
            else if ( D == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("D = 0");
                Console.Write("x = {0}", x1);
                Console.WriteLine();
            }
            else
            {
                
                Console.WriteLine("D < 0");
                Console.Write("No real roots.");
                Console.WriteLine();
            }


        }
    }
}
