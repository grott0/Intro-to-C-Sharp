using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ninthProblem
{
    class pointCircleRectangle
    {
        static void Main()
        {
            //Enter coordinates for point(x,y)
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());

            if ((x * x) + (y * y) < 25 && y >= 1 && x <= 5 && x >= -1 && y <= 5)
            {
                Console.WriteLine("In the circle, in the rectangle.");
            }
            else if ((x * x) + (y * y) < 25 && y <= 1 && x >= 5 && x <= -1 && y >= 5)
            {
                Console.WriteLine("In the circle, out of the rectangle.");
            }
            else if ((x * x) + (y * y) > 25 && y >= 1 && x <= 5 && x >= -1 && y <= 5)
            {
                Console.WriteLine("Out of the circle, in the rectangle.");
            }
            else
            {
                Console.WriteLine("Out of both.");
            }
        }
    }
}
