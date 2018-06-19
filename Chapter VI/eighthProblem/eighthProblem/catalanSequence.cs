using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace eighthProblem
{
    class catalanSequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorialOne = 1;
            BigInteger factorialTwo = 1;


            //simplify n*2 / n + 1

            for (int i = n + 2; i <= 2 * n; i++)
            {
                factorialOne *= i;
            }
            for (int j = 1; j <= n; j++)
            {
                factorialTwo *= j;
            }

            Console.WriteLine(factorialOne / factorialTwo);

        }
    }
}
