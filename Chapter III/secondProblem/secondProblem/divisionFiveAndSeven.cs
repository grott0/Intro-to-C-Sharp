using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondProblem
{
    class divisionFiveAndSeven
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 35 == 0)
            {
                Console.WriteLine("Number {0} is divisible by both 5 and 7.", n);
                
            }
            else
            {
                Console.WriteLine("Number {0} is not divisible by both 5 and 7.", n);
            }
        }
    }
}
