using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourthProblem
{
    class numbersFormatting
    {
        static void Main()
        {
            Console.WriteLine("Enter three numbers: ");
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string third = Console.ReadLine();

            int a;
            double b;
            double c;
            
            bool tryParseOne = int.TryParse(first, out a);
            bool tryParseTwo = double.TryParse(second, out b);
            bool tryParseThree = double.TryParse(third, out c);

            if (tryParseOne && tryParseTwo && tryParseThree)
            {
                Console.WriteLine("{0,10:X}{1,13:F2}{2,13:F2}", a, b, c);
            }
            else if (tryParseOne == false)
            {
                Console.WriteLine("The first number must be an integer!");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}

