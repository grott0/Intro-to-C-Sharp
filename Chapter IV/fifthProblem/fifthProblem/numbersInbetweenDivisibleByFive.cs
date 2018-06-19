using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifthProblem
{
    class numbersInbetweenDivisibleByFive
    {
        static void Main()
        {

            int x;
            int y;
            Console.WriteLine("Enter two integers");
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            bool tryParseOne = int.TryParse(first, out x);
            bool tryParseTwo = int.TryParse(second, out y);

            if (tryParseOne && tryParseTwo)
            {
                int counter = 0;
                for (int i = Math.Min(x,y); i <= Math.Max(x,y); i++)
                {
                    if (i % 5 == 0)
                    {
                        counter++;
                    }
                }
                Console.WriteLine("There are {0} numbers divisible by 5 in this scope.", counter);
            }
            else
            {
                Console.WriteLine("invalid input!");
            }


            
        }
    }
}
