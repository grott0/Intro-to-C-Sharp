using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifthProblem
{
    class numbersToTextZeroNine
    {
        static void Main()
        {
            int n;
            Console.Write("Enter an integer where x >= 0 and x <= 9: ");
            bool exceptionCatch = int.TryParse(Console.ReadLine(), out n);

            while (exceptionCatch == false || (n < 0 || n > 9))
            {
                Console.Write("Invalid input. Try again: ");
                exceptionCatch = int.TryParse(Console.ReadLine(), out n);

            }

            switch (n)
            {
                case 0: Console.WriteLine("zero"); break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
                default: Console.WriteLine("error"); break;
            }
        }
    }
}
