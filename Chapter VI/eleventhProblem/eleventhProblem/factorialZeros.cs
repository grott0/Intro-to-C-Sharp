using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace eleventhProblem
{
    class factorialZeros
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);

            while (factorial % 10 == 0)
            {
                factorial /= 10;
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
