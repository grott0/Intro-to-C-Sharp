using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdProblem
{
    class greatestOfThree
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
                Console.Write("b = ");
                third = double.TryParse(Console.ReadLine(), out c);
            } while (third == false);


            double firstCheck = Math.Max(a, b);
            double secondCheck = Math.Max(firstCheck, c);
            Console.WriteLine("The greatest number is: {0}", secondCheck);
        }
    }
}
