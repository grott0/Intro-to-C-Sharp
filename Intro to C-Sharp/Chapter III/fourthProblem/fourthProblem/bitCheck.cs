using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourthProblem
{
    class bitCheck
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int mask = 1;
            int check = mask << 3;
            int result = check & n;

            if (result != 0)
            {
                Console.WriteLine("The third bit is 1");

            }
            else
            {
                Console.WriteLine("The third bit is 0");
            }

        }
    }
}
