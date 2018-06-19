using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twelvethProblem
{
    class switchValues
    {
        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("a = " + a + " b = " + b);
        }
    }
}
