using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace seventhProblem
{
    class divideFactorialsByTheirDifference
    {
        static void Main()
        {
            int n;
            int k;

            BigInteger factorialK = 1;
            BigInteger factorialSimplify = 1;
            

            Console.Write("n > 1; n = ");
            bool first = int.TryParse(Console.ReadLine(), out n);
            while (first == false || n <= 1)
            {
                Console.Write("invalid input. n = ");
                first = int.TryParse(Console.ReadLine(), out n);
            }
            Console.Write("k > 1; k < n; k = ");
            bool second = int.TryParse(Console.ReadLine(), out k);
            while (second == false || k >= n || k <= 1)
            {
                Console.Write("invalid input. k = ");
                second = int.TryParse(Console.ReadLine(), out k);
            }


            
            for (int i = (n - k) + 1; i <= n; i++)
            {
                factorialSimplify *= i;
                
            }

            while (k > 1)
            {
                factorialK *= k;
                k--;
            }



            Console.WriteLine(factorialSimplify * factorialK);
        }
    }
}
