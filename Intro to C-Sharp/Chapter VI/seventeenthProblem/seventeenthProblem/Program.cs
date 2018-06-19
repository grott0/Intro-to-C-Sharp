using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seventeenthProblem
{
    class Program
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int remainder;

            while (first % second != 0)
            {
                remainder = first % second;
                first = second;
                second = remainder;
            }

            Console.WriteLine("{0}",second);

        }
    }
}
