using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seventhProblem
{
    class weightMoon
    {
        static void Main()
        {
            Console.Write("Enter your weight: ");
            double earth = double.Parse(Console.ReadLine());
            double moon = earth * 0.17;
            Console.WriteLine("Your weight on the moon is {0}", moon);
        }
    }
}
