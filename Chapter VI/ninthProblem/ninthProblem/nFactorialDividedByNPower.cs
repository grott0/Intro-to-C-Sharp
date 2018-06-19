using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace ninthProblem
{
    class nFactorialDividedByNPower
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            double power = 1;
            double factorial = 1;
            double sum = 0;
            BigInteger test = new BigInteger(3.3432443243434234322133123213213213211231232332112213);

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                power *= x;
                sum += factorial / power;
            }
            Console.WriteLine(sum + 1);

            Console.WriteLine(test);
            

        }
    }
}
