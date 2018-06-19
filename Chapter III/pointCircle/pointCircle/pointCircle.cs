using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointCircle
{
    class pointCircle
    {
        static void Main()
        {
            //Enter coordinates of point(x, y)
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int radius = 5;

            // a^2 + b^2 = c^2, c = radius(maximum allowed for c)

            bool check = (x * x) + (y * y) > 25;
            
            if (check)
            {
                Console.WriteLine("The point is out of the circle.");
            }
            else
            {
                Console.WriteLine("The point is in the cirlce.");
            }

        }
    }
}
