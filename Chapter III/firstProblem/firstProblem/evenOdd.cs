using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProblem
{
    class evenOdd
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int result = n % 2;

            Console.WriteLine(result == 0 ? "even" : "odd");
        }
    }
}
