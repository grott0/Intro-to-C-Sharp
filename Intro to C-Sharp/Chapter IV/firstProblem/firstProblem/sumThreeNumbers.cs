using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProblem
{
    class sumThreeNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter three numbers: ");
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string third = Console.ReadLine();

            int a;
            int b;
            int c;
            int sum;

            bool tryParseFirst = Int32.TryParse(first, out a);
            bool tryParseSecond = Int32.TryParse(second, out b);
            bool tryParseThird = Int32.TryParse(third, out c);

            if (tryParseFirst && tryParseSecond && tryParseThird)
            {
                sum = a + b + c;
                Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, sum);
            }
            else
            {
                Console.Beep(900, 1000);
                Console.WriteLine("You entered an invalid number!");
            }

        }
    }
}
