using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProblem
{
    class switchVariableContent
    {
        static void Main()
        {
            int a, b;
            bool first, second;

            do
            {
                Console.Write("a = ");
                first = int.TryParse(Console.ReadLine(), out a);
            } while (first == false);

            do
            {
                Console.Write("b = ");
                second = int.TryParse(Console.ReadLine(), out b);

            } while (second == false);

            if (a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
                Console.WriteLine("a = {0} b = {1}", a, b);
                

            }
            else
            {
                Console.WriteLine("The second integer is greater.");
            }
        }
    }
}
