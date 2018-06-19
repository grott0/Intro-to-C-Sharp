using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hypotenuse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(a, 2)  + Math.Pow(b, 2));
            Console.WriteLine("c = {0}", c); 
        }
    }
}
