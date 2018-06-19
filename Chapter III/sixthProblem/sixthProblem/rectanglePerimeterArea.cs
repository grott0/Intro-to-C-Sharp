using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sixthProblem
{
    class rectanglePerimeterArea
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b =");
            double b = double.Parse(Console.ReadLine());
            double perimeter = (a + b) * 2;
            double area = a * b;
            Console.WriteLine("The perimeter is {0} and the area is {1}", perimeter, area);

        }
    }
}
