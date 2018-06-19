using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sixthProblem
{
    class greaterNumber
    {
        static void Main()
        {
            double x;
            double y;
            bool n = double.TryParse(Console.ReadLine(), out x);
            bool m = double.TryParse(Console.ReadLine(), out y);

            Console.WriteLine(n ? "Valid number." : "Invalid number.");
            Console.WriteLine(m ? "Valid number." : "Invalid number.");
            Console.Write("The greater number is: ");
            Console.WriteLine(x > y ? x : y);
        }
    }
}
