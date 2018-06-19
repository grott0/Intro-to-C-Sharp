using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirteenthProblem
{
    class sumWithPrecision
    {
        static void Main()
        {

                  double x, sum = 0.0;
                  int n = 2;
            
                 do
                {
                x = 1.0 / n;
                sum += x;
                Console.Write(
                "...+1/{0,-4}={1,7:f4}; ", n++, sum);
               
                 }
                   while (x > 0.001) ;
                   Console.WriteLine();
                   Console.WriteLine("Sum = {0:f4}; ", sum);

        }
    }
}
