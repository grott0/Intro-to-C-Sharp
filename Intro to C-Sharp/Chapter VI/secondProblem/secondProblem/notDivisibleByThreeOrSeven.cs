using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondProblem
{
    class notDivisibleByThreeOrSeven
    {
        static void Main()
        {
            int n;
            Console.Write("n = ");
            bool first = int.TryParse(Console.ReadLine(), out n);
            while (first == false)
            {
                Console.Write("n must be an integer: ");
                first = int.TryParse(Console.ReadLine(), out n);
            }

            for (int i = 1; i <= n; i++)
            {
                if (i % 7 != 0 && i % 3 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
