using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxNumber
{
    class Program
    {
        static double GetMax(double a, double b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three numbers: ");
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());
            Console.Write("The greatest of the three numbers is: ");
            Console.WriteLine(Math.Max(GetMax(first, second), third));


        }
    }
}
