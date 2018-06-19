using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondProblem
{
    class circleAreaPerimeter
    {
        static void Main()
        {
            Console.WriteLine("Enter the radius of the circle: ");
            string radius = Console.ReadLine();

            double r;
            double area;
            double perimeter;
            bool parse = Double.TryParse(radius, out r);

            if (parse)
            {
                perimeter = 2 * Math.PI * r;
                area = r * r * Math.PI;
                Console.WriteLine("The area is: {0}", area);
                Console.WriteLine("The perimeter is: {0}", perimeter);

            }
            else
            {
                Console.WriteLine("Invalid radius!");
            }



        }
    }
}
