using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eleventhProblem
{
    class numberSequence
    {
        static void Main()
        {
            
            int n;
            Console.Write("n = ");
            bool first = int.TryParse(Console.ReadLine(), out n);
            while (first == false)
            {
                Console.Write("invalid input. n = ");
                first = int.TryParse(Console.ReadLine(), out n);
            }

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
